using System.Collections.Generic;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Talent
{
    public static class TalentDb
    {
        public static readonly TalentDefinition AllOutAttack =
            new TalentDefinition(
                Talents.AllOutAttack,
                "All Out Attack",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30),
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 30)
                },
                @"Full Round Action

Make a number of Challenging [+0] attacks equal to your MSK Bonus for Melee attacks and RSK Bonus for ranged attacks against up to that many targets or the same target multiple times. The targets may react to any of your attacks like normal."
            );

        public static readonly TalentDefinition ArcaneScatter =
            new TalentDefinition(
                Talents.ArcaneScatter,
                "Arcane Scatter",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(2),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40)
                },
                @"Double your spell range. Touch remains Touch, but both Self and Touch extend to one additional target you have physical contact with.

You may take this talent up to two times (these bonuses stack)."
            );

        public static readonly TalentDefinition Archmage =
            new TalentDefinition(
                Talents.Archmage,
                "Archmage",
                3,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(5),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 50),
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 50)
                },
                @"Your opponents take an additional -10 on tests made vs your spells."
            );

        public static readonly TalentDefinition AssassinStrike =
            new TalentDefinition(
                Talents.AssassinStrike,
                "Assassin Strike",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 40),
                    TalentPrerequisiteDb.Skill(Skills.Athletics, SkillRank.Proficient)
                },
                @"The character’s natural agility and graceful martial forms turn him into a dervish of death on the battlefield. After making a melee attack, a successful Challenging [+0] Athletics Skill Test, or Challenging [+0] Fly Skill test if they have the ability to fly, allows the character to move at half rate as a Free Action. The character’s opponent does not receive a free attack resulting from this move. The character may only make this move once per round."
            );

        public static readonly TalentDefinition BalefulDirge =
            new TalentDefinition(
                Talents.BalefulDirge,
                "Baleful Dirge",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Skill(Skills.Intimidate, SkillRank.Trained)
                },
                @"The character can sing an unnatural droning dirge which makes the skin of those nearby crawl and their minds shy away from its discordant notes. Singing the dirge takes some concentration and requires a Half Action each round to maintain. All creatures which can hear the character within a 30 yd radius must make a Challenging [+0] WPR Test or suffer a –10 penalty on their next roll. As long as the dirge is maintained, all those affected by it must test each turn to see if they suffer its effects. Once a creature passes a WPR Test however, it has completely overcome the dirge and is not affected by it for the remainder of the encounter."
            );

        public static readonly TalentDefinition BerserkCharge =
            new TalentDefinition(
                Talents.BerserkCharge,
                "Berserk Charge",
                1,
                true,
                new List<TalentPrerequisite>(),
                @"If the character uses the Charge Action, he gains a +30 bonus to Melee Skill instead of +20."
            );

        public static readonly TalentDefinition Blademaster =
            new TalentDefinition(
                Talents.Blademaster,
                "Blademaster",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 45),
                    TalentPrerequisiteDb.WeaponProficiency("Blades")
                },
                @"The character’s mastery of bladed weapons has no peer. When attacking with any weapon from the Blades group, the character may reroll one missed attack per round."
            );

        public static readonly TalentDefinition BlindFighting =
            new TalentDefinition(
                Talents.BlindFighting,
                "Blind Fighting",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.PER, 30)
                },
                @"Years of practice and development of other senses allows the character to fight in close combat without the benefit of sight. This talent reduces all penalties for fighting with a melee weapon while suffering from obscured vision by half (rounded up), permitting the character to fight in fog, smoke or darkness more effectively. Note: this talent only improves a character’s chance to hit with melee weapons and has no effect on ranged weapon attacks."
            );

        public static readonly TalentDefinition Bully =
            new TalentDefinition(
                Talents.Bully,
                "Bully",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Skill(Skills.Intimidate, SkillRank.Trained)
                },
                @"You are used to ganging up on the weak, throwing cruel insults and demoralizing them. Whenever you have two times as many allies or more as your opponent you gain +10 on Intimidate tests against them, and whenever you have three times or more than them you gain +20 instead."
            );

        public static readonly TalentDefinition Catfall =
            new TalentDefinition(
                Talents.Catfall,
                "Catfall",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 35)
                },
                @"You automatically reduce the distance of all falls by a number of yards equal to your AGI bonus, ignoring this distance as if it did not exist in regards to fall damage. In addition you add +20 to your Athletics Skill Tests when using the Jump Special Skill Use as it pertains to reducing Damage from falling."
            );

        public static readonly TalentDefinition CombatMaster =
            new TalentDefinition(
                Talents.CombatMaster,
                "Combat Master",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 40)
                },
                @"Your weapon seems to be everywhere at once, keeping many more opponents at bay in close combat than would seem possible. Opponents fighting you in melee combat gain no bonuses for Ganging Up."
            );

        public static readonly TalentDefinition CombatReflexes =
            new TalentDefinition(
                Talents.CombatReflexes,
                "Combat Reflexes",
                3,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 40)
                },
                @"You gain a number of additional reactions each round equal to your 1/2 AGI Bonus (minimum 1), and may stand up as a Free Action if prone or knocked down.

