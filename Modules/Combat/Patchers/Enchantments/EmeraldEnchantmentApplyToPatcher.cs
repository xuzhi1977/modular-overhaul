﻿namespace DaLion.Overhaul.Modules.Combat.Patchers.Enchantments;

#region using directives

using DaLion.Overhaul.Modules.Combat.VirtualProperties;
using DaLion.Shared.Harmony;
using HarmonyLib;
using StardewValley.Tools;

#endregion using directives

[UsedImplicitly]
internal sealed class EmeraldEnchantmentApplyToPatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="EmeraldEnchantmentApplyToPatcher"/> class.</summary>
    internal EmeraldEnchantmentApplyToPatcher()
    {
        this.Target = this.RequireMethod<EmeraldEnchantment>("_ApplyTo");
    }

    #region harmony patches

    /// <summary>Rebalances Emerald enchant.</summary>
    [HarmonyPrefix]
    private static bool EmeraldEnchantmentApplyToPrefix(EmeraldEnchantment __instance, Item item)
    {
        if (item is not MeleeWeapon weapon || !CombatModule.Config.RebalancedGemstones)
        {
            return true; // run original logic
        }

        weapon.speed.Value += __instance.GetLevel();
        return false; // don't run original logic
    }

    /// <summary>Reset cached stats.</summary>
    [HarmonyPostfix]
    private static void EmeraldEnchantmentApplyPostfix(Item item)
    {
        switch (item)
        {
            case MeleeWeapon weapon:
                weapon.Invalidate();
                break;
            case Slingshot slingshot:
                slingshot.Invalidate();
                break;
        }
    }

    #endregion harmony patches
}
