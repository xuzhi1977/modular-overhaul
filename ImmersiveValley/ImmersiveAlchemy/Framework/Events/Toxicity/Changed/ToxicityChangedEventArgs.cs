﻿namespace DaLion.Stardew.Alchemy.Framework.Events.Toxicity;

#region using directives

using System;
using StardewValley;

#endregion using directives

internal class ToxicityChangedEventArgs : EventArgs, IToxicityChangedEventArgs
{
    /// <inheritdoc />
    public Farmer Player { get; }

    /// <inheritdoc />
    public double NewValue { get; }

    /// <inheritdoc />
    public double OldValue { get; }

    /// <summary>Construct an instance.</summary>
    /// <param name="oldValue">The old toxicity value.</param>
    /// <param name="newValue">The old charge value.</param>
    internal ToxicityChangedEventArgs(Farmer player, double oldValue, double newValue)
    {
        Player = player;
        OldValue = oldValue;
        NewValue = newValue;
    }
}