Note: You may not use these additional reactions to reroll a single test more than once with Features such as Jack of All Trades."
            );

        public static readonly TalentDefinition CombatSense =
            new TalentDefinition(
                Talents.CombatSense,
                "Combat Sense",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.PER, 40)
                },
                @"You have the ability to consciously recognize the prodding of your subconscious as it reacts to your preternaturally sharp senses, giving you an edge that mere speed cannot match. You may use your Perception Bonus in place of your Agility Bonus when rolling Initiative."
            );

        public static readonly TalentDefinition Counterattack =
            new TalentDefinition(
                Talents.Counterattack,
                "Counterattack",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 40),
                    TalentPrerequisiteDb.Talent(Talents.CombatReflexes),
                    TalentPrerequisiteDb.Skill(Skills.Parry, SkillRank.Trained)
                },
                @"As part of your successful parry reaction, you may spend a reaction to make an Attack of Opportunity against that opponent."
            );

        public static readonly TalentDefinition Crackshot =
            new TalentDefinition(
                Talents.Crackshot,
                "Crackshot",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 40)
                },
                @"You can place your shots where they inflict more harm, such as creases, gaps, or joints in armor. When making an attack with a ranged weapon, you deal an additional ½ RSK Bonus damage upon a successful hit."
            );

        public static readonly TalentDefinition CrushingBlow =
            new TalentDefinition(
                Talents.CrushingBlow,
                "Crushing Blow",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 40)
                },
                @"You add half your MSK Bonus to Damage you inflict in melee."
            );

        public static readonly TalentDefinition CunningInitiative =
            new TalentDefinition(
                Talents.CunningInitiative,
                "Cunning Initiative",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 30)
                },
                @"You roll for initiative tests an additional time and take the best result."
            );

        public static readonly TalentDefinition Diehard =
            new TalentDefinition(
                Talents.Diehard,
                "Diehard",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.CON, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 30)
                },
                @"In order to take Excessive Damage, you must lose wounds equal to 3x your CON bonus instead of the normal amount."
            );

        public static readonly TalentDefinition Endurance =
            new TalentDefinition(
                Talents.Endurance,
                "Endurance",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.CON, 30),
                    TalentPrerequisiteDb.Skill(Skills.Athletics, SkillRank.Trained)
                },
                @"Whenever failing a test would give you a level of fatigue, gain +10 on that test. You may rest in your armor without incurring penalties."
            );

        public static readonly TalentDefinition FuriousAssault =
            new TalentDefinition(
                Talents.FuriousAssault,
                "Furious Assault",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 45),
                    TalentPrerequisiteDb.Talent(Talents.AllOutAttack)
                },
                @"Your speed and martial prowess allow you to land several blows where lesser combatants land one. If you successfully hit your target using the All Out Attack Action, you may spend a Reaction to make an additional attack using the same bonuses or penalties as the original attack."
            );

        public static readonly TalentDefinition HammerBlow =
            new TalentDefinition(
                Talents.HammerBlow,
                "Hammer Blow",
                3,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Talent(Talents.AllOutAttack),
                    TalentPrerequisiteDb.Talent(Talents.CrushingBlow)
                },
                @"Whenever you make an All Out Attack maneuver to make a single melee attack, you add STR Bonus / 2 to damage. The attack also counts as having the Concussive (2) Special Quality to represent the shocking force of the blow’s impact."
            );

        public static readonly TalentDefinition HardTarget =
            new TalentDefinition(
                Talents.HardTarget,
                "Hard Target",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 40)
                },
                @"When you perform a Charge or Run action, opponents suffer a –20 penalty to RSK Tests made to hit you with a ranged weapon. This penalty continues until the start of your next turn."
            );

        public static readonly TalentDefinition Haste =
            new TalentDefinition(
                Talents.Haste,
                "Haste",
                1,
                true,
                new List<TalentPrerequisite>(),
                @"Gain +3 on Initiative rolls."
            );

        public static readonly TalentDefinition HighImpact =
            new TalentDefinition(
                Talents.HighImpact,
                "High Impact",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(4),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40)
                },
                @"When your level is a factor for damage in spells, increase it by 2.

