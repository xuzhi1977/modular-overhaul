﻿namespace DaLion.Overhaul.Modules.Professions.Patchers.Integration.Automate;

#region using directives

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using DaLion.Overhaul.Modules.Professions.Extensions;
using DaLion.Overhaul.Modules.Professions.Integrations;
using DaLion.Shared.Attributes;
using DaLion.Shared.Constants;
using DaLion.Shared.Enums;
using DaLion.Shared.Extensions.Reflection;
using DaLion.Shared.Extensions.Stardew;
using DaLion.Shared.Harmony;
using HarmonyLib;

#endregion using directives

[UsedImplicitly]
[ModRequirement("Pathoschild.Automate", "Automate")]
internal sealed class GenericObjectMachinePatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="GenericObjectMachinePatcher"/> class.</summary>
    internal GenericObjectMachinePatcher()
    {
        this.Transpiler!.after = new[] { OverhaulModule.Tweex.Namespace };
    }

    /// <inheritdoc />
    protected override bool ApplyImpl(Harmony harmony)
    {
        foreach (var target in TargetMethods())
        {
            this.Target = target;
            if (!base.ApplyImpl(harmony))
            {
                return false;
            }
        }

        return true;
    }

    /// <inheritdoc />
    protected override bool UnapplyImpl(Harmony harmony)
    {
        foreach (var target in TargetMethods())
        {
            this.Target = target;
            if (!base.UnapplyImpl(harmony))
            {
                return false;
            }
        }

        return true;
    }

    [HarmonyTargetMethods]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return "Pathoschild.Stardew.Automate.Framework.GenericObjectMachine`1"
            .ToType()
            .MakeGenericType(typeof(SObject))
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
            .First(m => m.Name == "GenericPullRecipe" && m.GetParameters().Length == 3);

        yield return "Pathoschild.Stardew.Automate.Framework.Machines.Objects.CheesePressMachine"
            .ToType()
            .RequireMethod("SetInput");

        yield return "Pathoschild.Stardew.Automate.Framework.Machines.Objects.LoomMachine"
            .ToType()
            .RequireMethod("SetInput");
    }

    #region harmony patches

    /// <summary>Patch to apply Artisan effects to automated generic machines.</summary>
    [HarmonyTranspiler]
    [HarmonyAfter("DaLion.Overhaul.Modules.Tweex")]
    private static IEnumerable<CodeInstruction>? GenericObjectMachineTranspiler(
        IEnumerable<CodeInstruction> instructions, MethodBase original)
    {
        var helper = new ILHelper(original, instructions);

        // Injected: ApplyArtisanPerks(this.Machine, this.Location, consumable.Sample)
        // Before: return true;
        try
        {
            helper
                .Match(
                    new[]
                    {
                        new CodeInstruction(OpCodes.Ldc_I4_1),
                        new CodeInstruction(OpCodes.Ret),
                    },
                    ILHelper.SearchOption.Last)
                .Insert(
                    new[]
                    {
                        new CodeInstruction(OpCodes.Ldarg_0),
                        new CodeInstruction(
                            OpCodes.Call,
                            "Pathoschild.Stardew.Automate.Framework.BaseMachine`1"
                                .ToType()
                                .MakeGenericType(typeof(SObject))
                                .RequirePropertyGetter("Machine")),
                        new CodeInstruction(OpCodes.Ldarg_0),
                        new CodeInstruction(
                            OpCodes.Call,
                            "Pathoschild.Stardew.Automate.Framework.BaseMachine"
                                .ToType()
                                .RequirePropertyGetter("Location")),
                        new CodeInstruction(original.DeclaringType!.Name.Contains("Loom")
                            ? OpCodes.Ldloc_1
                            : OpCodes.Ldloc_0),
                        new CodeInstruction(
                            OpCodes.Callvirt,
                            "Pathoschild.Stardew.Automate.IConsumable"
                                .ToType()
                                .RequirePropertyGetter("Sample")),
                        new CodeInstruction(
                            OpCodes.Call,
                            typeof(GenericObjectMachinePatcher).RequireMethod(nameof(ApplyArtisanPerks))),
                    });
        }
        catch (Exception ex)
        {
            Log.E("Professions module failed patching modded Artisan behavior for generic Automate machines." +
                  $"\nHelper returned {ex}");
            return null;
        }

        return helper.Flush();
    }

    #endregion harmony patches

    #region injected subroutines

    private static void ApplyArtisanPerks(SObject machine, GameLocation location, Item sample)
    {
        if (!machine.IsArtisanMachine() || !machine.heldObject.Value.IsArtisanGood() ||
            sample is not SObject input)
        {
            return;
        }

        var output = machine.heldObject.Value;
        var chest = AutomateIntegration.Instance?.GetClosestContainerTo(machine, location);
        var user = ProfessionsModule.Config.LaxOwnershipRequirements ? Game1.player : chest?.GetOwner() ?? Game1.MasterPlayer;
        var r = new Random(Guid.NewGuid().GetHashCode());
        if (user.HasProfession(Profession.Artisan) ||
            (ProfessionsModule.Config.LaxOwnershipRequirements && Game1.game1.DoesAnyPlayerHaveProfession(Profession.Artisan, out _)))
        {
            output.Quality = input.Quality;
            if (!ProfessionsModule.Config.ArtisanGoodsAlwaysInputQuality)
            {
                if (r.NextDouble() > user.FarmingLevel / 30d)
                {
                    output.Quality = (int)((ObjectQuality)output.Quality).Decrement();
                    if (r.NextDouble() > user.FarmingLevel / 15d)
                    {
                        output.Quality = (int)((ObjectQuality)output.Quality).Decrement();
                    }
                }
            }
        }

        var owner = ProfessionsModule.Config.LaxOwnershipRequirements ? Game1.player : machine.GetOwner();
        if (!owner.HasProfession(Profession.Artisan))
        {
            return;
        }

        if (output.Quality < SObject.bestQuality && r.NextDouble() < 0.05)
        {
            output.Quality += output.Quality == SObject.highQuality ? 2 : 1;
        }

        if (owner.HasProfession(Profession.Artisan, true))
        {
            machine.MinutesUntilReady -= machine.MinutesUntilReady / 4;
        }
        else
        {
            machine.MinutesUntilReady -= machine.MinutesUntilReady / 10;
        }

        if (machine.ParentSheetIndex == BigCraftableIds.MayonnaiseMachine && input.ParentSheetIndex == ObjectIds.GoldenEgg &&
            !ModHelper.ModRegistry.IsLoaded("ughitsmegan.goldenmayoForProducerFrameworkMod"))
        {
            output.Quality = SObject.bestQuality;
        }
    }

    #endregion injected subroutines
}
