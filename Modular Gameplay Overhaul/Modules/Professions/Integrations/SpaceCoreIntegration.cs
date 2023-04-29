﻿namespace DaLion.Overhaul.Modules.Professions.Integrations;

#region using directives

using DaLion.Shared.Attributes;
using DaLion.Shared.Integrations;
using DaLion.Shared.Integrations.SpaceCore;

#endregion using directives

[RequiresMod("spacechase0.SpaceCore", "SpaceCore", "1.12.0")]
internal sealed class SpaceCoreIntegration : ModIntegration<SpaceCoreIntegration, ISpaceCoreApi>
{
    /// <summary>Initializes a new instance of the <see cref="SpaceCoreIntegration"/> class.</summary>
    internal SpaceCoreIntegration()
        : base("spacechase0.SpaceCore", "SpaceCore", "1.12.0", ModHelper.ModRegistry)
    {
    }

    /// <summary>Instantiates and caches one instance of every <see cref="SCSkill"/>.</summary>
    internal void LoadSpaceCoreSkills()
    {
        this.AssertLoaded();
        foreach (var skillId in this.ModApi.GetCustomSkills())
        {
            // checking if the skill is loaded first avoids re-instantiating the skill
            if (SCSkill.Loaded.ContainsKey(skillId))
            {
                continue;
            }

            SCSkill.Loaded[skillId] = new SCSkill(skillId);
            Log.T($"[PROFS]: Successfully loaded the custom skill {skillId}.");
        }
    }
}
