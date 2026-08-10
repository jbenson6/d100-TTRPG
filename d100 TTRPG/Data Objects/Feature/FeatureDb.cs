using d100_TTRPG.Enums;
using d100_TTRPG.Data_Objects.Skill;
using d100_TTRPG.Data_Objects.Talent;

namespace d100_TTRPG.Data_Objects.Feature
{
    public static class FeatureDb
    {
        // ============================================================
        // HELPERS
        // ============================================================

        private static Skill.Skill S(Enums.Skills skill)
        {
            return new Skill.Skill(SkillDb.Get(skill));
        }

        private static Talent.Talent T(Enums.Talents talent)
        {
            return new Talent.Talent(TalentDb.Get(talent));
        }

        private static Dictionary<Characteristics, int> Req(
            params (Characteristics characteristic, int value)[] requirements)
        {
            return requirements.ToDictionary(
                x => x.characteristic,
                x => x.value);
        }

        private static List<Characteristics> Bonus(
            params Characteristics[] characteristics)
        {
            return new List<Characteristics>(characteristics);
        }

        // ============================================================
        // FEATURES
        // ============================================================

        public static readonly FeatureDefinition AAMastery =
            new FeatureDefinition(
                Features.AAMastery,

                Req(
                    (Characteristics.MSK, 25),
                    (Characteristics.RSK, 25)
                ),

                Bonus(
                    Characteristics.MSK,
                    Characteristics.RSK
                ),

                0,
                7,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Dodge),
                    S(Enums.Skills.Parry)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Heavy,

                "At first, and every additional odd level, pick a weapon group you are proficient with. " +
                "You gain +1 Damage with all weapons of that group (Max +10). " +
                "At 4th level, and every four levels thereafter, reduce the penalty of wearing armor by one step " +
                "(Super Heavy to Heavy, Heavy to Medium, Medium to Light, Light to None).",

                false,
                false
            );

        public static readonly FeatureDefinition BardicKnowledge =
            new FeatureDefinition(
                Features.BardicKnowledge,

                Req((Characteristics.INT, 25)),

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Linguistics)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "You may automatically succeed Knowledge and Linguistic tests with difficulty Challenging [+0] " +
                "or easier with your INT Bonus DoS. At 10th level your knowledge becomes so vast, your ability " +
                "extends to Difficult [-10] or easier tests of those skills.",

