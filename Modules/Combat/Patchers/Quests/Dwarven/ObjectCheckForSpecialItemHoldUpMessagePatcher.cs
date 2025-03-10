﻿namespace DaLion.Overhaul.Modules.Combat.Patchers.Quests.Dwarven;

#region using directives

using DaLion.Overhaul.Modules.Combat.Enums;
using DaLion.Overhaul.Modules.Combat.Integrations;
using DaLion.Shared.Extensions;
using DaLion.Shared.Extensions.Stardew;
using DaLion.Shared.Harmony;
using HarmonyLib;
using StardewValley.Tools;

#endregion using directives

[UsedImplicitly]
internal sealed class ObjectCheckForSpecialItemHoldUpMessagePatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="ObjectCheckForSpecialItemHoldUpMessagePatcher"/> class.</summary>
    internal ObjectCheckForSpecialItemHoldUpMessagePatcher()
    {
        this.Target = this.RequireMethod<SObject>(nameof(SObject.checkForSpecialItemHoldUpMeessage));
    }

    #region harmony patches

    /// <summary>Add Dwarvish Blueprint obtain message.</summary>
    [HarmonyPostfix]
    private static void ObjectCheckForSpecialItemHoldUpPrefix(SObject? __instance, ref string? __result)
    {
        if (__instance is null || !JsonAssetsIntegration.DwarvishBlueprintIndex.HasValue ||
            __instance.ParentSheetIndex != JsonAssetsIntegration.DwarvishBlueprintIndex.Value)
        {
            return;
        }

        var found = Game1.player.Read(DataKeys.BlueprintsFound).ParseList<int>();
        switch (found.Count)
        {
            case 0:
                return;

            case 1:
                var type = (WeaponType)new MeleeWeapon(found[0]).type.Value;
                var typeString = type is WeaponType.StabbingSword or WeaponType.DefenseSword ? "sword" : type.ToStringFast().ToLowerInvariant();
                var typeDisplayName = _I18n.Get("weapons." + typeString).ToString().ToLower();
                __result = Game1.player.canUnderstandDwarves
                    ? I18n.Blueprint_Found_First_Known(typeDisplayName)
                    : I18n.Blueprint_Found_First_Unknown(typeDisplayName);
                break;

            default:
                __result = Game1.player.mailReceived.Contains("clintForge")
                    ? I18n.Blueprint_Found_Next_Known()
                    : I18n.Blueprint_Found_Next_Unknown() + (Game1.player.canUnderstandDwarves
                        ? string.Empty
                        : I18n.Blueprint_Found_NeedGuide());
                break;
        }
    }

    #endregion harmony patches
}
