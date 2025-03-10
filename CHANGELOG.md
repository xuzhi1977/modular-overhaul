﻿# MARGO Changelogs

This file contains a TL;DR of current version changes and hotfixes from across all modules. For the complete changelog, please refer to the individual changelogs of each module, linked [below](#detailed-changelogs).

## Patch 3.1.10 Highlights

* [CMBT]: Fixed weapon enchantments applying on-hit effects twice.
* [CMBT]: Improved hold-up messages for Dwarvish blueprint and others. Changed some localization keys.
* [CMBT]: Recolored the Dwarvish blueprint to a rusty orange.
* [CMBT]: Lowered default difficulty settings (check your existing configs!).
* [PRFS]: Prospector Hunts:
    * Can now trigger in Volcano Dungeon.
    * No longer incorrectly using Scavenger Hunt streak.
    * No longer produces a key exception.
    * No longer ends successfully upon warping.

## Patch 3.1.9 Highlights

* [CMBT]: Increased container spawn chance no longer applies in Skull Caverns.
* [TWX]: Fixed not being able to combine any rings with Glowstone Progression enabled.

## Patch 3.1.8 Highlights

* [PROFS + CMBT]: Improved README.md UX using `<details>` tags and colored emojis.
* [CMBT + TOLS]: Hotfix for out-of-bounds exception in auto-selection draw. Default color changed from Magenta to Aqua.
* [TOLS]: Radioactive and Mythicite upgrades will no longer be available at Clint's shop with Moon Misadventures if Forge Upgrading option is enabled.
* Renamed `optionals` folder to `compat`.

## Patch 3.1.7 Highlights

* [CMBT]: Fixed not taking damage when not holding a weapon or slingshot.
* [CMBT + TOLS]: The auto-selection border now draws behind other elements in the UI, and emulated the shadow effect of the vanilla "current tool" highlight, giving it a much better "vanilla" feel.
* [TWX]: Added ability to follow the Glowstone Ring progression at the Forge (thereby forgoing the essence cost for cinder shards). It's only logical.
* Added Grandpa's Lunar Tool textures to optionals folder so users can find them more easily.
* Minor fixes.

## Patch 3.1.6 Highlights

* [CMBT]: Changed the scaling of Steadfast enchantment so it's no longer overpowered but still finds a niche in crit. power-focus builds.
* [CMBT]: Fixed slingshot cooldown freezing when unequiped.

## Patch 3.1.5 Highlights

* Changed core ticket from MARGX to MRG.
* Changed ticker for Professions module from PROFS to PRFS.
* Debug features should be working again in the Debug build.
* [CMBT]: Added `MonsterSpawnChanceMultiplier` config setting.
* [CMBT]: Neptune Glaive now requires the player have obtained the Skull Key before it will appear in Fishing Chests.
* [CMBT]: Wizard's special Blade of Ruin dialogue will now only occur once per day, so it will no longer prevent all other dialogues.
* [CMBT]: Tweaked `VariedEncounters` settings to yield more reasonable results.
* [CMBT]: Fixed slingshot special cooldown not applying correctly.
* [PRFS]: Spelunker ladder down chance changed from additive to multiplicative.
* [PRFS]: Spelunker prestige recovery increased from +2.5% to +5% health and from +1% to +2.5% stamina per level.
* [TOLS]: Fixed not being able to apply Mythicite upgrade at the Forge.
* [TOLS]: Fixed some issues with auto-selection of Scythe and Fishing Rod.
* [TOLS]: Fixed power-up colors for Radioactive and Mythicite power levels.
* [TOLS]: Increased the default area of Radioactive and Mythicite Hoe and Watering Can.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Patch 3.1.4 Highlights

* Added translations for new chat notifications (missing JA, KO and ZH).
* [CMBT]: Receiving your final Galaxy weapon will now also reward a free pair of Space Boots.
* [CMBT]: Stabbing Sword special move will no longer clip through warps.
* [CMBT]: Fixed error thrown when trying to get Galaxy weapon with Iridium Bar config set to zero.
* [CMBT]: Fixed an issue where the player could not drift left or down using Slick Moves feature.
* [CMBT]: Fixed Savage Ring buff slowing down attack speed instead of boosting it up.
* [TXS]: Fixed debt not being collected when reloading.
* [TXS]: Default annual interest increased to 72% (was previously 12%).

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Patch 3.1.3 Highlights

* Rolled back dependency updates due to conflicts with AtraCore.
* Added missing translations. Improved some Chinese translations, thanks to xuzhi1977.
* [CMBT]: Added chat notifications for when a virtue point is gained.
* [PRFS]: Changed the way Scavenger and Prospector treasures scale with the current streak. Players should now see significantly more treasure if they manage to keep their streaks high.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Patch 3.1.2 Highlights

* Config menu now auto-detects gamepad mode and adapts accordingly.
* Added Korean GMCM translations by [Jun9273](https://github.com/Jun9273).
* Added Chinese GMCM translations by [Jumping-notes](https://github.com/Jumping-notes).
* [TWX]: Fixed Glowstone progression integration with Better Crafting.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Hotfix 3.1.1 Highlights

* Forgot to scale Garnet Node spawn back down to normal after debugging for 3.1.0.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Minor Release 3.1.0 Highlights

* Optional files `[CP] Fish Pond Data` and `[CON] Garnet Node` are now embedded in the main mod.
* Updated mod dependencies.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Major Release 3.0.0 Highlights

* Re-unification of all the combat-oriented modules: CMBT, WPNZ, SLNGS, RNGS and ENCH are now collectively known as CMBT.
    * Several redundant config settings (like those related to Auto-Selection) were consolidated.
    * Only the Glowstone Ring features from RNGS were moved to TWX instead.
* Changed several translation keys for better formatting with Pathoschild's Translation Generator. This may lead to missing translation issues, so please report if you see any.
* [CMBT]: Improvements to the Blade of Ruin questline. See the [CMBT changelog](Modules/Combat/CHANGELOG.md#3_0_0).
* [CMBT]: Blade of Dawn now also deals extra damage to shadow and undead monsters and grants a small light while held.
* [CMBT]: Blade of Dawn and Infinity weapon beams no longer cast a shadow.
* [CMBT]: Prismatic Shard ammo is no longer affected by Preserving Enchantment. That combination was broken AF.
* [CMBT]: Lowered Wabbajack probability from 0.5 to about 0.309.
* [CMBT]: Added enemy difficulty summands to config options and changed default config values for some multipliers.
* [TWX]: Re-organized config settings by skill.

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Detailed Changelogs

In-depth changelogs for existing modules.

* [Core](Modules/Core/CHANGELOG.md)
* [Professions](Modules/Professions/CHANGELOG.md)
* [Combat](Modules/Combat/CHANGELOG.md)
* [Tools](Modules/Tools/CHANGELOG.md)
* [Ponds](Modules/Ponds/CHANGELOG.md)
* [Taxes](Modules/Taxes/CHANGELOG.md)
* [Tweex](Modules/Tweex/CHANGELOG.md)

<sup><sup>[🔼 Back to top](#margo-changelogs)</sup></sup>

## Legacy Changelogs

Changelogs for modules that have been merged and no longer exist.

* [Weapons](Modules/Combat/resources/legacy/CHANGELOG_WPNZ.md)
* [Slingshots](Modules/Combat/resources/legacy/CHANGELOG_SLNGS.md)
* [Enchantments](Modules/Combat/resources/legacy/CHANGELOG_ENCH.md)
* [Rings](Modules/Combat/resources/legacy/CHANGELOG_RNGS.md)

[🔼 Back to top](#margo-changelogs)