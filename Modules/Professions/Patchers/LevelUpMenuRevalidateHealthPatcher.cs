﻿namespace DaLion.Overhaul.Modules.Professions.Patchers;

#region using directives

using System.Reflection;
using DaLion.Overhaul.Modules.Professions;
using DaLion.Overhaul.Modules.Professions.Extensions;
using DaLion.Shared.Extensions.Stardew;
using DaLion.Shared.Harmony;
using HarmonyLib;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using StardewValley.Menus;

#endregion using directives

[UsedImplicitly]
internal sealed class LevelUpMenuRevalidateHealthPatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="LevelUpMenuRevalidateHealthPatcher"/> class.</summary>
    internal LevelUpMenuRevalidateHealthPatcher()
    {
        this.Target = this.RequireMethod<LevelUpMenu>(nameof(LevelUpMenu.RevalidateHealth));
    }

    #region harmony patches

    /// <summary>
    ///     Patch revalidate player health after changes to the combat skill + revalidate fish pond capacity after changes
    ///     to the fishing skill.
    /// </summary>
    [HarmonyPrefix]
    private static bool LevelUpMenuRevalidateHealthPrefix(Farmer farmer)
    {
        var expectedMaxHealth = 100;
        if (farmer.mailReceived.Contains("qiCave"))
        {
            expectedMaxHealth += 25;
        }

        for (var i = 1; i <= farmer.combatLevel.Value; i++)
        {
            if (!farmer.newLevels.Contains(new Point(Skill.Combat, i)))
            {
                expectedMaxHealth += 5;
            }
        }

        if (farmer.HasProfession(Profession.Fighter))
        {
            expectedMaxHealth += 15;
        }

        if (farmer.HasProfession(Profession.Brute))
        {
            expectedMaxHealth += 25;
        }

        if (farmer.maxHealth != expectedMaxHealth)
        {
            Log.W($"[PRFS]: Fixing max health of {farmer.Name}.\nCurrent: {farmer.maxHealth}\nExpected: {expectedMaxHealth}");
            farmer.maxHealth = expectedMaxHealth;
            farmer.health = Math.Min(farmer.maxHealth, farmer.health);
        }

        try
        {
            var buildings = Game1.getFarm().buildings;
            for (var i = 0; i < buildings.Count; i++)
            {
                var building = buildings[i];
                if (building is not FishPond pond ||
                    !(pond.IsOwnedBy(farmer) || ProfessionsModule.Config.LaxOwnershipRequirements) ||
                    pond.isUnderConstruction())
                {
                    continue;
                }

                // revalidate fish pond capacity
                pond.UpdateMaximumOccupancy();
                pond.currentOccupants.Value = Math.Min(pond.currentOccupants.Value, pond.maxOccupants.Value);
            }
        }
        catch (Exception ex)
        {
            Log.E($"Failed in {MethodBase.GetCurrentMethod()?.Name}:\n{ex}");
            return false; // don't run original logic
        }

        return false; // don't run original logic
    }

    #endregion harmony patches
}
