<div align="center">

# MARGO :: Professions (PRFS)

![](https://stardewcommunitywiki.com/mediawiki/images/8/82/Farming_Skill_Icon.png)
![](https://stardewcommunitywiki.com/mediawiki/images/2/2f/Mining_Skill_Icon.png)
![](https://stardewcommunitywiki.com/mediawiki/images/f/f1/Foraging_Skill_Icon.png)
![](https://stardewcommunitywiki.com/mediawiki/images/e/e7/Fishing_Skill_Icon.png)
![](https://stardewcommunitywiki.com/mediawiki/images/c/cf/Combat_Skill_Icon.png)

</div>

<!-- TABLE OF CONTENTS -->
<details  open="open"  align="left">
<summary>Table of Contents</summary>
<ol>
	<li><a href="#overview">Overview</a></li>
	<li>
		<a href="#professions">Professions</a>
		<ol>
			<li><a href="#farming">Farming</a></li>
			<li><a href="#foraging">Foraging</a></li>
			<li><a href="#mining">Mining</a></li>
			<li><a href="#fishing">Fishing</a></li>
			<li><a href="#combat">Combat</a></li>
		</ol>
	</li>
	<li><a href="#prestige">Prestige</a></li>
	<li><a href="#limit-breaks">Limit Breaks</a></li>
	<li><a href="#compatibility">Compatibility</a></li>
	<li><a href="#faq">F.A.Q.</a></li>
	<li><a href="#for-c-developers">For C# Developers</a></li>
	<li><a href="#recommended-mods">Recommended Mods</a></li>
</ol>
</details>

## Overview

This module is an extensive overhaul of vanilla professions and skills, and makes up the core of the overhaul. Almost every profession has been reworked to be an equally unique and attractive choice targetting a specific style of gameplay, many of which were simply not viable in vanilla (i.e., ranching). And while it is not guaranteed that an "optimal" path does not exist, the main goal is to create opportunities for diversified or themed strategies as well as engaging new gameplay mechanics. Gone are the ~~boring~~ uninspiring +X% sell price bonuses, and in their stead we introduce bomberman mining, thief/assassin combat, truly epic sharpshooting and even Slime taming. The new professions are meant to scale with player, provide new end-game objectives and steer the player towards new playstyles.

By popular demand this module also introduces an immersive (and completely optional) **Prestige** system, which will eventually allow the player to obtain *all* professions and open up skill progression to level 20. Also added are unique Limit Breaks for each combat profession, with accompanying new visual and sound effects.

This module was inspired by [Enai Siaion][user:enai]'s excellent [Ordinator][mod:ordinator] mod for Skyrim, and borrows many ideas (and a few assets) from the likes of [League Of Legends][url:league], [Diablo][url:diablo] and the classic [Ragnarok Online][url:ragnarok]. It also includes professions icons by [IllogicalMoodSwing][user:illogicalmoodswing] (**please visit and endorse [Profession Icons Redone][mod:icons-redone]!**).

Integrations are provided out-of-the-box for several popular mods. See the [compatibility](#compatibility) section for details.

This module is safe to enable or disable mid-save. All profession perks will be applied retroactively. However, please note that disabling this mod will have no effect on skill levels or acquired professions, so make sure to manually reset your skills and professions back to vanilla standards **before** disabling, using provided console commands.

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## Professions

The perks within ⭐<font color="gold">star text</font>⭐ refer to <font color="gold">prestige</font> variants. Written in *(parenthesis)*, these perks **replace**, and do not stack with, their regular counterpart.

### ![](https://i.imgur.com/p9QdB6L.png) Farming

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/harvester.png"/><b>Harvester (Lv5)</b> - 10% <font color="gold"><i>(⭐20%⭐)</i></font> chance for extra yield from harvested crops.
</summary>

<ul>
<font size="2">

Yields an equivalent 10% monetary bonus to vanilla on average, but also provides value if you choose not to sell raw crops.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/agriculturist.png"/><b>Agriculturist (Lv10)</b> - Crops grow 10% <font color="gold"><i>(⭐20%⭐)</i></font> faster. Grow best-quality crops organically without fertilizer.
</summary>

<ul>
<font size="2">

Allows harvesting iridium-quality crops, normally only possible with Deluxe Fertilizer. The chance is equivalent to half of the chance with Deluxe Fertilizer. This means that fertilizers are **not** obsolete.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/artisan.png"/><b>Artisan (Lv10)</b> - Artisan machines work 10% <font color="gold"><i>(⭐25%⭐)</i></font> faster. Machine output quality can be as good as input ingredient quality.
</summary>

<ul>
<font size="2">

Quality output is based on Farming level. The lowest possible quality is 2 stages below the input quality, and the highest possible quality is 1 higher than the input quality. For reference, the chance to preserve quality at level 10 is 30%. Note that the quality preservation perk is tied to the Artisan player, while the production time and quality promotion perks are tied to the machine itself; in other words, only Artisans themselves can preserve the quality of ingredients, but they can do so on any machine, whereas any non-Artisan player can benefit from faster production and quality upgrades, so long as they use a machine crafted by an Artisan player (ownership requirements can be turned off in the configs).
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/miner.png"/> <b>Rancher (Lv5)</b> - Befriend animals 2× <font color="gold"><i>(⭐3×⭐)</i></font> quicker.
</summary>

<ul>
<font size="2">

Gain double mood *and* friendship points from petting. Newborn animals are also born with a non-zero, random initial friendship.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/breeder.png"/> <b>Breeder (Lv10)</b> - Incubation 2× <font color="gold"><i>(⭐3×⭐)</i></font> faster and natural pregnancy 3× <font color="gold"><i>(⭐5×⭐)</i></font> more likely. Increase value of animals at high friendship.
</summary>

<ul>
<font size="2">

At max friendship animals are worth 2.5x their base price, instead of vanilla 1.3x. If Animal Husbandry is installed, gestation following insemination is also 2x <font color="gold"><i>(3x)</i></font> faster.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/producer.png"/> <b>Producer (Lv10)</b> - Happy animals produce 2× <font color="gold"><i>(⭐3×⭐)</i></font>as frequently. Produce is worth 5% more for every full barn or coop.
</summary>

<ul>
<font size="2">

Note that happiness, or mood, is **not** the same as friendship. Also note that this will **not** allow certain animals (i.e., cows and chickens) to produce more than once per day. Bonus produce value also applies to artisan goods derived from animal products (such as cheeses, mayos and cloth), honey (bees are animals too), and meat from Animal Husbandry or PPJA Fresh Meat. Also also note that only deluxe buildings can be considered full, and only barns and coops owned by the Producer will be considered (ownership requirements can be turned off in the configs). There is no limit to this bonus value.
</font>
</ul>
</details>

</ul>

### ![](https://i.imgur.com/jf88nPt.png) Foraging

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/forager.png"/> <b>Lv5 - Forager</b>- 20% <font color="gold"><i>(⭐40%⭐)</i></font> chance for double yield of foraged items.
</summary>

<ul>
<font size="2">

Other than the name, this profession is unchanged compared to vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/ecologist.png"/> <b>Ecologist (Lv10)</b>- Wild berries restore 50% <font color="gold"><i>(⭐100%⭐)</i></font> more health and energy. Progressively identify forage of higher quality.
</summary>

<ul>
<font size="2">

All foraged items will have the same deterministic quality, providing immediate inventory convenience. However, that quality will initially start out at silver, and progress to iridium as you gather foraged items. Unlike vanilla this perk will also apply to hoed forage (such as Winter Root, Snow Yams and Ginger), Coconuts shaken off palm trees, and mushrooms produced by Mushroom Boxes, but only if the cave owner (i.e., the host player) has the profession. It will likewise apply to crafted Mushroom Boxes and Mushroom Propagators, if either of those mods is installed.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/scavenger.png"/> <b>Scavenger (Lv10)</b>- Location of forageable items revealed. Occasionally detect buried treasure. <font color="gold"><i>⭐Time freezes during Scavenger Hunts.⭐</i></font>
</summary>

<ul>
<font size="2">

- Whenever you are outside there is a chance to trigger a short Scavenger Hunt for hidden buried treasure. Follow the purple HUD arrow to find the treasure and dig it up (with a hoe) within the time limit to obtain a reward. The larger your win streak the better your odds of obtaining rare items. You can optionally configure the HUD arrows to only appear when holding a key (LeftShift by default). This will also highlight forageable currently on-screen for your convenience.
- Also gains a chance, proportional to the Scavenger Hunt streak, to spawn additional forage when entering a new map.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/lumberjack.png"/> <b>Lumberjack (Lv5)</b>- Felled trees yield 25% <font color="gold"><i>(⭐40%⭐)</i></font> more wood.
</summary>

<ul>
<font size="2">

Other than the name, this profession is unchanged compared to vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/arborist.png"/> <b>Arborist (Lv10)</b>- All trees grow faster. Normal trees can drop <font color="gold"><i>(⭐twice as much⭐)</i></font> hardwood.
</summary>

<ul>
<font size="2">

Bonus tree growth works as a global buff; i.e., all trees in the world are affected as long as any player in the session has this profession, and the effect will stack for all additional online players that share this profession. The hardwood bonus is inherited and uchanged from vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/tapper.png"/> <b>Tapper (Lv10)</b>- Tappers are cheaper to craft. Tapped trees produce syrup 25% <font color="gold"><i>(⭐50%⭐)</i></font> faster.
</summary>

<ul>
<font size="2">

- New regular recipe: x25 wood, x1 copper bar.
- New Heavy recipe: x18 hardwood, x1 radioactive bar.
</font>
</ul>
</details>

</ul>

### ![](https://i.imgur.com/TidtIw0.png) Mining

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/miner.png"/> <b>Miner (Lv5)</b>- +1 <font color="gold"><i>(⭐+2⭐)</i></font> ore per ore vein.
</summary>

<ul>
<font size="2">

Completely unchanged compared to vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/spelunker.png"/> <b>Spelunker (Lv10)</b>- Chance to find ladders and shafts increases with every mine level. +1 speed every 10 levels. <font color="gold"><i>⭐Also recover some health and stamina with every mine level.⭐</i></font>
</summary>

<ul>
<font size="2">

Plus 0.5% ladder chance per level. Bonus ladder chance resets each time you leave the mines. **This includes taking the stairs back to the mine entrance.**
</font>
</ul>
</details>

<details>
<summary>
<img src="./resources/assets/sprites/loose/prospector.png"/> <b>Prospector (Lv10)</b>- Location of ladders and mining nodes revealed. Occasionally detect rocks with valuable minerals. <font color="gold"><i>⭐Time freezes during Prospector Hunts.⭐</i></font>
</summary>

<ul>
<font size="2">

- Analogous to Scavenger. Tracks all mining nodes and mineral forages off-screen with a yellow pointer, ladders, shafts and panning spots (when outside) with a green pointer. Whenever you are in the mines there is a chance to trigger a short Propsector Hunt for hidden stone treasure. Follow the purple HUD arrow to find the correct stone within the time limit and break it up to obtain a reward. The larger your win streak the better your odds of obtaining rare minerals or artifacts. Succesful completion of a hunt automatically reveals a ladder. You can optionally configure the HUD arrows to only appear when holding a key (LeftShift by default). This will also highlight mineral nodes and other tiles of interest currently on-screen for your convenience.
- Also gains a chance, proportional to the Prospector Hunt streak, to spawn additional ore nodes and panning points.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/blaster.png"/> <b>Blaster (Lv5)</b>- Craft twice as many explosives. Exploded rocks yield 2× <font color="gold"><i>(⭐3×⭐)</i></font> as much coal.
</summary>

<ul>
<font size="2">

This aims to provide a new style of mining while attempting to compensate for the lack of coal without the vanilla Prospector profession.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/demolitionist.png"/> <b>Demolitionist (Lv10)</b>- Bomb radius +1 <font color="gold"><i>(⭐+2⭐)</i></font>. Exploded rocks yield 20% <font color="gold"><i>(⭐40%⭐)</i></font> more resources.
</summary>

<ul>
<font size="2">

- This aims to improve the bomberman style of mining while attempting to compensate for the lack of Geologist and Gemologist professions from vanilla. As a configurable bonus, the pyromaniac in your will [get excited](https://www.youtube.com/watch?v=0nlJuwO0GDs) when hit by an explosion.
- You can also manually detonate bombs; any bombs placed while holding down the Mod Key (default LeftShift) will not detonate until you release the key.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/gemologist.png"/> <b>Gemologist (Lv10)</b>- Progressively identify gems and minerals of higher quality. Crystalariums work 25% <font color="gold"><i>(⭐50%⭐)</i></font> faster.
</summary>

<ul>
<font size="2">

Analogous to Ecologist. All gems and minerals mined from nodes have a fixed quality, starting at silver and increasing to iridium as you mine. Please note that this bonus will only apply to gems or minerals that have been either physically mined, or produced by Geode Crushers owned by the Gemologist. Crystalariums and geodes opened by Clint will **not** receive quality upgrades. The exception to this is Crystalariums already in production, which will all receive an equivalent quality upgrade whenever the owner reaches a quality milestone. The production time bonus for Crystalarium is likewise tied to the owner, and therefore only Crystalariums crafted by the Gemologist will receive that perk (ownership requirements can be turned off in the configs).
</font>
</ul>
</details>

</ul>

### ![](https://i.imgur.com/XvdVsAn.png) Fishing

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/fisher.png"/> <b>Fisher (Lv5)</b>- Baits are 2x <font color="gold"><i>(⭐3x⭐)</i></font> more effective when fishing.
</summary>

<ul>
<font size="2">

Also applies to the double catch effect of Wild Bait and bonus treasure effect of Magnet.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/angler.png"/> <b>Angler (Lv10)</b>- Fish are 0.5% more valuable for every unique species caught. Fully-expending a tackle causes it's effects to linger on the fishing rod. <font color="gold"><i>⭐Fish are another 0.5% more valuable for every unique max-sized species caught.⭐</i></font>
</summary>

<ul>
<font size="2">

- Legendary fish are instead worth 2.5% bonus to fish sell price, including Extended Family.
- Lingering tackle effects last for 40 uses (same as regular tackle), effectively doubling tackle duration, but more importantly, allowing different tackles to be used together. **The same tackle effect cannot stack with itself.**
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/aquarist.png"/> <b>Aquarist (Lv10)</b>- Fish pond max capacity +2 <font color="gold"><i>(⭐+4⭐)</i></font>. Catching bar decreases slower for every unique fish species raised in a fish pond.
</summary>

<ul>
<font size="2">

- The catching bar decreases 5.5% faster per unique Fish Pond. In multiplayer, **only counts Fish Ponds owned by the player with this profession**. Does stack with Trap Bobber.
- Also allows raising legendary fish. Extended family can be raised in the same pond as the parent if [PNDS](../Ponds) module is enabled.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/trapper.png"/> <b>Trapper (Lv5)</b>- Crab pots are cheaper to craft. Can trap higher-quality <font color="gold"><i>(⭐highest-quality⭐)</i></font> haul.
</summary>

<ul>
<font size="2">

All trapped fish can have quality up to gold. Chance depends on fishing level (same formula as forage). The Crab Pot recipe is unchanged from vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/luremaster.png"/> <b>Luremaster (Lv10)</b>- Baited Crab Pots can produce 2x <font color="gold"><i>(⭐3x⭐)</i></font> per day. Unlock new bait effects.
</summary>

<ul>
<font size="2">

- Each type bait will also apply it's regular fishing effects:
	- **Regular bait:** 25% chance to catch fish, subject to the same location and season limitations as regular fishing.
	- **Wild bait:** 50% chance to also double the haul.
	- **Magnet:** Repels all fish (as per its description), but attracts metal items such as resources, artifacts, treasure chests, rings and even some weapons (treasure table is similar to fishing treasure chests).
	- **Magic bait:** Chance to catch high-level fish of any location or season. Also upgrades all catch to iridium-quality.
- All baits, with the exception of Magnet, prevent collecting junk.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/conservationist.png"/> <b>Conservationist (Lv10)</b>- Crab pots without bait can trap junk. Clean the Valley's waters to merit tax deductions and villager favor. <font color="gold"><i>⭐Tax deductions build 50% faster.⭐</i></font>
</summary>

<ul>
<font size="2">

Every 100 (configurable) junk items collected will earn you a 1% tax deduction the following season (max 25%, also configurable). What a "tax deduction" means depends on whether the [Taxes](../Taxes/README.md) module is enabled; if it is enabled, a tax deduction works as you would expect, reducing your overall amount due. If this module is not enabled, then a tax deduction works as a % value increasing to all items shipped in the bin. If you quality for a deduction you will receive a formal mail from the Ferngill Revenue Service on the first of the season informing your currrent deduction rights.
</font>
</ul>
</details>

</ul>

### ![](https://i.imgur.com/fUnZSTj.png) Combat

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/fighter.png"/> <b>Fighter (Lv5)</b>- Damage +10% <font color="gold"><i>(⭐+15%⭐)</i></font>. +15 HP.
</summary>

<ul>
<font size="2">

Completely unchanged compared to vanilla.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/brute.png"/> <b>Brute / Amazon (Lv10)</b>- Taking damage builds rage, improving damage. +25 HP. <font color="gold"><i>⭐Rage also grants attack speed.⭐</i></font>
</summary>

<ul>
<font size="2">

**Rage:** Damage +1% per stack. *Attack speed +0.5% per stack*. Max 100 stacks. Rage slowly decays after not dealing or taking damage for 25s.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/poacher.png"/> <b>Bushwhacker (Lv10)</b>- Crit. chance +50%. Crit. strikes can poach items. <font color="gold"><i>⭐Successfully poaching an item refunds special move cooldown.⭐</i></font>
</summary>

<ul>
<font size="2">

**Poaching:** Each monsters can only be poached once. Any item from the monster's available loot table can be obtained by this method.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/rascal.png"/> <b>Rascal (Lv5)</b>- Gain one additional ammo slot. 35% <font color="gold"><i>(⭐70%⭐)</i></font> chance to recover spent ammo.
</summary>

<ul>
<font size="2">

- Press the Mod Key (default LeftShift) to cycle between equipped ammos.
- Squishy ammo (i.e., fish, fruits, veggies, and slime) and explosive ammo canot be recovered.
- Can equip Slime as ammo, which causes a slow debuff to enemies.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/desperado.png"/> <b>Desperado (Lv10)</b>- Firing speed is higher at lower HP. Can overcharge slingshots to increase ammo power and cross-section. <font color="gold"><i>⭐Overcharged shots can also pierce enemies.⭐</i></font>
</summary>

<ul>
<font size="2">

- **Overcharge:** Continue to hold the tool button to reveal the overcharge meter. Overcharged shots have increased velocity, damage, knockback and cross-section (i.e., hitbox).
- **Pierce:** Piercing chance begins at 50% and increases to 100% at full overcharge. Each pierced enemy decreases ammo power and subsequent pierce chances by 25%. Squishy projectiles (i.e., fish, fruits, veggies, and slime) cannot pierce regardless of overcharge.
</font>
</ul>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/piper.png"/> <b>Slimed Piper / Enchantress (Lv10)</b>- Attract ally Slimes when near enemies. Chance to gain a random buff when a Slime is defeated. <font color="gold"><i>⭐Chance to also recover some health and energy when a Slime is defeated.⭐</i></font>
</summary>

<ul>
<font size="2">

- Each Slime raised in a hutch adds a chance to spawn an extra Slime in dungeons and dangeorus areas, up to the number of enemies on that map.
- Obtainable buffs are the same as food/drink buffs (skill levels, attack, defense, speed, luck, max energy, magnetism). Buffs lasts 3 real-life minutes and can stack indefinitely, refreshing the duration each time. If at least one buff stack is active, also gain immunity to the Slimed debuff, even without a Slime Charmer ring (but **not** to Slime damage).
- Slime ammo deals twice as much damage, and can be used to heal ally Slimes.
</font>
</ul>
</details>

</ul>

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## Prestige

If enabled, the [Statue of Uncertainty](https://stardewvalleywiki.com/The_Sewers#Statue%20Of%20Uncertainty) is replaced by the **Statue of Prestige**.

<div align="center">

<img src="https://gitlab.com/daleao/modular-overhaul/-/raw/main/resources/screenshots/prestige_statue.gif" alt="prestige_statue.gif" width="90%">
</div>

Instead of changing your profession choices, the Statue of Prestige will reset your level 10 skills back to level 0, for a price. After resetting a skill, you will have to level up again to choose a different profession, but you get to keep every profession you've ever acquired (yes, including level 5). You will also find that leveling becomes progressively easier after each skill reset (or harder, depending on your config settings). By default, reseting a skill will also cause you to forget all associated recipes, but can also be turned off. For this incredible service, the Statue of Prestige will charge you 10,000g the first time, 50,000g the second, and 100,000g the third and last time, although the cost can also be configured. After performing three skill resets, you should have acquired all four level 10 professions simultaneously. As you reset and acquire new professions your progress will be reflected on the skills page menu, either by a new colorful star, or by a growing ribbon, depending on your settings.

Once you have acquired four stars, or the ribbon has reached its fourth stage, the level cap for the corresponding skill is raised to 20, allowing you to continue to develop your tool proficiency or max health. Other perks of higher levels include better odds of higher-quality crops, fishes and forage, a larger fishing bar, more berries foraged per bush, and longer-lasting [Limit Breaks](#limit-breaks). On top of that, at levels 15 and 20 you will be able to choose a profession to **prestige**. A prestiged profession grants improved perks or, in some cases, entirely new ones.

<div align="center">

<img src="https://gitlab.com/daleao/modular-overhaul/-/raw/main/resources/screenshots/skills_prestige.gif" alt="skills_prestige.gif" width="90%">
</div>

Only after all possible skills have had their level cap raised will the Statue of Prestige resume it's old behavior, by allowing you to change your prestige choices, for a modest fee of 20,000g (also configurable).

The entire Prestige system is optional. It may be turned off at any time, but keep in mind that doing so mid-game will not cause you to lose any already acquired professions, nor will it have any immediate effects on your skill levels. However your skill levels will be reduced to the regular cap of 10 the next time the save is loaded.

All custom mod skills based on SpaceCore are compatible with the skill reset feature, but cannot have their level cap raised above the regular 10. For skill mod developers, if you wish to provide prestiged professions you can do so by registering your skill via the provided [API](../../API/IModularOverhaulApi.cs).

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## Limit Breaks

In addition to their regular perks listed above, every level 10 profession in the Combat skill tree also grants a unique [Limit Break](https://tvtropes.org/pmwiki/pmwiki.php/Main/LimitBreak). This special ability must be charged by performing certain actions during combat. You can track the current charge by the HUD bar labeled "L".

Note that, though all combat professions can be acquired via skill reset, only one Limit Break can be registered at any time; if the Combat skill is reset, you will be asked the moment you choose your next profession whether you wish to keep or replace your current Limit Break. The four Limit Breaks are:

<ul>

<details>
<summary><img src="./resources/assets/sprites/loose/undyingrage.png"/> <b>Undying Frenzy (Brute / Amazon)</b> - For 15s, gain double rage accumulation and become immune to passing out. When the effect ends, recover 5% health for every enemy slain during the frenzy.
</summary>

<ul>
<font size="2">

Charged by taking damage or defeating enemies. Charges more quickly if enemies are defeated using a blunt weapon.
</ul>
</font>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/cloaking.png"/> <b>Ambuscade (Bushwhacker)</b> - Become invisible and untargetable for 30s. Effect ends prematurely if the player attacks an enemy. When the effect ends, gain a 2x crit. power buff that lasts for twice the leftover invisibility duration. If an enemy is slain within 0.5s out of Ambush, immediately regain 25% Limit charge.
</summary>

<ul>
<font size="2">

Charged by scoring critical hits, and the charge amount is proportional to crit. power.
</ul>
</font>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/bullettime.png"/> <b>Death Blossom (Desperado)</b> - For 15s, enable auto-fire and all shots fire in eight directions at once at no additional ammo cost.
</summary>

<ul>
<font size="2">

- Journey of the Prairie King, "IRL".
- Charged by hitting monsters with projectiles. Charges more quickly when low on health.
</ul>
</font>
</details>

<details>
<summary><img src="./resources/assets/sprites/loose/superfluidity.png"/> <b>Hamelin Concerto (Slimed Piper / Enchantress)</b> - Charm nearby Slimes for 30s. Charmed Slimes become enlarged and empowered, and seek out other enemies, tanking and stealing their aggro.
</summary>

<ul>
<font size="2">

- The amount by which each Slime will grow is random, up to twice the original size. Slimes gain a proportional damage and health boost.
- If defeated, engorged Slimes break up into smaller baby Slimes.
- There is also a low chance to convert Slimes to a special variant. If "Prismatic Jelly" special order is active, low chance to convert the Slime to the prismatic variant.
- Nearby Big Slimes explode immediately.
- Charged by being touched by Slimes, or by defeating Slimes and Big Slimes.
</ul>
</font>
</details>

</ul>

After all possible skills have had their level cap raised, the Statue of Prestige will let you switch between the four Limit Breaks for free (though a cost can be configured). Switching Limmit Breaks is not possible if the Prestige system is disabled. As with the Prestige system, Limit Breaks can be turned off in the mod settings.

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## Compatibility

<details>
<summary> 🟩 <b><font color="green">The following mods are fully integrated:</font></b> 🟩 </summary>

- All [SpaceCore][mod:spacecore] custom skills are fully supported by the skill reset systems, including but not limited to: [Luck Skill][mod:luck], [Cooking Skill][mod:cooking], [Magic][mod:magic], [Love Of Cooking][mod:loc], [Binning Skill][mod:binning] and [Socializing Skill][mod:socializing]. However, **only skills which explicitly provide prestiged professions will be supported by the Prestige system**. An [API](../../ModApi.cs) is provided for mod authors to register their custom skills for prestige. Authors are responsible for providing the prestige perks and functionality of their own professions, as well as corresponding prestige icons and descriptions.
- [Automate][mod:automate] machines will apply Artisan, Ecologist and Gemologist perks to all appropriate machines which meet the ownership requirements (if that setting is enabled). In the case of machines that are not crafted, such as the Farm Cave Mushroom Boxes and terrain features like Berry Bushes and Fruit Trees, only the session host's professions will apply. In cases which consider the professions of the user, and not of the owner, then the owner of the closest chest in the automation group is used.
- [Producer Framework Mod][mod:pfm] and [PFMAutomate][mod:pfm-automate] respect the same rules as above, but not all machines are compatible by default. Machines from the following PPJA packs and addons are compatible out-of-the-box:
	- [Artisan Valley][mod:artisan-valley]
	- [Artisanal Soda Makers][mod:soda-makers]
	- [Fizzy Drinks][mod:fizzy-drinks]
	- [Shaved Ice & Frozen Treats][mod:frozen-treats]
	If any other mods are used which add artisan machines, you can manually add them to the 	CustomArtisanMachines list in the config. Note that this list cannot be configured in-game via GMCM; it must be configured manually in the config.json file.
- [Animal Husbandry Mod][mod:husbandry] will be affected by Breeder and Producer professions; Breeder will reduce pregnancy time, and Producer's price bonus will be applied to meats.
- [Fresh Meat][mod:fresh-meat] crops are considered animals products and not actually crops, and therefore will also benefit from Producer profession.
- [Better Junimos][mod:better-junimos] will carry over profession perks, provided the corresponding config setting is enabled.
- [Mushroom Propagator][mod:mushroom-propagator] will be affected by the Ecologist quality perk.
- [Custom Ore Nodes][mod:con] will also be tracked by Prospector.
- [Teh's Fishing Overhaul][mod:tfo] will respect fishing profession bonuses; the optional Recatchable Legendaries file is also compatible.
- [Vintage Interface][mod:vintage-ui] will be automatically detected and the Limit gauge will be changed accordingly to match the installed version (v1 and v2 are both supported).
- [Stardew Valley Expanded][mod:sve] will also change the look of the Limit gauge in Galdora maps to match the Galdoran UI theme.
- [CJB Cheats Menu][mod:cjb-cheats], if you download the optional translation files, will display this mod's profession names under Skill Cheats menu.
- [Archery][mod:archery] bows and crossbows will also apply Rascal and Desperado perks.
</details>

<details>
<summary> 🟨 <b><font color="yellow">The following mods are compatible without integration:</font></b> 🟨 </summary>

- [Multi Yield Crops][mod:myc]
- [Craftable Mushroom Boxes][mod:mushroom-boxes]
- [Better Beehouses][mod:better-beehouses]
- [Forage Fantasy][mod:forage-fantasy]
- [Capstone Professions][mod:capstone]
</details>

<details>
<summary> 🟥 <b><font color="red">The following mods are NOT compatible:</font></b> 🟥 </summary>

- Any mods that change vanilla skills.
- [Better Crab Pots][mod:better-crab-pots], [Crab Pot Loot Has Quality And Bait Effects][mod:crab-pot-loot] or any mod that affects Crab Pot behavior.
- [Better Slingshots][mod:better-slingshots], [Ring Overhaul][mod:ring-overhaul], or any mod that affects Slingshot behavior.
- [Quality Artisan Products][mod:qap] and [Quality Artisan Products for Artisan Valley][mod:qap-av], as they will be overriden by this mod's changes to the Artisan profession (use [Flower Meads][mod:flower-meads] instead for the namesake feature).
- [All Professions][mod:all-professions] and [Skill Prestige][mod:prestige], as they conflict with this mod's Prestige system. You could potentially use them if you disable this mod's Prestige system, but I will not provide support in case of bugs.
- [Yet Another Harvest With Scythe Mod][mod:yahwsm] will not apply modded profession perks. Use instead the feature included in CJB Cheats Menu.
</details>

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## F.A.Q.

<details>
<summary><b>Do Ecologist and Gemologist professions count forages/gems acquired before the profession?</b></summary>

No.
</details>

<details>
<summary><b>Do Artisan/Producer/Aquarist and similar professions based on ownership of a machine or building, apply retroactively to machines/buildings that have already been crafted/built?</b></summary>

Yes.
</details>

<details>
<summary><b>Can Luremaster and Conservationist work together?</b></summary>

Yes. Otherwise the whole Prestige thing wouldn't make any sense.
Luremaster applies only to Crab Pots with bait, whereas Conservationist applies only to Crab Pots without.
</details>

<details>
<summary><b>Can I obtain all prestige professions simultaneously?</b></summary>

No, sorry. Making tough choices is part of this mod's design.
You can cheat them in with console commands if you really want (`profs add -p all`).  
</details>

<details>
<summary><b>Can I obtain all Limit Breaks simultaneously?</b></summary>

Obviously not.
</details>

<details>
<summary><b>What do Legendary Fish produce in Fish Ponds? How long do they take to multiply?</b></summary>

They will produce ores, gems and other valuables fitting to the fish's theme, as well as, obviously, roe.
With the exception of Angler when placed together with Ms. Angler (requires [PNDS](../Ponds)), they do not reproduce.
</details>

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## For C# Developers

The module exposes an API to facilitate integration with other mods. Currently exposed endpoints include:

- Checking the current quality of Ecologist forage or Gemologist minerals.
- Checking the current tax deduction bracket for Conservationist.
- Forcing new Treasure Hunt events, or interrupting active Treasure Hunts.
- Triggering events when a Treasure Hunt starts or ends.
- Checking a player's registered Ultimate ability.
- Triggering events when a player's Ultimate gains charge, becomes active or inactive.
- Checking whether the Ultimate HUD element is currently being displayed (useful for UI mods to decide whether to reposition their own HUD elements).
- Checking the player's config settings for this mod.
- Registering custom skills for Prestige.

To consume the API, copy both interfaces from the [API folder](../../API/) namespace to your project and [ask SMAPI for a proxy][wiki:integrations-api].

<sup><sup>[🔼 Back to top](#margo--professions-profs)</sup></sup>

## Recommended Mods

- [Artisan Valley][mod:artisan-valley] to add more variety to Artisan and Producer products.
- [Slime Produce][mod:slime-produce] (makes Slime ranching more interesting and profitable).
- [Ostrich Mayo and Golden Mayo][mod:new-mayo] (better consistency for Ostrich and Golden eggs in combination with Artisan profession).
- [Skill Training][mod:skill-training] (immersively speed-up your skill resets).
- [Tap Giant Crops][mod:tap-giant-crops] (do more with the Tapper profession).﻿


<!-- MARKDOWN LINKS & IMAGES -->
[shield:prestige]: https://img.shields.io/badge/Prestige-yellow?style=flat

<!-- MOD LINKS -->
[mod:ordinator]: <https://www.nexusmods.com/skyrimspecialedition/mods/1137> "Ordinator"
[mod:w3ee]: <https://www.nexusmods.com/witcher3/mods/3522> "W3EE"
[mod:sve]: <https://www.nexusmods.com/stardewvalley/mods/3753> "Stardew Valley Expanded"
[mod:spacecore]: <https://www.nexusmods.com/stardewvalley/mods/1348> "SpaceCore"
[mod:luck]: <https://www.nexusmods.com/stardewvalley/mods/521> "Luck Skill"
[mod:cooking]: <https://www.nexusmods.com/stardewvalley/mods/522> "Cooking Skill"
[mod:magic]: <https://www.nexusmods.com/stardewvalley/mods/2007> "Magic"
[mod:loc]: <https://www.nexusmods.com/stardewvalley/mods/6830> "Love Of Cooking"
[mod:binning]: <https://www.nexusmods.com/stardewvalley/mods/14073> "Binning Skill"
[mod:socializing]: <https://www.nexusmods.com/stardewvalley/mods/14142> "Socializing Skill"
[mod:automate]: <https://www.nexusmods.com/stardewvalley/mods/1063> "Automate"
[mod:pfm]: <https://www.nexusmods.com/stardewvalley/mods/4970> "Producer Framework Mod"
[mod:pfm-automate]: <https://www.nexusmods.com/stardewvalley/mods/5038> "PFM Automate"
[mod:artisan-valley]: <https://www.nexusmods.com/stardewvalley/mods/1926> "Artisan Valley"
[mod:fresh-meat]: <https://www.nexusmods.com/stardewvalley/mods/1721> "Fresh Meat"
[mod:soda-makers]: <https://www.nexusmods.com/stardewvalley/mods/5173> "Artisanal Soda Makers"
[mod:fizzy-drinks]: <https://www.nexusmods.com/stardewvalley/mods/5342> "Fizzy Drinks"
[mod:frozen-treats]: <https://www.nexusmods.com/stardewvalley/mods/5388> "Shaved Ice & Frozen Treats"
[mod:new-mayo]: <https://www.nexusmods.com/stardewvalley/mods/7660> "Ostrich Mayo & Golden Mayo"
[mod:qap]: <https://www.moddrop.com/stardew-valley/mods/707502-quality-artisan-products> "Quality Artisan Products"
[mod:qap-va]: <https://www.moddrop.com/stardew-valley/mods/726947-quality-artisan-products-for-artisan-valley> "Quality Artisan Products for Artisan Valley"
[mod:flower-meads]: <https://www.nexusmods.com/stardewvalley/mods/5767> "Flower Meads"
[mod:husbandry]: <https://www.nexusmods.com/stardewvalley/mods/1538> "Animal Husbandry Mod"
[mod:better-junimos]: <https://www.nexusmods.com/stardewvalley/mods/2221> "Better Junimos"
[mod:mushroom-propagator]: <https://www.nexusmods.com/stardewvalley/mods/4637> "Mushroom Propagator"
[mod:con]: <https://www.nexusmods.com/stardewvalley/mods/5966> "Custom Ore Nodes"
[mod:tfo]: <https://www.nexusmods.com/stardewvalley/mods/866/> "Teh's Fishing Overhaul"
[mod:forage-pointers]: <https://www.nexusmods.com/stardewvalley/mods/7781> "Forage Pointers"
[mod:myc]: <https://www.nexusmods.com/stardewvalley/mods/6069> "Multi Yield Crops"
[mod:mushroom-boxes]: <https://www.nexusmods.com/stardewvalley/mods/10296> "Craftable Mushroom Boxes"
[mod:better-beehouses]: <https://www.nexusmods.com/stardewvalley/mods/10996> "Better Beehouses"
[mod:better-crab-pots]: <https://www.nexusmods.com/stardewvalley/mods/3159> "Better Crab Pots"
[mod:crab-pot-loot]: <https://www.nexusmods.com/stardewvalley/mods/7767> "Crab Pot Loot Has Quality And Bait Effects"
[mod:forage-fantasy]: <https://www.nexusmods.com/stardewvalley/mods/7554> "Forage Fantasy"
[mod:better-slingshots]: <https://www.nexusmods.com/stardewvalley/mods/2067> "Better Slingshots"
[mod:ring-overhaul]: <https://www.nexusmods.com/stardewvalley/mods/10669> "Ring Overhaul"
[mod:slime-produce]: <https://www.nexusmods.com/stardewvalley/mods/7634> "Slime Produce"
[mod:capstone]: <https://www.nexusmods.com/stardewvalley/mods/7636> "Capstone Professions"
[mod:all-professions]: <https://www.nexusmods.com/stardewvalley/mods/174> "All Professions"
[mod:prestige]: <https://www.nexusmods.com/stardewvalley/mods/569> "Skill Prestige"
[mod:icons-redone]: <https://www.nexusmods.com/stardewvalley/mods/4163> "Profession Icons Redone"
[mod:vintage-ui]: <https://www.nexusmods.com/stardewvalley/mods/4697> "Vintage Interface"
[mod:cjb-cheats]: <https://www.nexusmods.com/stardewvalley/mods/4> "CJB Cheats Menu"
[mod:tap-giant-crops]: <https://www.nexusmods.com/stardewvalley/mods/13052> "Tap Giant Crops"
[mod:skill-training]: <https://www.nexusmods.com/stardewvalley/mods/14452> "Skill Training"
[mod:yahwsm]: <https://www.nexusmods.com/stardewvalley/mods/2731> "Yet Another Harvest With Scythe Mod"
[mod:archery]: <https://www.nexusmods.com/stardewvalley/mods/16767> "Archery"

<!-- USER LINKS -->
[user:enai]: <https://www.nexusmods.com/skyrimspecialedition/users/3959191> "Enai Siaion"
[user:reaperanon]: <https://www.nexusmods.com/witcher3/users/54536917> "ReaperAnon"
[user:illogicalmoodswing]: <https://www.nexusmods.com/stardewvalley/users/38784845> "IllogicalMoodSwing"

<!-- OTHER LINKS -->
[url:league]: <https://www.leagueoflegends.com/> "League Of Legends"
[url:diablo]: <https://diablo2.blizzard.com/> "Diablo II"
[url:ragnarok]: <https://ro.gnjoy.com/index.asp> "Ragnarok Online"
[wiki:fishponddata]: <https://stardewvalleywiki.com/Modding:Fish_Pond_data> "Fish Pond Data"
[wiki:integrations-api]: <https://stardewvalleywiki.com/Modding:Modder_Guide/APIs/Integrations> "APIs - Integrations"

[🔼 Back to top](#margo--professions-profs)