﻿namespace DaLion.Stardew.Professions.Framework.Events.Ultimate;

#region using directives

using Common.Events;
using System;

#endregion using directives

/// <summary>A dynamic event raised when a <see cref="Ultimates.IUltimate"> ends.</summary>
internal sealed class UltimateDeactivatedEvent : ManagedEvent
{
    private readonly Action<object?, IUltimateDeactivatedEventArgs> _OnDeactivatedImpl;

    /// <summary>Construct an instance.</summary>
    /// <param name="callback">The delegate to run when the event is raised.</param>
    internal UltimateDeactivatedEvent(Action<object?, IUltimateDeactivatedEventArgs> callback)
        : base(ModEntry.EventManager)
    {
        _OnDeactivatedImpl = callback;
    }

    /// <summary>Raised when a player's combat <see cref="Ultimates.IUltimate"/> ends.</summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    internal void OnDeactivated(object? sender, IUltimateDeactivatedEventArgs e)
    {
        if (IsHooked) _OnDeactivatedImpl(sender, e);
    }
}