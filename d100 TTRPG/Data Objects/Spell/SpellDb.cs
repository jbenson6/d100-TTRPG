using System.Collections.Generic;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Spell
{
    public static class SpellDb
    {
        public static readonly Dictionary<Enums.Spells, SpellDefinition> Spells =
            new Dictionary<Enums.Spells, SpellDefinition>
            {
                // ============================================================
                // ABJURATION
                // ============================================================

                [Enums.Spells.Dispel] = new SpellDefinition
                {
                    Spell = Enums.Spells.Dispel,
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = -10,
                    Description = "Remove someone, or something, from a Seal, the effects of an enchantment spell, remove an illusion, or the enchantment of an object with a successful Difficult [-10] INT test vs the original spellcaster’s casting test (GM Discretion). You may cast this spell with intent to suppress magic instead of removing it, with the following modifiers and their associated suppression times:\n\n- Challenging [+0] INT test: 1 rd/DoS\n- Difficult [-10] INT test: 1 min/DoS\n- Hard [-20] INT test: 1 hr/DoS\n\n*Note: Some enchantments are powerful and impose a penalty on tests to remove their magic*"
                },

                [Enums.Spells.ElementalResistance] = new SpellDefinition
                {
                    Spell = Enums.Spells.ElementalResistance,
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30,
                    Description = "Make an Easy [+30] INT Test. You or a touched target gain Resist (X) of a chosen elemental type, where X is your casting test DoS. This lasts 5 min per lvl."
                },

                [Enums.Spells.GlyphOfWarding] = new SpellDefinition
                {
                    Spell = Enums.Spells.GlyphOfWarding,
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test you place a nearly invisible magical trap with a diameter of 1 yd on a surface, such as on the ground, a section of wall, the page of a book, or the lid of a jar. When you cast the spell you decide how the glyph is triggered, such as a stepping on the ground, opening the book, and may also decide what doesn’t trigger the glyph, such as speaking a password, or a certain race touching the glyph. A potential target of this spell makes a Difficult [-10] Spellcraft test to recognize the glyph, otherwise doesn’t take action against it. When the glyph is triggered, they take [1d10 + ½ MP] per lvl/3 (Min 1d10 + ½ MP), Pen MP.\n\nWith MP 5 or higher, you may store another spell inside of the glyph that targets whomever triggers it instead of the damage. You must pass the test to cast that spell after passing the test to cast this one, and decide any details for the effects of that spell. E.g. You select Elemental Blast, and choose to deal Fire damage, or you choose Greater Polymorph and the target is transformed into a frog upon triggering this spell."
                },

                [Enums.Spells.Shield] = new SpellDefinition
                {
                    Spell = Enums.Spells.Shield,
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 30,
                    Description = "As a reaction, you make an Easy [+30] INT test and gain AP equal to your MP + DoS for 1 rd. You gain 1 LoF."
                },

                [Enums.Spells.Seal] = new SpellDefinition
                {
                    Spell = Enums.Spells.Seal,
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 6,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -20,
                    Description = "A two part spell:\n\n1. With a successful Hard [-20] Craft Test, you create a Vessel -- an enchanted item with power to hold a single soul, creature, or object (size MP or smaller) with the second half of this spell. This process takes four hours, but may be done any number of times provided you have the materials to craft the desired Vessel.\n2. While remaining in contact with a Vessel, you\n   1. A vessel containing something cannot be sundered, or destroyed through regular means through mundane means."
                },

                // ============================================================
                // CONJURATION
                // ============================================================

                [Enums.Spells.AnimateWeapon] = new SpellDefinition
                {
                    Spell = Enums.Spells.AnimateWeapon,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 30,
                    Description = "With a successful Easy [+30] INT test, you charge a weapon within spell range with magical energy (or Elementary [+50] INT test if you’re already wielding it), and effectively wield it from afar. If another person is wielding the chosen weapon, they make an opposed Easy [+30] STR test to counter the effects of this spell. If they fail, it functions as normal. You may perform normal attacks and parry with the weapon (if able) as if you were wielding it, except you use your INT in place of MSK or RSK and MP in place of STR bonus for calculating damage rolls. This spell lasts for 1 minute per lvl. If the weapon moves outside the spell range or is destroyed, this spell ends and the weapon succumbs to natural forces.\n\nYou may recall the weapon to you as a move action or as part of a move action, or may move the weapon lvl yds."
                },

                [Enums.Spells.ArcaneBind] = new SpellDefinition
                {
                    Spell = Enums.Spells.ArcaneBind,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "You summon a lengthy enchanted rope that wraps around and constrains a target with a size equal to or below your MP, and with a successful opposed Standard [+10] INT test vs their Challenging [+0] Escape Artist. When a person is bound this way, they fall prone, and are Helpless for 1 rd per lvl before the binds vanish. They may attempt a Difficult [-10] Escape Artist test once each round to release themselves from the effects of this spell."
                },

                [Enums.Spells.ArcaneGate] = new SpellDefinition
                {
                    Spell = Enums.Spells.ArcaneGate,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 500,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 45,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "You create linked teleportation portals that remain open for the duration. Choose two points on the ground that you can see, one point within 3 yds of you and one point within 15 yds x lvl of you. A circular portal, 3 yds in diameter, opens over each point. If the portal would open in the space occupied by a creature, the spell fails, and the casting is lost.\n\nThe portals are two-dimensional glowing rings filled with mist, hovering inches from the ground and perpendicular to it at the points you choose. A ring is visible only from one side (your choice), which is the side that functions as a portal.\n\nAny creature or object entering the portal exits from the other portal as if the two were adjacent to each other; passing through a portal from the nonportal side has no effect. The mist that fills each portal is opaque and blocks vision through it. On your turn, you can rotate the rings as a bonus action so that the active side faces in a different direction. Gain 2 LoF."
                },

                [Enums.Spells.MistyStep] = new SpellDefinition
                {
                    Spell = Enums.Spells.MistyStep,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = -10,
                    Description = "With a successful Difficult [-10] INT test, you teleport yourself up to 1 yd per lvl away in an unoccupied space within range and LoS (whichever is closer) as swift action. Gain 1 LoF unless you passed your INT test with 2 or more DoS."
                },

                [Enums.Spells.CreateWater] = new SpellDefinition
                {
                    Spell = Enums.Spells.CreateWater,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "You summon 1 gallon of distilled, mineralized, or seawater water per lvl, either dropping from a spot of your choice, filling any chosen containers within range and LoS, or have it pour steadily at freefall from a chosen spot within range for the rest of the round. At MP 5 you summon 5 gallons per level instead."
                },

                [Enums.Spells.EtherealChest] = new SpellDefinition
                {
                    Spell = Enums.Spells.EtherealChest,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test you create a pocket in the ethereal plane and may store up to lvl/2 [min 1] cubic yards worth of material inside, which lasts a number of days equal to your MP. When the spell ends, the items simply fall on the ground somewhere within arms reach of you. Storing and retrieving items from this pocket is a Half Action and may be done at will. A living creature placed inside may attempt a Challenging [+0] Escape test to exit the pocket once per round. While inside they can breathe, but will starve if left in there too long."
                },

                [Enums.Spells.Grease] = new SpellDefinition
                {
                    Spell = Enums.Spells.Grease,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a Standard [+10] INT test, you cover an area with a radius up to your lvl yd in a thin layer of slick, flammable grease. Creatures that move in the greased area must pass a Challenging [+0] AGI test or fall prone, and must pass the test again to stand or slip and fall again. Any prone creature may move with a speed of 1. If the grease is ignited, it deals 1d10 damage per round, for 1d5-2 rds (min 1)."
                },

                [Enums.Spells.Light] = new SpellDefinition
                {
                    Spell = Enums.Spells.Light,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "An item you touch or target within range illuminates 10 yds as daylight for 1 hr/lvl."
                },

                [Enums.Spells.MageHand] = new SpellDefinition
                {
                    Spell = Enums.Spells.MageHand,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30,
                    Description = "You may manipulate an object weighing up to 10 lbs per level, or apply 10 lbs of force per level to an object, with a successful Easy [+30] INT test. You may move an affected object up to 10 yds as a half-action within spell range.\n\nAt MP 4, you can instead create an invisible, mindless, shapeless, force that performs simple tasks at your command until the spell ends. The servant comes into existence in an unoccupied space on the ground within range. It is size [4], has 1 Wound and STR 20. If it is dealt damage the spell ends. Once on each of your turns as a bonus action, you can mentally command it to move up to 15 ft and interact with objects, and perform basic actions that a humanoid servant could do. Once you give the command, the servant performs the task to the best of its ability until it completes the task, then waits for the next command. If you command the servant to move outside of spell range, the spell ends."
                },

                [Enums.Spells.PungentOdor] = new SpellDefinition
                {
                    Spell = Enums.Spells.PungentOdor,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "Fill a (10 + INT Bonus) yd diameter with the smell of Sulphur, sun-baked carrion, sewage, or any other overly foul smell with a Challenging [+0] INT test opposed by any other living being's Hard [-20] CON test in the chosen sphere for 2 + 1 rds x lvl. They cough and gag, and those who fail are Staggered for as long as they remain in the target area.\n\nAt MP 4, those who fail their CON test also take 1d5 CON damage."
                },

                [Enums.Spells.RuinousFog] = new SpellDefinition
                {
                    Spell = Enums.Spells.RuinousFog,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a successful Standard [+10] INT test, the air swirls and forms a thick fog within the target radius of 3 yd x lvl. Visibility is reduced to 1 yd within the fog, and each creature caught inside takes 1d5 plus INT Bonus damage each round unless they pass a Challenging [+0] CON test at the beginning of their turn. The fog persists for DoS + 4 rounds.\n\nAt MP 6, the fog takes up a radius of 5 yd x lvl, deals 1d10 + INT Bonus damage each round, and each creature must pass a Difficult [-10] CON test instead."
                },

                [Enums.Spells.SummonArmor] = new SpellDefinition
                {
                    Spell = Enums.Spells.SummonArmor,
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30,
                    Description = "Instantly summon and equip a set of magical armor you are proficient with with an Easy [+30] INT Test, that lasts for 2 rds + 1 rd per lvl."
                },

                // ============================================================
                // DIVINATION
                // ============================================================

                [Enums.Spells.Fateseal] = new SpellDefinition
                {
                    Spell = Enums.Spells.Fateseal,
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test, you may alter the result of the roll of your target’s next test by 5 per DoS, unless they pass an opposed Challenging [+0] WPR test (if unwilling). At MP 6 your casting test becomes a Standard [+10] INT test, and MP 8 an unwilling target’s test becomes a Difficult [-10] INT test."
                },

                [Enums.Spells.Track] = new SpellDefinition
                {
                    Spell = Enums.Spells.Track,
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 150,
                    TestChar = Characteristics.PER,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "Gain +10 x MP on all Survival tests for the next minute per level. While this spell is active, whenever you succeed a Survival test to track, the trail of your target illuminates in a glowing hue of your choice (GM descriptions: footsteps, handprints, branches they broke, blood on the ground, etc)."
                },

                [Enums.Spells.MemoryDelve] = new SpellDefinition
                {
                    Spell = Enums.Spells.MemoryDelve,
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -20,
                    Description = "With a successful Hard [-20] INT test vs their Challenging [+0] WPR test (if unwilling), you are able to search through the thoughts and memories of an individual for up to 1 min per lvl. You are able to find memories by asking questions or by searching keywords and concepts [GM Discretion], and understand them as they do. You receive a +10 bonus to your INT test if the subject is Stunned, and a +20 instead if they are unconscious or cooperative.\n\nExample: While peering into the mind of a child who witnessed the regicide of the late highness, you ask “Who killed the king?” and get a series of images of a middle-aged man dressed in fine robes and jewelry stabbing the king, but also walking around the castle, and another of him enjoying the court garden. While the child did not know the name, you recognize him to be the king’s younger brother, who is fourth in line for the throne."
                },

                // ============================================================
                // ENCHANTMENT
                // ============================================================

                [Enums.Spells.CharmPerson] = new SpellDefinition
                {
                    Spell = Enums.Spells.CharmPerson,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20,
                    Description = "With a successful Routine [+20] INT test vs up to CHA Bonus targets’ opposed WPR tests, you gain their faith and confidence as though they were an old friend. Gain +10 x DoS on Command, Deceive, and Persuade tests against them for 1 hr x lvl. If your targets succeed their opposed WPR tests, they gain +10 the next time you target them with this spell for the next 24 hours. Gain 1 LoF."
                },

                [Enums.Spells.Despair] = new SpellDefinition
                {
                    Spell = Enums.Spells.Despair,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "You may target up to MP sentient creatures, and with a successful Challenging [+0] INT test vs each target’s Difficult [-10] WPR test, they gain 1 Degree of Fear (DoF), then one Level of Fatigue for each Degree of Fear they have.\n\nAt MP 5, your casting test becomes a Standard [+10] INT test, and each target that fails their WPR test gains 2 DoF instead."
                },

                [Enums.Spells.Goad] = new SpellDefinition
                {
                    Spell = Enums.Spells.Goad,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "You taunt a foe with a magical gesture or display. Make a Routine [+20] INT test against your target’s Challenging [+0] WPR test. If you succeed, your target is Antagonized towards you for 1 round per level. Gain 1 LoF unless you pass a Challenging [+0] WPR test."
                },

                [Enums.Spells.InstillFear] = new SpellDefinition
                {
                    Spell = Enums.Spells.InstillFear,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "With a successful Ordinary [+20] INT, you generate feelings of unease, worry, and dread inside a column with a sphere with a radius of 2 yd per level. All creatures caught within the column must pass a Challenging [+0] WPR test or gain 1 Degree of Fear."
                },

                [Enums.Spells.Obliviate] = new SpellDefinition
                {
                    Spell = Enums.Spells.Obliviate,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "Make a Challenging [+0] INT Test opposed by the target's Difficult [-10] WPR Test. If you pass, you wipe your existence from their memory and perception for 5 rds/lvl. They cannot perceive you nor your actions, only the consequences of your actions. They cannot be convinced that you or your actions exist, unless you attack them directly or they are swayed by an ally with a Hard [-20] CHA or Persuade Test."
                },

                [Enums.Spells.Stupor] = new SpellDefinition
                {
                    Spell = Enums.Spells.Stupor,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "Make an opposed Standard [+10] INT against 1/2 lvl (Min 1) targets vs their [Challenging +0] WPR test. Each target who fails lays themselves down and falls into a deep slumber for 1 minute per lvl. They can be roused by an ally with a full action, and count as Surprised on their next turn."
                },

                [Enums.Spells.TurnFoe] = new SpellDefinition
                {
                    Spell = Enums.Spells.TurnFoe,
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With magical influence, you convince your foe that their allies are their foes, and that you are their ally instead with a successful opposed Challenging [+0] INT test vs their Challenging [+0] WPR test.\n\nINT vs opposed WPR. They fight for you instead for 1 rd x lvl.\n\nWith great power, you trick your target into fighting on your behalf with a successful Challenging [+0] INT test vs your target’s Challenging [+0] WPR test. For ½ lvl rds (min 1) your target treats you as an ally and its former allies as their opponents. Your target may be convinced to return to normal with a successful Hard [-20] Persuade Test as a full action."
                },

                // ============================================================
                // EVOCATION
                // ============================================================

                [Enums.Spells.CallLightning] = new SpellDefinition
                {
                    Spell = Enums.Spells.CallLightning,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "Make a Challenging [+0] INT test. If you pass, thunderclouds form 100 yd above a target or area, and bring down bolts of lightning upon each creature within a radius of 1 yd x lvl. Each creature that does not pass a Challenging [+0] Dodge test takes 1d10 + MP, Pen INTB, and must pass a Challenging [+0] CON test or fall prone and become paralyzed for 1 rd. Gain 1 LoF. Creatures beneath Cover are unaffected."
                },

                [Enums.Spells.ElementalBarrier] = new SpellDefinition
                {
                    Spell = Enums.Spells.ElementalBarrier,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 350,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 30,
                    Description = "With a successful Easy [+30] INT test, you create a six inch thick wall out of an element of your choosing. It’s up to 2 yd x lvl tall and wide, stops mundane projectiles up to size (3), and lasts for 1 rd per lvl.\n\nIf your MP is 5 or greater, the thickness of the barrier is 12 inches, and can stop projectiles up to size (4) instead. Gain 1 LoF."
                },

                [Enums.Spells.ElementalBlast] = new SpellDefinition
                {
                    Spell = Enums.Spells.ElementalBlast,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "Make a Standard [+10] INT Test. If you pass, you fire a line, cone, or sphere of an elemental damage type, such as Acid, Cold, Electricity, Fire with a point of origin within the spell range. Your range for line is 4 yd per lvl, cone is 90° wide and 2 yd long per lvl, sphere of radius 1 yd per lvl. It deals 1d10 + lvl/2 (Min 1), Pen INT Bonus, Proven [MP] to each creature caught in its path. Creatures may dodge this as they would a regular attack. Gain 1 LoF unless you pass a Challenging [+0] WPR test."
                },

                [Enums.Spells.ElementalSphere] = new SpellDefinition
                {
                    Spell = Enums.Spells.ElementalSphere,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 10,
                    Description = "Make a Standard [+10] INT Test. If you pass, create a sphere of a chosen element in the target area, which deals (MP/2; min 1)d10 + DoS in damage, with a radius up to 1 yard per level (Min 1). This spell lasts one round, but can be extended by another round with a Half Action, and can be moved a distance equal to your base speed in yards with a move action. Gain 1 LoF unless you pass a Challenging [+0] WP test."
                },

                [Enums.Spells.FeyFire] = new SpellDefinition
                {
                    Spell = Enums.Spells.FeyFire,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 20,
                    Description = "Make a Routine [+20] INT Test. If you pass, you create of burst light fills an area equal to 1 yd * INT Bonus, and all creatures that fail a [Challenging +0] WP Test are outlined in a faint glow. They gain -20 to Stealth tests, and remove any and all benefits from invisibility."
                },

                [Enums.Spells.Immolation] = new SpellDefinition
                {
                    Spell = Enums.Spells.Immolation,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 10,
                    Description = "With a successful Standard [+10] INT test you set an opponent within range on fire. They take 1d10 + MP fire damage (not reduced by worn armor) each round until they fall prone and pass a Difficult [-10] Ag test by rolling around, or fully submerging themselves in a substance such as water or snow for a full round. Gain 1 LoF unless you pass a Challenging [+0] WPR test."
                },

                [Enums.Spells.KineticBombardment] = new SpellDefinition
                {
                    Spell = Enums.Spells.KineticBombardment,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 500,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10,
                    Description = "With a Difficult [-10] INT Test, you summon a ring of spinning lights 100 yds above a horizontal target area, illuminating it in any bright color of your choosing, in a circle lattice pattern with a radius of up to 1 yd/lvl. At the beginning of your next turn you may spend a Half-Action to move the target area up to INT Bonus yds away from your original target area, then the spinning lights launch a barrage of stone rods that strike every target within the circle for 1d10 + MP, Pen INT Bonus unless they pass an opposed Difficult [-10] Dodge test. At MP 8 the damage increases to 2d10 + MP, and an opposed Hard [-20] Dodge test. Gain 2 LoF unless you pass a Hard [-20] WP test."
                },

                [Enums.Spells.SonicBoom] = new SpellDefinition
                {
                    Spell = Enums.Spells.SonicBoom,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test you create a spherical sonic explosion with a radius of 2 yd x lvl, dealing 1d10 + MP, Pen MP to every creature and object caught within it. Those behind Partial cover take half damage, and those being Cover take none."
                },

                [Enums.Spells.Radiance] = new SpellDefinition
                {
                    Spell = Enums.Spells.Radiance,
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a successful Standard [+10] INT test you create a brilliant light anywhere you touch or within arms reach of your body. Creatures within 5 yds x lvl must pass a Challenging [+0] Dodge test or become blinded for MP rounds."
                },

                // ============================================================
                // ILLUSION
                // ============================================================

                [Enums.Spells.DoubleImage] = new SpellDefinition
                {
                    Spell = Enums.Spells.DoubleImage,
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test, you create a visual clone of yourself, or your target. The clone behaves in the same manner as the original, attacking, defending, retreating, and any other action that the original takes, except it is immaterial and deals no damage and cannot be dealt damage. This grants the target of your spell a 50% to not be hit or properly targeted by others. This spell lasts 1 rd per level, and can be disbelieved with a successful Difficult [-10] WPR test, or a Hard [-20] Insight test."
                },

                [Enums.Spells.Invisibility] = new SpellDefinition
                {
                    Spell = Enums.Spells.Invisibility,
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "You, or a touched target, become invisible to the naked eye. Light passes through you, though you and any allies affected by this casting, can still perceive yourselves and each other. Each round you must pass a [Standard +10] INT Test at the beginning of your turn or the illusion disappears.\n\nThis spell ends when an affected creature attacks, casts a spell, or otherwise interacts with another creature (except allies also under the effect of this spell).\n\nYou may select yourself and up to any number of touched targets equal to Magic / 2 (Min 1). It lasts 1 minute per lvl.\n\nIf your MP is 5 or higher,"
                },

                [Enums.Spells.IllusionMinor] = new SpellDefinition
                {
                    Spell = Enums.Spells.IllusionMinor,
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a small gesture, you make an opposed [Standard +10] INT Test versus a target creature's Difficult [-10] Insight Test (or WPR if they don't have that skill trained). If you succeed, they believe whatever visual image you have conjured in their minds for the next 10 min per lvl. If they are attacked, they make another [Difficult -10] Insight Test, washing away the effects of your spell on them if they pass.\n\nChoose a desired effect:\n\nDistraction (Challenging [+0] Opposed Per test)\n\nFear (Challenging [+0] Opposed WP Test)\n\nAt MP 5 you can trick any or all of the targeted creature’s senses, and it lasts for 1 hour per level."
                },

                [Enums.Spells.IllusionMass] = new SpellDefinition
                {
                    Spell = Enums.Spells.IllusionMass,
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "Functions as Greater Illusion, except you may target 1 creature per lvl. Additionally, your illusions may harm them in whatever fantasy you have convinced the targets of. If a large flame would devour them, they would take 1d5 Fire dmg per lvl/2 (min 1d5). If in a rush of thorny vines and bushes filled the forests and surrounded them, they would take 1d5 slashing dmg per lvl/2 (min 1d5), and so on. Anytime an affected creature witnesses another one die, they must make a [Hard -20] Fear Test (WP test w/mods), and take double damage from your illusion if they fail. That multiplier stacks each time they fail."
                },

                // ============================================================
                // NECROMANCY
                // ============================================================

                [Enums.Spells.Curse] = new SpellDefinition
                {
                    Spell = Enums.Spells.Curse,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 6,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10,
                    Description = "With a successful Difficult [-10] INT test vs your target’s Difficult [-10] WPR test, your bestow a cruel affliction upon them (GM discretion) that lasts until you dismiss the magic, they satisfy a condition you give them, or they have it removed through powerful restoration magic:\n\n- Bane: Choose a physical damage type (B, P, S), an elemental type (Acid, Cold, Electricity, Fire, Sonic, etc) or a characteristic. Whenever the target takes damage of the chosen type they take twice that much damage instead (before reductions from features, armor, and CON bonus are applied).\n- Debilitation: The target gains the Blinded, Deafened, or Sickened condition.\n- Frailty: The target takes 2d10 CON damage and reduces their max wounds by 2, and can’t recover CON through natural or magical means. They gain a Level of Fatigue, and cannot remove their last Level of Fatigue when resting, or through features, talents, or magical means.\n- Lame: The target loses functionality in one of their arms, legs, tail or wings. They take a -10 penalty to Agility, -10 penalty to Athletics, and reduce their max wounds by 2.\n- Weakness: The target takes 2d10 STR damage, halves their STR Bonus when applying it to damage rolls with melee weapons, and can’t recover STR through natural or magical means."
                },

                [Enums.Spells.Enervation] = new SpellDefinition
                {
                    Spell = Enums.Spells.Enervation,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test vs the target’s Challenging [+0] reaction test, you attach a black tentacle onto them that connects to you, dealing 1d5 per lvl/2 (min 1d5, max 4d5) + MP. You recover wounds equal to half the damage dealt this way, and at the beginning of your turn you may choose to spend a Full Action to deal them 1d5 per lvl/2 (min 1d5, max 4d5) + MP and recover wonders equal to half the damage deal this way. This spell lasts up to DoS rds, the target dies, or gets behind cover."
                },

                [Enums.Spells.Hex] = new SpellDefinition
                {
                    Spell = Enums.Spells.Hex,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test vs your target’s Challenging [+0] WPR test, you strike them with an illness, defect, flaw or pain of your choice (GM discretion) that causes one of the following effects for 1 minute per lvl:\n\n- The target suffers a -10 penalty to a given characteristic of your choice.\n- The target gains the Sickened condition.\n- The target gains one Level of Fear\n- The target’s physical features warp in a minor fashion (GM Discretion), such their nose becoming crooked and changing the pitch of their voice, acne, rash, or warts covering portions of their skin that itches or stings, small chunks of hair begin to fall out, excessive hair begins to grow in unusual places.\n\nThese effects can overlap but will not stack. At MP 4, 6, 8 and 10 you may choose an additional target (totalling 5 at MP 10), and at MP 6 you may instead target any number of individuals in a radius equal to ½ yds per lvl as a Full Action."
                },

                [Enums.Spells.LifeTransfer] = new SpellDefinition
                {
                    Spell = Enums.Spells.LifeTransfer,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "With a successful Routine [+20] INT test, you give a target wounded ally some of your life. You take up to 1d10 + INT Bonus damage, not reduced by armor, CON Bonus, features, or any other abilities or effects, and your target recovers that many wounds, then you gain 1 LoF."
                },

                [Enums.Spells.RaiseDead] = new SpellDefinition
                {
                    Spell = Enums.Spells.RaiseDead,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 350,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10,
                    Description = "With your foul powers you reanimate a corpse to rise and do your bidding if you succeed a [Difficult -10] INT Test. It resembles the stage of its rot, either as a zombie, skeleton, or whatever stage between. It has wounds equal to your lvl + INT Bonus, and a Bite (1d10, Pen 0, Primitive [7], Toxic [1]), and Slam (1d10+1, Pen 0, Primitive [8]). It remains your servant until its wounds are exhausted, you dismiss it, and lasts up to 1 min per lvl. If it has been destroyed, it catches a dark purple flame and quickly burns to ashes. If not, it may be raised again with another casting of this spell.\n\nCreate Undead in the bestiary. This spell creates it, wounds change between spellcaster"
                },

                [Enums.Spells.RendFlesh] = new SpellDefinition
                {
                    Spell = Enums.Spells.RendFlesh,
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = -10,
                    Description = "With a successful Difficult [-10] INT test versus your opponent’s Challenging [+0] CON test, your opponent’s flesh tears and disforms, dealing 1d5 wounds per degree of failure and 2d10 CON damage. Any other opponents that witness the gruesome effects of this spell must pass a Difficult [-10] WPR test or gain 1 Level of Fear. Gain 1 LoF. At MP 8 if your opponent would perish from the loss of wounds or CON damage, their form is completely sundered, and reshaped into a grotesque mass of flesh."
                },

                // ============================================================
                // RESTORATION
                // ============================================================

                [Enums.Spells.Cure] = new SpellDefinition
                {
                    Spell = Enums.Spells.Cure,
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20,
                    Description = "You partition your deity for guidance, and remove all ailments, toxins, and ills from a person's flesh with a successful Routine [+20] Medicine Test. Gain 1 LoF unless you succeed at a [Challenging +0] WPR Test."
                },

                [Enums.Spells.Heal] = new SpellDefinition
                {
                    Spell = Enums.Spells.Heal,
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20,
                    Description = "Through divine authority and with a successful Routine [+20] INT test you erase the injuries from yourself or another creature for 1d10 per three levels (minimum 1d10) + INT Bonus Wounds. Make a Challenging [+0] CON Test, and gain 1 LoF if you fail."
                },

                [Enums.Spells.Regenerate] = new SpellDefinition
                {
                    Spell = Enums.Spells.Regenerate,
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a successful Standard [+10] INT test you or your target gain Regenerate [DoS] for INT Bonus rds, then you gain 1 LoF."
                },

                // ============================================================
                // TRANSMUTATION
                // ============================================================

                [Enums.Spells.Boost] = new SpellDefinition
                {
                    Spell = Enums.Spells.Boost,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "Based on your MP, you may make a given INT test, you or the person touched gain a temporary bonus to a characteristic of your choice if you pass:\n\n- MP 1 or higher: Routine [+20] INT test, gain a +10 to any one characteristic.\n- MP 4 or higher: Challenging [+0] INT test, gain a +20 to any one characteristic.\n- MP 8 or higher: Hard [-20] INT test, gain a +30 to any one characteristic.\n\nWith a successful INT test, you gain the associated bonus of the characteristic of your choice for 1 minute per DoS. The characteristic bonus from this spell does not stack with this spell or other spells."
                },

                [Enums.Spells.Crush] = new SpellDefinition
                {
                    Spell = Enums.Spells.Crush,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "You greatly increase the pressure upon all things within a target radius and height of 2 yd per lvl with a Standard [+10] INT Test. All creatures within the target area, and any who enter it, must pass a Challenging [+0] STR Test or be fall prone and be unable to move more than 1 yd per rd, and cannot make any reactions for 1 rd per DoS. Gain 1 LoF.\n\nIf your MP is 5 or greater, all creatures within the target area must pass a Hard [-20] STR test instead, and any creature that fails by 2 or more degrees gains 1 LoF and takes 5 points of Con damage each round. These effects last for 3 rounds, or 1 rd per lvl/2, whichever is greater. Gain 1 LoF."
                },

                [Enums.Spells.Expedite] = new SpellDefinition
                {
                    Spell = Enums.Spells.Expedite,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "Make a [Standard +10] INT test. Choose up to 1 target per lvl/2 (Min 1). If you pass, each target doubles their movement speeds, gains an extra Half Action or Reaction each round, and gains +10 to Attacks and Reactions for MP rds. Gain 1 LoF."
                },

                [Enums.Spells.FeatherFall] = new SpellDefinition
                {
                    Spell = Enums.Spells.FeatherFall,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 20,
                    Description = "As a reaction, you make a Routine [+20] INT test, and you (optional), along with up to 1 target per lvl fall at a static rate of 6 yd per round, for up to 1 min per lvl, and take no damage from falling upon impact."
                },

                [Enums.Spells.Fly] = new SpellDefinition
                {
                    Spell = Enums.Spells.Fly,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "With a successful Ordinary [+20] INT test, you gain a Fly speed equal to your MP for 1 minute per lvl, and may make Fly skill tests as though you were trained if you’re not."
                },

                [Enums.Spells.Jump] = new SpellDefinition
                {
                    Spell = Enums.Spells.Jump,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "Gain +20 to Acrobatics tests to jump, and you may travel up triple the distance based on your result. This lasts 1 rd per lvl."
                },

                [Enums.Spells.Longstrider] = new SpellDefinition
                {
                    Spell = Enums.Spells.Longstrider,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "Triple all your movement speeds for 1 min per lvl.\n\nYou may cast this spell as a Swift Action with a successful [Ordinary +0] INT Test."
                },

                [Enums.Spells.Polymorph] = new SpellDefinition
                {
                    Spell = Enums.Spells.Polymorph,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "Err\n\nAt MP 6,"
                },

                [Enums.Spells.Prestidigitation] = new SpellDefinition
                {
                    Spell = Enums.Spells.Prestidigitation,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0,
                    Description = "You may alter the physical properties of inorganic matter or dead materials (such as cotton, hides, food, etc) in minor ways, such as drying, dampening, or cleaning clothing, turning up to a one square yd of rough dirt into smooth ground, or changing the flavor of beer in a mug to taste excessively salty or the texture slimy (GM discretion)."
                },

                [Enums.Spells.RapidGrowth] = new SpellDefinition
                {
                    Spell = Enums.Spells.RapidGrowth,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 30,
                    Description = "You touch a plant or fungus and with a successful Easy [+30] INT test cause it to grow and mature exceptionally quickly. It grows into a young mature version of its species, or becomes more youthful if it was already mature, and bears ripe produce if natural for it."
                },

                [Enums.Spells.Rust] = new SpellDefinition
                {
                    Spell = Enums.Spells.Rust,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10,
                    Description = "With a Standard [+10] INT test, you cause a piece of armor, a single weapon, or a 5 ft sq piece of metal to rust (incorrigible metals are immune to this) as a half action. It receives the Broken condition, and requires a Hard [-20] Craft [Chosen Item] test to repair over the course of an hour."
                },

                [Enums.Spells.ShapeStone] = new SpellDefinition
                {
                    Spell = Enums.Spells.ShapeStone,
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20,
                    Description = "With a successful Routine [+20] INT test, you carve out up to 1 cubic yd per level of stone, either reducing it to rubble, cutting it into blocks, or into a sculpture of your choice with an Easy [+30] Craft [Stone] test."
                },

                // ============================================================
                // UNIVERSAL
                // ============================================================

                [Enums.Spells.CircleOfTheMagi] = new SpellDefinition
                {
                    Spell = Enums.Spells.CircleOfTheMagi,
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0,
                    Description = "With a successful Challenging [+0] INT test, you create a circle centered around you or within range that extends 5 yd + 1 yd per lvl, that lasts 5 rds + 1 rd per level. While in the circle, you may make up to one additional Half Action on your turn, up to one additional Reaction each round, and +10 to MSK, RSK, and AGI tests (these bonuses do not stack with other spell bonuses). Any opponent within the circle or that enters the circle must pass a Difficult [-10] WPR test or they may only make a single half action on their turn and up to one reaction each round, and receive a -10 penalty to MSK, RSK and AGI tests (if they are under the effects of Expedite, they are negated while inside this circle after failing their test).\n\nIf your MP is 6 or greater, you may grant the benefits of this spell to up to one ally per 4 lvls."
                },

                [Enums.Spells.Tongues] = new SpellDefinition
                {
                    Spell = Enums.Spells.Tongues,
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 10,
                    Description = "With a successful Standard [+10] INT test you are able to understand the spoken words of other sapient creatures and your words become understandable to them as if you were raised speaking their language for 1 min per lvl. At MP 4 you may target an area of people with this spell equal to your INT bonus in yds centered on yourself and lasts 10 min per level. At MP 8 the effects last for 1 hr per level."
                },

                [Enums.Spells.Wish] = new SpellDefinition
                {
                    Spell = Enums.Spells.Wish,
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 750,
                    TestChar = Characteristics.INT,
                    MPReq = 10,
                    INTReq = 50,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10,
                    Description = "You wield magic as a demigod would, and can do any of the following with a successful [Difficult -10] INT Test:\n\n- Duplicate any other spell, and gain +30 to any tests you would make while casting it.\n- Dispel any spell, effect, or remove any injury or affliction, on up to one target per lvl / 2.\n- Revive the dead (intact bodies only).\n- Teleport up to ten creatures from any plane ([Difficult -10] Opposed WPR) to any other plane.\n\nGain 2 LoF.\n\nYou may only cast wish once per session (failed attempts do not count)."
                }
            };
    }
}