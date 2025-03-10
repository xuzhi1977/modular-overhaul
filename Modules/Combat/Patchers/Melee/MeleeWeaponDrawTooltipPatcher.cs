﻿namespace DaLion.Overhaul.Modules.Combat.Patchers.Melee;

#region using directives

using System.Reflection;
using DaLion.Overhaul.Modules.Combat.Extensions;
using DaLion.Overhaul.Modules.Combat.VirtualProperties;
using DaLion.Shared.Constants;
using DaLion.Shared.Harmony;
using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Tools;

#endregion using directives

[UsedImplicitly]
internal sealed class MeleeWeaponDrawTooltipPatcher : HarmonyPatcher
{
    /// <summary>Initializes a new instance of the <see cref="MeleeWeaponDrawTooltipPatcher"/> class.</summary>
    internal MeleeWeaponDrawTooltipPatcher()
    {
        this.Target = this.RequireMethod<MeleeWeapon>(nameof(MeleeWeapon.drawTooltip));
    }

    #region harmony patches

    /// <summary>Make weapon stats human-readable..</summary>
    [HarmonyPrefix]
    private static bool MeleeWeaponDrawTooltipPrefix(
        MeleeWeapon __instance, SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha)
    {
        if (!CombatModule.Config.EnableWeaponOverhaul ||
            CombatModule.Config.WeaponTooltipStyle == Config.TooltipStyle.Vanilla || __instance.isScythe())
        {
            return true; // run original logic
        }

        try
        {
            // write description
            var descriptionWidth = Reflector
                .GetUnboundMethodDelegate<Func<Item, int>>(__instance, "getDescriptionWidth")
                .Invoke(__instance);
            Utility.drawTextWithShadow(
                spriteBatch,
                Game1.parseText(__instance.description, Game1.smallFont, descriptionWidth),
                font,
                new Vector2(x + 16f, y + 20f),
                Game1.textColor);
            y += (int)font.MeasureString(Game1.parseText(__instance.description, Game1.smallFont, descriptionWidth)).Y;

            var co = Game1.textColor;

            // write damage
            if (__instance.hasEnchantmentOfType<RubyEnchantment>())
            {
                co = new Color(0, 120, 120);
            }

            Utility.drawWithShadow(
                spriteBatch,
                Game1.mouseCursors,
                new Vector2(x + 20f, y + 20f),
                new Rectangle(120, 428, 10, 10),
                Color.White,
                0f,
                Vector2.Zero,
                4f,
                false,
                1f);

            var text = Game1.content.LoadString(
                "Strings\\UI:ItemHover_Damage",
                __instance.Get_MinDamage(),
                __instance.Get_MaxDamage());
            Utility.drawTextWithShadow(
                spriteBatch,
                text,
                font,
                new Vector2(x + 68f, y + 28f),
                co * 0.9f * alpha);
            y += (int)Math.Max(font.MeasureString("TT").Y, 48f);

            // write bonus knockback
            var relativeKnockback = __instance.Get_DisplayedKnockback();
            if (relativeKnockback != 0)
            {
                co = __instance.hasEnchantmentOfType<AmethystEnchantment>() ? new Color(0, 120, 120) : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(70, 428, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = I18n.Ui_ItemHover_Knockback($"{relativeKnockback:+#.#%;-#.#%}");
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus crit rate
            var relativeCritChance = __instance.Get_DisplayedCritChance();
            if (relativeCritChance != 0)
            {
                co = __instance.hasEnchantmentOfType<AquamarineEnchantment>()
                    ? new Color(0, 120, 120)
                    : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(40, 428, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = Game1.parseText(I18n.Ui_ItemHover_CRate($"{relativeCritChance:+#.#%;-#.#%}"), Game1.smallFont, descriptionWidth);
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus crit power
            var relativeGetCritPower = __instance.Get_DisplayedCritPower();
            if (relativeGetCritPower != 0)
            {
                co = __instance.hasEnchantmentOfType<JadeEnchantment>() ? new Color(0, 120, 120) : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(160, 428, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = I18n.Ui_ItemHover_CPow($"{relativeGetCritPower:+#.#%;-#.#%}");
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus swing speed
            var speed = __instance.Get_DisplayedSwingSpeed();
            if (speed != 0)
            {
                co = __instance.hasEnchantmentOfType<EmeraldEnchantment>() ? new Color(0, 120, 120) : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(130, 428, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = Game1.parseText(I18n.Ui_ItemHover_SwingSpeed($"{speed:+#.#%;-#.#%}"), Game1.smallFont, descriptionWidth);
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus cooldown reduction
            var cooldownReduction = __instance.Get_DisplayedCooldownReduction();
            if (cooldownReduction > 0)
            {
                co = new Color(0, 120, 120);
                Utility.drawWithShadow(
                    spriteBatch,
                    Textures.TooltipsTx,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(10, 0, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = I18n.Ui_ItemHover_Cdr($"-{cooldownReduction:#.#%}");
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus defense
            var resistance = __instance.Get_DisplayedResilience();
            if (resistance != 0f)
            {
                co = __instance.hasEnchantmentOfType<TopazEnchantment>() ? new Color(0, 120, 120) : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(110, 428, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = CombatModule.Config.NewResistanceFormula
                    ? I18n.Ui_ItemHover_Resist($"{resistance:+#.#%;-#.#%}")
                    : Game1.content.LoadString("Strings\\UI:ItemHover_DefenseBonus", __instance.addedDefense.Value)
                        .Replace("+", string.Empty);
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write light emittance
            if (__instance.InitialParentTileIndex == WeaponIds.HolyBlade || __instance.IsInfinityWeapon())
            {
                co = __instance.IsInfinityWeapon()
                    ? Color.DeepPink
                    : Game1.textColor;
                Utility.drawWithShadow(
                    spriteBatch,
                    Textures.TooltipsTx,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(0, 0, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = I18n.Ui_Item_Hover_Light();
                Utility.drawTextWithShadow(spriteBatch, text, font, new Vector2(x + 68f, y + 28f), co * 0.9f * alpha);
                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            // write bonus random forges
            if (__instance.enchantments.Count > 0 && __instance.enchantments[^1] is DiamondEnchantment)
            {
                co = new Color(0, 120, 120);
                var randomForges = __instance.GetMaxForges() - __instance.GetTotalForgeLevels();
                var randomForgeString = randomForges != 1
                    ? Game1.content.LoadString("Strings\\UI:ItemHover_DiamondForge_Plural", randomForges)
                    : Game1.content.LoadString("Strings\\UI:ItemHover_DiamondForge_Singular", randomForges);

                Utility.drawTextWithShadow(
                    spriteBatch,
                    randomForgeString,
                    font,
                    new Vector2(x + 16f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

            co = new Color(120, 0, 210);

            // write other enchantments
            for (var i = 0; i < __instance.enchantments.Count; i++)
            {
                var enchantment = __instance.enchantments[i];
                if (!enchantment.ShouldBeDisplayed())
                {
                    continue;
                }

                Utility.drawWithShadow(
                    spriteBatch,
                    Game1.mouseCursors2,
                    new Vector2(x + 20f, y + 20f),
                    new Rectangle(127, 35, 10, 10),
                    Color.White,
                    0f,
                    Vector2.Zero,
                    4f,
                    false,
                    1f);

                text = BaseEnchantment.hideEnchantmentName ? "???" : enchantment.GetDisplayName();
                Utility.drawTextWithShadow(
                    spriteBatch,
                    text,
                    font,
                    new Vector2(x + 68f, y + 28f),
                    co * 0.9f * alpha);

                y += (int)Math.Max(font.MeasureString("TT").Y, 48f);
            }

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