                false,
                false
            );

        public static readonly FeatureDefinition BardicePerformance =
            new FeatureDefinition(
                Features.BardicePerformance,

                Req((Characteristics.CHA, 25)),

                Bonus(Characteristics.CHA),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Perform)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.SkillFocus)
                },

                Enums.Armor.Light,

                "With a tune, jig, speech, or other type of display that matches a Challenging [+0] " +
                "Perform [Any] Test as a Half Action, and at level 10 as a Half Action, you may target " +
                "up to one ally per two levels (min 1). Any affected ally gains +10 x DoS to their next " +
                "test (min 1). On a failed test, you must pass a Challenging [+0] Insight test or gain " +
                "a -10 penalty to your next test. These bonuses cannot stack on a single target, but each " +
                "bonus will be used on each following test made by that target.",

                false,
                false
            );

        public static readonly FeatureDefinition Battlemage =
            new FeatureDefinition(
                Features.Battlemage,

                Req((Characteristics.INT, 20)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Awareness),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "Gain +10 on any test you make as part of an opponent's spell " +
                "(including reaction tests to avoid them). At level 10 increases this to +20.",

                false,
                false
            );

        public static readonly FeatureDefinition Channel =
            new FeatureDefinition(
                Features.Channel,

                null,

                Bonus(Characteristics.WPR),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge),
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "As a Half-Action, make a Difficult [-10] INT Test to heal allies (and others if you so desire) " +
                "within 1 yd per lvl for 1d10 + DoS (min 0) wounds, which increases to 2d10 + DoS (min 0) " +
                "at 10th lvl, and to 3d10 + DoS (min 0) at 20th lvl. If you succeed, gain 1 level of fatigue.",

                true,
                true
            );

        public static readonly FeatureDefinition CombatDiscount =
            new FeatureDefinition(
                Features.CombatDiscount,

                Req(
                    (Characteristics.MSK, 20),
                    (Characteristics.RSK, 20)
                ),

                Bonus(
                    Characteristics.MSK,
                    Characteristics.RSK
                ),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Dodge),
                    S(Enums.Skills.Parry),
                    S(Enums.Skills.Intimidate),
                    S(Enums.Skills.Ride)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "You receive 10% XP cost reduction when purchasing combat talents, " +
                "and MSK, RSK, STR, AGI, CON, Athletics, Dodge, Intimidate, Parry and Ride improvements.",

                false,
                false
            );

        public static readonly FeatureDefinition Counterspell =
            new FeatureDefinition(
                Features.Counterspell,

                Req((Characteristics.INT, 30)),

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "As a reaction, you may attempt to dispel the magic of another caster with a Difficult [-10] " +
                "INT test (+10 if you know the same spell) vs target's spell test. If you succeed, their spell " +
                "fizzles and has no effect. At 5th lvl, if you succeed by 4 degrees or more you may cause your " +
                "opponent to succumb to the effects of their own spell.",

                true,
                false
            );

        public static readonly FeatureDefinition DivineRetribution =
            new FeatureDefinition(
                Features.DivineRetribution,

                null,

                Bonus(Characteristics.WPR),

                0,
                7,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Awareness),
                    S(Enums.Skills.Insight),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "You gain one of the following based off of your primary god's domain:\n\n" +
                "Justice (Heavenly): Whenever an opponent deals damage to you, until the end of combat, " +
                "the next time you deal damage to them you are healed for that amount of wounds.\n\n" +
                "Vengeance (Terran): Whenever you or an ally within 10 yd of you is struck by an opponent, " +
                "you gain +10 on your next attack against that opponent this combat. When you successfully " +
                "strike them, add your CHA Bonus to damage and Pen.\n\n" +
                "Sado-Masochism (Hadesian): Whenever you take damage from an opponent, add that much damage " +
                "to your next successful attack this combat against the source of that damage.",

                false,
                true
            );

        public static readonly FeatureDefinition EldritchBlast =
            new FeatureDefinition(
                Features.EldritchBlast,

                Req((Characteristics.INT, 20)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Awareness),
                    S(Enums.Skills.Insight),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "As a full round action, you create and direct a missile at a target within line of sight " +
                "with a Standard [+10] INT test, that deals 1d10 + MP, Pen INT Bonus unless they succeed " +
                "an opposed Challenging [+0] Dodge test to avoid it. At 4th level, and every four levels " +
                "thereafter you gain another missile, which you may direct at the same or any other target within LoS.",

                true,
                false
            );

        public static readonly FeatureDefinition EtherealWeapon =
            new FeatureDefinition(
                Features.EtherealWeapon,

                Req((Characteristics.INT, 25)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Parry)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "Summon a weapon of your choice out of magic as a swift action. Its damage, pen, and other qualities " +
                "mimic that of its mundane counterpart, except it deals an additional + ½ MP damage and loses the " +
                "Primitive trait if it had it. You may summon and maintain up to MP ethereal weapons at a time. " +
                "At 5th level you may summon a weapon as a free action and apply Balanced, Proven [3], or Toxic [0]. " +
                "At 10th level, summoned weapons deal an additional + MP damage and may apply up to two of " +
                "Defensive, Proven [4], or Toxic [1].",

                false,
                false
            );

        public static readonly FeatureDefinition ExcelCasting =
            new FeatureDefinition(
                Features.ExcelCasting,

                null,

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "You may increase your casting ability and spell effects in trade for gaining Fatigue afterwards. " +
                "Minor: At lvl 1 and higher, whenever you cast a spell you may choose to gain a +10 bonus on " +
                "the casting test, and add 5 to your level when determining the spell effects, then gain an additional " +
                "Level of Fatigue afterwards. At lvl 5 and every 10 levels thereafter you may use this ability once " +
                "per combat without gaining a Level of Fatigue. Major: At lvl 10 and higher, gain +20 on the casting " +
                "test, double its distance or duration, and add 10 to your level when determining spell effects, " +
                "then gain 2 additional Levels of Fatigue.",

                true,
                false
            );

        public static readonly FeatureDefinition Explosives =
            new FeatureDefinition(
                Features.Explosives,

                Req((Characteristics.INT, 30)),

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Craft),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "With a Difficult [-10] Craft [Alchemy] Test, you mix reagents into vials, bottles, or other " +
                "sealable containers on your person as a Full Action, creating one bomb per degree of success. " +
                "You may throw your bombs with a Standard [+10] INT test, with a range of your INT Bonus × yd. " +
                "They deal 1d10 + lvl/3 damage, Pen INT Bonus, and Blast (lvl/3, min 0).",

                false,
                false
            );

        public static readonly FeatureDefinition Familiar =
            new FeatureDefinition(
                Features.Familiar,

                null,

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Craft),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "Take on a size 2 or smaller creature as your Arcane Bond, such as a spider, frog, cat, fox, owl, " +
                "pseudodragon, imp, etc. This creature acts as your servant, shares a telepathic link, can speak " +
                "any language you know, and you can cast spells through it. Each time you level your familiar gains 500 XP.",

                false,
                false
            );

        public static readonly FeatureDefinition Grace =
            new FeatureDefinition(
                Features.Grace,

                null,

                Bonus(Characteristics.WPR),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Persuade)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "Whenever you would take damage, reduce it by 1 (min 0). At 3rd level and every third level " +
                "thereafter, reduce it by an additional 1, to a maximum of 10 at 27th level.",

                false,
                true
            );

        public static readonly FeatureDefinition Interrogator =
            new FeatureDefinition(
                Features.Interrogator,

                null,

                Bonus(Characteristics.CHA),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Insight),
                    S(Enums.Skills.Intimidate),
                    S(Enums.Skills.Persuade)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "At 1st, 4th, and every four levels thereafter, gain a cumulative +10 bonus to all " +
                "Insight, Intimidate, and Persuade tests (Max +40).",

                false,
                false
            );

        public static readonly FeatureDefinition JackOfAllTrades =
            new FeatureDefinition(
                Features.JackOfAllTrades,

                null,

                null,

                0,
                3,

                new List<Skill.Skill>(),

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "Each time you level choose a skill you are trained in. Whenever you roll a test of one of " +
                "these skills, you may spend a reaction to re-roll the test with an additional -10 penalty and " +
                "take the results of the second roll. You may choose the same skill a second time, reducing " +
                "the penalty to +0.",

                false,
                false
            );

        public static readonly FeatureDefinition Jester =
            new FeatureDefinition(
                Features.Jester,

                null,

                Bonus(Characteristics.CHA),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Dodge),
                    S(Enums.Skills.Perform)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "Career: You gain one of the following: Carnival, Clown, Court, or Rodeo. " +
                "Each career provides a different ability as described in the feature rules.",

                false,
                false
            );

        public static readonly FeatureDefinition LayOnHands =
            new FeatureDefinition(
                Features.LayOnHands,

                null,

                Bonus(Characteristics.WPR),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Medicine),
                    S(Enums.Skills.Persuade)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Medium,

                "As a half action you reach out to an ally, or target yourself, and heal them for " +
                "1d5 + ½ lvl wounds with a successful Difficult [-10] K [Religion] test. If you succeed " +
                "you gain 1 Level of Fatigue. The amount healed increases by 1d5 at 5th lvl and every 5 levels thereafter.",

                true,
                true
            );

        public static readonly FeatureDefinition MartialArtist =
            new FeatureDefinition(
                Features.MartialArtist,

                null,

                Bonus(Characteristics.MSK),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Awareness),
                    S(Enums.Skills.Dodge)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.UnarmedMaster),
                    T(Enums.Talents.UnarmedWarrior)
                },

                Enums.Armor.Light,

                "Your unarmed strike, and any other natural weapons, increases damage to a minimum of " +
                "[1d10, Pen 0] and you gain the Deadly Natural Weapons trait. At 5th level your natural " +
                "weapons gain Balanced and have the ability to parry. At 10th level, and every 10 levels thereafter, " +
                "increase the damage of your unarmed and natural attacks by 1d10 and Pen by 2, to a maximum of " +
                "[3d10, Pen 4]. When you successfully parry with a natural weapon, you may use a reaction to " +
                "make an unarmed strike against that opponent.",

                false,
                false
            );

        public static readonly FeatureDefinition Mutagens =
            new FeatureDefinition(
                Features.Mutagens,

                Req((Characteristics.INT, 30)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Awareness),
                    S(Enums.Skills.Craft),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "As a half action, you toss back a concoction of pungent materials from within your reach with " +
                "a Challenging [+0] Craft [Alchemy] test, receiving +10 to one characteristic of your choice " +
                "and -10 to another for 2 rounds per level. At 10th level the bonus and penalty double. " +
                "You gain one Level of Fatigue for every two degrees of failure, minimum 1, after the effects wear off.",

                false,
                false
            );

        public static readonly FeatureDefinition NaturesBond =
            new FeatureDefinition(
                Features.NaturesBond,

                null,

                Bonus(Characteristics.PER),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.HandleAnimal),
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Survival)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "An animal of your choice becomes your companion. You gain an empathetic link between each other, " +
                "and each time you level it accrues 500 XP that you may spend on its improvements. At 5th level, " +
                "you may perceive what it does through a chosen sense.",

                false,
                false
            );

        public static readonly FeatureDefinition NaturesWarden =
            new FeatureDefinition(
                Features.NaturesWarden,

                null,

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.HandleAnimal),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "You can communicate with fauna and flora through supernatural means, and use the Handle Animal " +
                "skill in place of Command for such living targets. At 5th level and every 5 levels thereafter " +
                "you gain a cumulative +10 bonus on Handle Animal and K [Nature] tests, to a maximum of +40 at 20th level.",

                false,
                false
            );

        public static readonly FeatureDefinition PerfectForm =
            new FeatureDefinition(
                Features.PerfectForm,

                null,

                Bonus(Characteristics.AGI),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Dodge),
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Stealth)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "You gain +10 bonus on all reaction tests. At 5th level, you add this bonus to all tests " +
                "you make in place of a reaction. At 10th and 20th level you gain one additional reaction each round. " +
                "At 15th level your bonus to reaction tests increases to +20.",

                false,
                false
            );

        public static readonly FeatureDefinition Purify =
            new FeatureDefinition(
                Features.Purify,

                null,

                Bonus(Characteristics.INT),

                1,
                3,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Insight),
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Medicine)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "With a successful Difficult [-10] Medicine test, remove an illness, toxin, or curse from a target " +
                "you touch as a Full Action. If you fail, you may attempt the test again with an additional -10 penalty. " +
                "With a second failure, you may not attempt to Purify the same target for another 24 hours. " +
                "At 5th level, when you pass this Medicine test, you may also heal characteristic damage.",

                true,
                true
            );

        public static readonly FeatureDefinition Rage =
            new FeatureDefinition(
                Features.Rage,

                Req((Characteristics.CON, 25)),

                Bonus(Characteristics.CON),

                0,
                7,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Intimidate)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Heavy,

                "Make a Standard [+10] CON test as a free action up to once per round to begin your Rage. " +
                "For lvl/3 plus DoS rounds you gain +10 STR, +10 CON, +2 temporary wounds, +10 Intimidate, " +
                "and +10 WPR tests vs Intimidate and Fear. At 10th level these bonuses double. While raging, " +
                "you receive a -20 penalty on all INT and CHA tests except Intimidate.",

                false,
                false
            );

        public static readonly FeatureDefinition Scoundrel =
            new FeatureDefinition(
                Features.Scoundrel,

                null,

                Bonus(Characteristics.CHA),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Insight),
                    S(Enums.Skills.Perform)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.Polyglot)
                },

                Enums.Armor.Light,

                "You enjoy mocking and pulling practical jokes on your opponents. " +
                "You may use Perform [Comedy] in place of the standard tests for Feint, Sunder, and Trip.",

                false,
                false
            );

        public static readonly FeatureDefinition Smite =
            new FeatureDefinition(
                Features.Smite,

                null,

                Bonus(Characteristics.CHA),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Command),
                    S(Enums.Skills.Knowledge),
                    S(Enums.Skills.Persuade)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Heavy,

                "As a Swift Action you call upon your god for divine strength with a successful Challenging [+0] " +
                "K [Religion] test. You gain +10 × CHA Bonus to your next attack this combat and deal additional " +
                "+lvl damage if you successfully strike your opponent. Each use this combat applies a cumulative -10 " +
                "penalty on the K [Religion] test. At 5th level you may use this ability once, and every 5 levels " +
                "thereafter an additional time, without taking the penalty.",

                true,
                true
            );

        public static readonly FeatureDefinition SneakAttack =
            new FeatureDefinition(
                Features.SneakAttack,

                null,

                Bonus(Characteristics.AGI),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Deceive),
                    S(Enums.Skills.Stealth)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.LightSleeper)
                },

                Enums.Armor.Light,

                "Deal an additional 1d10 per lvl/3, minimum 1d10 and maximum 6d10, " +
                "to any opponent Caught Off Guard or Helpless.",

                false,
                false
            );

        public static readonly FeatureDefinition Spellbind =
            new FeatureDefinition(
                Features.Spellbind,

                Req((Characteristics.INT, 30)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.Light,

                "With a successful attack with a melee or ranged weapon, you may cast a spell with a " +
                "casting time of Half-Action or shorter by taking an additional -10 penalty on its spell tests, " +
                "with any primary target being the same opponent, opponents, or otherwise directed at them. " +
                "At 10th level you take no penalty on spells cast with this ability.",

                true,
                false
            );

        public static readonly FeatureDefinition Steamroll =
            new FeatureDefinition(
                Features.Steamroll,

                Req(
                    (Characteristics.MSK, 25),
                    (Characteristics.RSK, 25)
                ),

                Bonus(Characteristics.STR),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Parry),
                    S(Enums.Skills.Ride)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.ImprovedCombatManeuver)
                },

                Enums.Armor.Heavy,

                "When you successfully attack an opponent, gain +10 on your next attack this combat. " +
                "At 10th level this increases to +20.",

                false,
                false
            );

        public static readonly FeatureDefinition StillMind =
            new FeatureDefinition(
                Features.StillMind,

                Req(
                    (Characteristics.PER, 25),
                    (Characteristics.WPR, 25)
                ),

                Bonus(Characteristics.WPR),

                0,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Dodge),
                    S(Enums.Skills.Insight)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.Meditation)
                },

                Enums.Armor.Light,

                "You may gain one Level of Fatigue and reroll a reaction test, taking the better result. " +
                "At fifth level the first time you use this ability each combat you do not gain a Level of Fatigue, " +
                "and every five levels thereafter you may use it an additional time without gaining a Level of Fatigue.",

                false,
                false
            );

        public static readonly FeatureDefinition WarBred =
            new FeatureDefinition(
                Features.WarBred,

                Req((Characteristics.CON, 30)),

                Bonus(Characteristics.CON),

                0,
                7,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.Athletics),
                    S(Enums.Skills.Intimidate),
                    S(Enums.Skills.Survival)
                },

                new List<Talent.Talent>
                {
                    T(Enums.Talents.Diehard)
                },

                Enums.Armor.Heavy,

                "Heal naturally at a rate one step higher than normal. At 10th level, whenever you recover " +
                "wounds naturally or through other means, recover twice that amount instead.",

                false,
                false
            );

        public static readonly FeatureDefinition Wildshape =
            new FeatureDefinition(
                Features.Wildshape,

                Req((Characteristics.INT, 25)),

                Bonus(Characteristics.INT),

                1,
                5,

                new List<Skill.Skill>
                {
                    S(Enums.Skills.HandleAnimal),
                    S(Enums.Skills.Knowledge)
                },

                new List<Talent.Talent>(),

                Enums.Armor.None,

                "Transform into a creature of your choice [GM Discretion] as a Half Action up to your size or " +
                "your lvl/2, whichever is higher. You can remain in that shape indefinitely, retain your mental " +
                "characteristic scores, and cast spells. Any injury carries through transformations. If you are " +
                "knocked unconscious or slain, you return to your natural form. At 10th level you transform as a Swift Action instead.",

                true,
                false
            );


        // ============================================================
        // LOOKUP
        // ============================================================

        public static readonly IReadOnlyDictionary<Features, FeatureDefinition> All =
            new Dictionary<Features, FeatureDefinition>
            {
                { Features.AAMastery, AAMastery },
                { Features.BardicKnowledge, BardicKnowledge },
                { Features.BardicePerformance, BardicePerformance },
                { Features.Battlemage, Battlemage },
                { Features.Channel, Channel },
                { Features.CombatDiscount, CombatDiscount },
                { Features.Counterspell, Counterspell },
                { Features.DivineRetribution, DivineRetribution },
                { Features.EldritchBlast, EldritchBlast },
                { Features.EtherealWeapon, EtherealWeapon },
                { Features.ExcelCasting, ExcelCasting },
                { Features.Explosives, Explosives },
                { Features.Familiar, Familiar },
                { Features.Grace, Grace },
                { Features.Interrogator, Interrogator },
                { Features.JackOfAllTrades, JackOfAllTrades },
                { Features.Jester, Jester },
                { Features.LayOnHands, LayOnHands },
                { Features.MartialArtist, MartialArtist },
                { Features.Mutagens, Mutagens },
                { Features.NaturesBond, NaturesBond },
                { Features.NaturesWarden, NaturesWarden },
                { Features.PerfectForm, PerfectForm },
                { Features.Purify, Purify },
                { Features.Rage, Rage },
                { Features.Scoundrel, Scoundrel },
                { Features.Smite, Smite },
                { Features.SneakAttack, SneakAttack },
                { Features.Spellbind, Spellbind },
                { Features.Steamroll, Steamroll },
                { Features.StillMind, StillMind },
                { Features.WarBred, WarBred },
                { Features.Wildshape, Wildshape }
            };

        public static FeatureDefinition Get(Features feature)
        {
            return All[feature];
        }
    }
}