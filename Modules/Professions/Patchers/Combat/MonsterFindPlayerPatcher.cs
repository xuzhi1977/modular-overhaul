﻿namespace DaLion.Overhaul.Modules.Professions.Patchers.Combat;

#region using directives

using System.Linq;
using System.Reflection;
using DaLion.Overhaul.Modules.Professions.Extensions;
using DaLion.Overhaul.Modules.Professions.VirtualProperties;
using DaLion.Shared.Extensions.Stardew;
using DaLion.Shared.Harmony;
using HarmonyLib;
using StardewValley.Monsters;

#endregion using directives

[UsedImplicitly]
internal sealed class MonsterFindPlayerPatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="MonsterFindPlayerPatcher"/> class.</summary>
    internal MonsterFindPlayerPatcher()
    {
        this.Target = this.RequireMethod<Monster>("findPlayer");
        this.Prefix!.priority = Priority.First;
    }

    #region harmony patches

    /// <summary>Patch to override monster aggro.</summary>
    [HarmonyPrefix]
    [HarmonyPriority(Priority.First)]
    private static bool MonsterFindPlayerPrefix(Monster __instance, ref Farmer? __result)
    {
        if (Game1.ticks % 10 == 0)
        {
            return false; // don't run original logic
        }

        try
        {
            var location = Game1.currentLocation;
            Farmer? target = null;
            if (__instance is GreenSlime slime)
            {
                var piped = slime.Get_Piped();
                if (piped is not null)
                {
                    var aggroee = slime.GetClosestCharacter(out _, location.characters
                        .OfType<Monster>()
                        .Where(m => !m.IsSlime()));
                    if (aggroee is not null)
                    {
                        piped.FakeFarmer.Position = aggroee.Position;
                        target = piped.FakeFarmer;
                    }
                }
            }
            else
            {
                var taunter = __instance.Get_Taunter();
                if (taunter is not null)
                {
                    var fakeFarmer = __instance.Get_FakeFarmer();
                    if (fakeFarmer is not null)
                    {
                        fakeFarmer.Position = taunter.Position;
                        target = fakeFarmer;
                    }
                }
            }

            __result = target ?? (Context.IsMultiplayer
                ? __instance.GetClosestFarmer(out _, predicate: f => f is not FakeFarmer && !f.IsInAmbush())
                : Game1.player);
            __instance.Set_Target(__result);
            return false; // don't run original logic
        }
        catch (Exception ex)
        {
            Log.E($"Failed in {MethodBase.GetCurrentMethod()?.Name}:\n{ex}");
            return true; // default to original logic
        }
    }

    #endregion harmony patches
}