This talent may be taken up to 5 times."
            );

        public static readonly TalentDefinition ImprovedCombatManeuver =
            new TalentDefinition(
                Talents.ImprovedCombatManeuver,
                "Improved Combat Maneuver",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 30)
                },
                @"You gain a +20 bonus on tests when attempting or being targeted by one of the following maneuvers: Bullrush, Disarm, Feint, Grapple, Overrun, Retreat, Sunder, Trip.

This talent may be taken multiple times, each time you select a new maneuver."
            );

        public static readonly TalentDefinition IronJaw =
            new TalentDefinition(
                Talents.IronJaw,
                "Iron Jaw",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.CON, 40)
                },
                @"Whenever you become stunned, if you pass a Difficult [-10] CON test you may ignore the effects."
            );

        public static readonly TalentDefinition Leadership =
            new TalentDefinition(
                Talents.Leadership,
                "Leadership",
                3,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 35),
                    TalentPrerequisiteDb.Stat(Characteristics.CHA, 35),
                    TalentPrerequisiteDb.Skill(Skills.Command, SkillRank.Proficient)
                },
                @"Any NPC companions that are provided by a Feature or Talent gain an additional 250xp each time you level. You gain a +10 bonus on all CHA tests targeting your followers."
            );

        public static readonly TalentDefinition LightningAttack =
            new TalentDefinition(
                Talents.LightningAttack,
                "Lightning Attack",
                3,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Talent(Talents.SwiftAttack)
                },
                @"Your speed with weapons is legendary, allowing you to launch flurries of attacks in melee. You may make the Lightning Attack Combat Action."
            );

        public static readonly TalentDefinition LightSleeper =
            new TalentDefinition(
                Talents.LightSleeper,
                "Light Sleeper",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.PER, 40)
                },
                @"The slightest change in conditions or a simple disturbance brings you from sleep to full awareness, remaining alert even in slumber. You are always assumed to be awake, even when asleep, for the purposes of Awareness Tests or surprise. Unfortunately, your sleep is not deep and can be frequently interrupted, resulting in a less-than cheery disposition when awake."
            );

        public static readonly TalentDefinition MagicProficiency =
            new TalentDefinition(
                Talents.MagicProficiency,
                "Magic Proficiency (X)",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 30),
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 20)
                },
                @"Add X to your lvl when using it as a factor for features or spells. Whenever you take this talent, increase your MP by 1 to a maximum of 10."
            );

        public static readonly TalentDefinition Marksman =
            new TalentDefinition(
                Talents.Marksman,
                "Marksman",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 35)
                },
                @"Distance is no protection against your marksmanship and you suffer no penalties for RSK tests at long or extended range."
            );

        public static readonly TalentDefinition Meditation =
            new TalentDefinition(
                Talents.Meditation,
                "Meditation",
                1,
                false,
                new List<TalentPrerequisite>(),
                @"You have mastered this body and its reactions by the practice of meditative techniques, shutting down unnecessary functions that enable you to refresh both body and mind. For every ten minutes you spend calmly reflecting without interruption removes one Level of Fatigue."
            );

        public static readonly TalentDefinition Paranoia =
            new TalentDefinition(
                Talents.Paranoia,
                "Paranoia",
                1,
                false,
                new List<TalentPrerequisite>(),
                @"You know that danger lurks behind every corner and know the world hits you with everything it has as soon as you let his guard down. You gain a +2 bonus on Initiative rolls, and the GM may secretly test using your Perception to notice hidden threats. The price of this eternal vigilance is a twitchy disposition and the inability to relax."
            );

        public static readonly TalentDefinition Permanency =
            new TalentDefinition(
                Talents.Permanency,
                "Permanency",
                3,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(5),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 35),
                    TalentPrerequisiteDb.Skill(Skills.Arcana, SkillRank.Adept)
                },
                @"You can imbue an object with the effects of a spell that would otherwise end, such as a sword with Elemental Blast to grant it additional fire damage, or a stone with Light to make it continuously glow.

