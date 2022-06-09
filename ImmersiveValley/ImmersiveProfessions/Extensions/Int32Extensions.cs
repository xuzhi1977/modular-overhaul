﻿using System.Linq;
using DaLion.Common.Extensions;

namespace DaLion.Stardew.Professions.Extensions;

#region using directives

using System;
using StardewModdingAPI.Enums;

#endregion using directives

/// <summary>Extensions for the <see cref="int"/> primitive type.</summary>
public static class Int32Extensions
{
    /// <summary>Get the name of a given profession by index.</summary>
    public static string ToProfessionName(this int professionIndex)
    {
        if (Enum.IsDefined(typeof(Profession), professionIndex))
            return Enum.Parse<Profession>(professionIndex.ToString()).ToString();
        
        if (professionIndex > 100 && Enum.IsDefined(typeof(Profession), professionIndex - 100))
            return Enum.Parse<Profession>((professionIndex - 100).ToString()).ToString();
        
        if (!ModEntry.CustomSkills.Any(s => professionIndex.IsIn(s.ProfessionIds)))
            throw new ArgumentException($"Profession {professionIndex} does not exist.");
        
        var theSkill = ModEntry.CustomSkills.Single(s => professionIndex.IsIn(s.ProfessionIds));
        return theSkill.ProfessionNamesById[professionIndex];
    }

    /// <summary>Get the name of a given profession by index.</summary>
    public static SkillType GetCorrespondingSkill(this int professionIndex)
    {
        return (SkillType) (professionIndex / 6);
    }

    /// <summary>Whether a given object index corresponds to algae or seaweed.</summary>
    public static bool IsAlgae(this int objectIndex)
    {
        return objectIndex is 152 or 153 or 157;
    }

    /// <summary>Whether a given object index corresponds to trash.</summary>
    public static bool IsTrash(this int objectIndex)
    {
        return objectIndex is > 166 and < 173;
    }
}