﻿namespace DaLion.Overhaul.Modules.Combat.Events.GameLoop.ReturnedToTitle;

#region using directives

using DaLion.Overhaul.Modules.Combat.StatusEffects;
using DaLion.Shared.Events;
using StardewModdingAPI.Events;
using StardewValley.Monsters;

#endregion using directives

[UsedImplicitly]
[AlwaysEnabledEvent]
internal sealed class CombatReturnedToTitleEvent : ReturnedToTitleEvent
{
    /// <summary>Initializes a new instance of the <see cref="CombatReturnedToTitleEvent"/> class.</summary>
    /// <param name="manager">The <see cref="EventManager"/> instance that manages this event.</param>
    internal CombatReturnedToTitleEvent(EventManager manager)
        : base(manager)
    {
    }

    /// <inheritdoc />
    protected override void OnReturnedToTitleImpl(object? sender, ReturnedToTitleEventArgs e)
    {
        Monster_Bleeding.Values.Clear();
        Monster_Burned.Values.Clear();
        Monster_Chilled.Values.Clear();
        Monster_Frozen.Values.Clear();
        Monster_Feared.Values.Clear();
        Monster_Poisoned.Values.Clear();
        Monster_Slowed.Values.Clear();
        BleedAnimation.BleedAnimationByMonster.Clear();
        BurnAnimation.BurnAnimationByMonster.Clear();
        PoisonAnimation.PoisonAnimationByMonster.Clear();
        SlowAnimation.SlowAnimationByMonster.Clear();
        StunAnimation.StunAnimationByMonster.Clear();
        CombatModule.State.HeroQuest = null;
    }
}