Example:
Illusion (Minor or Greater)
Cast an illusion, such as making a cave entrance look like stone covered in vines and moss. It remains until it is dismissed by you, or dispelled by another. Whenever a person perceives your illusion for the first time, or if they would interact with it in a way that could disprove it, such as passing through it, it acts as if you had just cast it."
            );

        public static readonly TalentDefinition Polyglot =
            new TalentDefinition(
                Talents.Polyglot,
                "Polyglot",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.CHA, 30)
                },
                @"You have an innate ability to derive meaning from unknown languages, and can make yourself understood using this intuitive grasp. The character can make untrained Skill Tests with the Linguistics Skill for languages they do not know. Being a Polyglot is not the same as having a true knowledge of a language, and characters must succeed a Linguistics Skill Test (along with the –20 modifier for being untrained) to have more than the most basic conversations or exchanges of ideas."
            );

        public static readonly TalentDefinition PowerAttack =
            new TalentDefinition(
                Talents.PowerAttack,
                "Power Attack",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30),
                    TalentPrerequisiteDb.Stat(Characteristics.STR, 30)
                },
                @"You may take a -10 penalty on a melee attack and deal an additional 3 damage if you succeed."
            );

        public static readonly TalentDefinition PowerAttackGreater =
            new TalentDefinition(
                Talents.PowerAttackGreater,
                "Power Attack, Greater",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.STR, 40),
                    TalentPrerequisiteDb.Talent(Talents.PowerAttack)
                },
                @"You may take a -20 penalty on a melee attack and deal an additional 6 damage if you succeed."
            );

        public static readonly TalentDefinition PreternaturalSpeed =
            new TalentDefinition(
                Talents.PreternaturalSpeed,
                "Preternatural Speed",
                3,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 50)
                },
                @"The character is a swift moving bringer of death; a living, bloody scythe before whom foes fall like wheat before the reaper. When making a Charge Move the character doubles his normal charge movement."
            );

        public static readonly TalentDefinition QuickDraw =
            new TalentDefinition(
                Talents.QuickDraw,
                "Quick Draw",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 30)
                },
                @"Draw a weapon as a Swift Action."
            );

        public static readonly TalentDefinition RapidReload =
            new TalentDefinition(
                Talents.RapidReload,
                "Rapid Reload",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 35),
                    TalentPrerequisiteDb.WeaponProficiency("Bows")
                },
                @"Reduce the time it takes to reload crossbows, or ranged armaments such as Ballista, by one step (Full to Half, Half to Swift, Swift to Free)."
            );

        public static readonly TalentDefinition Riposte =
            new TalentDefinition(
                Talents.Riposte,
                "Riposte",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 45),
                    TalentPrerequisiteDb.Talent(Talents.Counterattack),
                    TalentPrerequisiteDb.Skill(Skills.Parry, SkillRank.Proficient)
                },
                @"As part of or in place of a counterattack, you maneuver your foe off balance, and may disarm them (if possible). They cannot take any more actions and are Caught Off Guard until their next turn."
            );

        public static readonly TalentDefinition SkillFocus =
            new TalentDefinition(
                Talents.SkillFocus,
                "Skill Focus",
                1,
                false,
                new List<TalentPrerequisite>(),
                @"Choose a skill you are proficient in. Gain a +5 bonus to tests of the chosen skill. This talent may be taken multiple times, once per each skill."
            );

        public static readonly TalentDefinition SkillFocusGreater =
            new TalentDefinition(
                Talents.SkillFocusGreater,
                "Skill Focus, Greater",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Talent(Talents.SkillFocus)
                },
                @"Gain a +10 bonus instead of tests of the chosen skill (replacing the +5 bonus from Skill Focus), and add 1 additional DoS when you pass. This talent may be taken multiple times, once per each qualified skill."
            );

        public static readonly TalentDefinition SpellFocus =
            new TalentDefinition(
                Talents.SpellFocus,
                "Spell Focus",
                1,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(2),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40),
                    TalentPrerequisiteDb.Skill(Skills.Arcana, SkillRank.Proficient)
                },
                @"Choose a school of magic. Gain +10 on all tests you make spells of that school."
            );

        public static readonly TalentDefinition SpellFocusGreater =
            new TalentDefinition(
                Talents.SpellFocusGreater,
                "Spell Focus, Greater",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(4),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 45),
                    TalentPrerequisiteDb.Talent(Talents.SpellFocus),
                    TalentPrerequisiteDb.Skill(Skills.Arcana, SkillRank.Proficient)
                },
                @"Whenever a target makes a test for a spell of the chosen school, including reaction tests to avoid it, you may have them take an additional +10 or -10 on that test.

