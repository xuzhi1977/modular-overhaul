﻿namespace DaLion.Overhaul.Modules.Tools.Patchers;

#region using directives

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using DaLion.Shared.Classes;
using DaLion.Shared.Constants;
using DaLion.Shared.Extensions.Reflection;
using DaLion.Shared.Extensions.Stardew;
using DaLion.Shared.Harmony;
using HarmonyLib;
using Microsoft.Xna.Framework;
using StardewValley.Tools;

#endregion using directives

[UsedImplicitly]
internal sealed class MeleeWeaponDoDamagePatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="MeleeWeaponDoDamagePatcher"/> class.</summary>
    internal MeleeWeaponDoDamagePatcher()
    {
        this.Target = this.RequireMethod<MeleeWeapon>(nameof(MeleeWeapon.DoDamage));
    }

    #region harmony patches

    [HarmonyTranspiler]
    private static IEnumerable<CodeInstruction>? MeleeWeaponDoDamageTranspiler(IEnumerable<CodeInstruction> instructions, MethodBase original)
    {
        var helper = new ILHelper(original, instructions);

        // From: foreach (Vector2 v in Utility.removeDuplicates(Utility.getListOfTileLocationsForBordersOfNonTileRectangle(areaOfEffect)))
        // To: foreach (Vector2 v in ListInnerTiles(areaOfEffect, this))
        try
        {
            helper
                .Match(
                    new[]
                    {
                        new CodeInstruction(
                            OpCodes.Call,
                            typeof(Utility).RequireMethod(
                                nameof(Utility.getListOfTileLocationsForBordersOfNonTileRectangle))),
                    })
                .ReplaceWith(new CodeInstruction(OpCodes.Ldarg_0))
                .Move()
                .ReplaceWith(
                    new CodeInstruction(
                        OpCodes.Call,
                        typeof(MeleeWeaponDoDamagePatcher).RequireMethod(nameof(ListInnerTiles))));
        }
        catch (Exception ex)
        {
            Log.E($"Failed injecting inner tile enumerator.\nHelper returned {ex}");
            return null;
        }

        return helper.Flush();
    }

    #endregion harmony patches

    #region injected subroutines

    private static List<Vector2> ListInnerTiles(Rectangle rectange, MeleeWeapon weapon)
    {
        if (!weapon.isScythe())
        {
            return Utility.getListOfTileLocationsForBordersOfNonTileRectangle(rectange);
        }

        uint radius = weapon.InitialParentTileIndex switch
        {
            WeaponIds.Scythe => ToolsModule.Config.Scythe.RegularRadius,
            WeaponIds.GoldenScythe => ToolsModule.Config.Scythe.GoldRadius,
            _ => 0,
        };

        var tiles = radius == 0
            ? rectange.GetInnerTiles()
            : new CircleTileGrid(new Vector2(rectange.Center.X / 64, rectange.Center.Y / 64), radius).Tiles;
        return tiles.ToList();
    }

    #endregion injected subroutines
}