For example, with spells that apply to an area or multiple targets, you may designate that all allies gain +10 while all opponents receive -10 on tests they make as part of the effects of this spell."
            );

        public static readonly TalentDefinition Spellshot =
            new TalentDefinition(
                Talents.Spellshot,
                "Spellshot",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(1),
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 40)
                },
                @"Spellshot allows a character with an aptitude for the arcane to enhance their ranged weapons. As a free action, once per round, the character may make a Challenging [+0] WPR Test to increase their ranged weapons damage by DoS until the end of their next turn."
            );

        public static readonly TalentDefinition SpellPierce =
            new TalentDefinition(
                Talents.SpellPierce,
                "Spell Pierce",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.MP(3),
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40)
                },
                @"Opponents you target with your spells take an additional -10 penalty on any CON and WPR tests they make as part of your spells."
            );

        public static readonly TalentDefinition StreetFighting =
            new TalentDefinition(
                Talents.StreetFighting,
                "Street Fighting",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30)
                },
                @"The character is adept at close and dirty fighting, favoring small weapons or even his bare hands to take down his foes. When armed with a dagger, knife, similar small weapon, or simply with his bare hands, he adds 1/2 MSK Bonus to any Damage he inflicts."
            );

        public static readonly TalentDefinition Subdue =
            new TalentDefinition(
                Talents.Subdue,
                "Subdue",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30)
                },
                @"You receive +20 on MSK tests to Knockout an opponent."
            );

        public static readonly TalentDefinition SwiftAttackMelee =
            new TalentDefinition(
                Talents.SwiftAttack,
                "Swift Attack, Melee",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 30)
                },
                @"The character’s speed with melee weapons is legendary, allowing him to launch flurries of attacks in melee as a Full Action, except with weapons that have the Unwieldy trait. When a character uses this ability to make a melee attack, he scores one hit per DoS, with each hit counting as a separate attack for all intents and purposes."
            );

        public static readonly TalentDefinition SwiftAttackRanged =
            new TalentDefinition(
                Talents.SwiftAttack,
                "Swift Attack, Ranged",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 30)
                },
                @"The character’s speed with ranged weapons is legendary, allowing him to launch flurries of attacks in melee as a Full Action, except with weapons that have the Reload trait. When a character uses this ability to make a ranged attack, he scores one hit per DoS, with each hit counting as a separate attack for all intents and purposes."
            );

        public static readonly TalentDefinition Takedown =
            new TalentDefinition(
                Talents.Takedown,
                "Takedown",
                1,
                true,
                new List<TalentPrerequisite>(),
                @"As a Half Action or when making a Charge Attack the character may declare that he is attempting a takedown against an opponent in melee combat. He then rolls to hit (using his MSK) as normal; using any modifiers for weapons and talents (or the +20 bonus from Charging). If the character hits and would have done at least one point of Damage (after reduction for Armor and CON Bonus) it is ignored, but the character’s opponent must make a Challenging [+0] CON Test or be stunned for 1 round and knocked prone. In addition, when performing a Stun Action, the character does not suffer a –20 penalty to his MSK."
            );

        public static readonly TalentDefinition Tenacity =
            new TalentDefinition(
                Talents.Tenacity,
                "Tenacity",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 35),
                    TalentPrerequisiteDb.Stat(Characteristics.CON, 35),
                    TalentPrerequisiteDb.Stat(Characteristics.WPR, 35)
                },
                @"Gain a +20 to WPR tests to resist spell effects and intimidation, a +20 bonus to AGI tests against traps or terrain, and a +20 bonus to CON tests to resist poisons, toxins, and environmental effects."
            );

        public static readonly TalentDefinition Toughness =
            new TalentDefinition(
                Talents.Toughness,
                "Toughness",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.CON, 30)
                },
                @"Gain +5 CON, and then gain wounds equal to your CON Bonus."
            );

        public static readonly TalentDefinition UnarmedMaster =
            new TalentDefinition(
                Talents.UnarmedMaster,
                "Unarmed Master",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 45),
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 40),
                    TalentPrerequisiteDb.Talent(Talents.UnarmedWarrior)
                },
                @"The Character possesses unparalleled mastery of unarmed combat. He counts as having the Deadly Natural Weapon Trait, and loses Primitive on unarmed and all natural attacks."
            );

        public static readonly TalentDefinition UnarmedWarrior =
            new TalentDefinition(
                Talents.UnarmedWarrior,
                "Unarmed Warrior",
                1,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 35),
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 35)
                },
                @"Due to extensive training in techniques of unarmed combat the character has gained the Natural Weapon Trait improving all his unarmed and natural attacks to 1d10 Primitive (7) and meaning he counts as armed even when facing opponents with weapons while bare handed."
            );

        public static readonly TalentDefinition Vigilance =
            new TalentDefinition(
                Talents.Vigilance,
                "Vigilance",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.AGI, 40),
                    TalentPrerequisiteDb.Stat(Characteristics.PER, 40)
                },
                @"You may act during a surprise round and are not Caught Off Guard."
            );

        public static readonly TalentDefinition WeaponsExpertMelee =
            new TalentDefinition(
                Talents.WeaponsExpertMelee,
                "Weapons Expert, Melee",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.MSK, 50),
                    TalentPrerequisiteDb.WeaponFocus("Melee Group")
                },
                @"When attacking with weapons of the chosen group, they gain Proven [2] if they use 1d5s for damage die and Proven [4] if they use 1d10s. You may take this talent up to twice for each weapon group, and the second time you choose the same group, increase the benefits to Proven [3] if they use 1d5s for their damage die, and Proven [6] if they use 1d10s instead."
            );

        public static readonly TalentDefinition WeaponsExpertRanged =
            new TalentDefinition(
                Talents.WeaponsExpertRanged,
                "Weapons Expert, Ranged",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.RSK, 50),
                    TalentPrerequisiteDb.WeaponFocus("Ranged Group")
                },
                @"When attacking with weapons of the chosen group, they gain Proven [2] if they use 1d5s for damage die and Proven [4] if they use 1d10s. You may take this talent up to twice for each weapon group, and the second time you choose the same group, increase the benefits to Proven [3] if they use 1d5s for their damage die, and Proven [6] if they use 1d10s instead."
            );

        public static readonly TalentDefinition WeaponFocus =
            new TalentDefinition(
                Talents.WeaponFocus,
                "Weapon Focus",
                2,
                true,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.WeaponProficiency("Chosen Group")
                },
                @"Gain +5 on MSK or RSK tests with the chosen weapon, and deal an additional 2 damage with it.

This talent may be taken multiple times, each time choosing to stack the same weapon group (max twice per weapon group), or choose another one."
            );

        public static readonly TalentDefinition WeaponProficiency =
            new TalentDefinition(
                Talents.WeaponProficiency,
                "Weapon Proficiency",
                1,
                true,
                new List<TalentPrerequisite>(),
                @"Gain proficiency with one of the following weapon types: Axes, Bows, Hammers, Crossbows, Blades, Close, Polearms, Siege Weapons, Shields, Spears. This talent may be taken multiple times, choosing a new weapon type each time."
            );

        public static readonly TalentDefinition WorldlyKnowledge =
            new TalentDefinition(
                Talents.WorldlyKnowledge,
                "Worldly Knowledge",
                2,
                false,
                new List<TalentPrerequisite>
                {
                    TalentPrerequisiteDb.Stat(Characteristics.INT, 40)
                },
                @"Reduce the penalty for any untrained Knowledge tests from -20 to -10. If you have the Bardic Knowledge feature, instead you take no penalty on untrained Knowledge tests and gain +10 on all knowledge tests."
            );

        public static readonly TalentDefinition Minion =
            new TalentDefinition(
                Talents.Minion,
                "Minion",
                2,
                false,
                new List<TalentPrerequisite>
                {
                },
                @"Minion"
            );

        public static readonly TalentDefinition DeadeyeShot =
            new TalentDefinition(
                Talents.DeadeyeShot,
                "DeadeyeShot",
                2,
                true,
                new List<TalentPrerequisite>
                {
                },
                @"DeadeyeShot"
            );

        public static readonly TalentDefinition SureStrike =
            new TalentDefinition(
                Talents.SureStrike,
                "SureStrike",
                2,
                true,
                new List<TalentPrerequisite>
                {
                },
                @"SureStrike"
            );

        public static TalentDefinition Get(Enums.Talents talent)
        {
            return talent switch
            {
                Enums.Talents.SkillFocus => SkillFocus,
                Enums.Talents.CombatSense => CombatSense,
                Enums.Talents.Haste => Haste,
                Enums.Talents.UnarmedMaster => UnarmedMaster,
                Enums.Talents.UnarmedWarrior => UnarmedWarrior,
                Enums.Talents.Polyglot => Polyglot,
                Enums.Talents.LightSleeper => LightSleeper,
                Enums.Talents.ImprovedCombatManeuver => ImprovedCombatManeuver,
                Enums.Talents.Meditation => Meditation,
                Enums.Talents.Diehard => Diehard,

                _ => throw new ArgumentOutOfRangeException(nameof(talent), talent, null)
            };
        }
    }
}