using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Skill
{
    public static class SkillDb
    {
        public static readonly SkillDefinition Athletics = new SkillDefinition(
            Enums.Skills.Athletics,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.STR
            },
            true,
            "Ability to move oneself across long distances, jump, swim, climb, and perform other physically taxing actions. " +
            "For jumping, a character moves up to 1 yd horizontally, or 1 ft vertically, for every increment of 5 they succeed their test by. " +
            "If they have a running start of at least 5 yd, they gain +10 on their test to jump. " +
            "Also covers the ability to balance, maintain footing on uneven terrain, avoid slipping, and perform complex physical maneuvers."
        );

        public static readonly SkillDefinition Awareness = new SkillDefinition(
            Enums.Skills.Awareness,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.PER
            },
            false,
            "The ability to perceive your surroundings."
        );

        public static readonly SkillDefinition Command = new SkillDefinition(
            Enums.Skills.Command,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            false,
            "Direct subordinates, compel allies, or otherwise convince those on your side to obey you despite any present circumstances."
        );

        public static readonly SkillDefinition Craft = new SkillDefinition(
            Enums.Skills.Craft,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.INT
            },
            false,
            "Through knowledge, intuition, and skill, you create an item within a specialized crafting category. See Crafting in Additional Rules for details.",
            new List<ISkillSubDefinition>
            {
            new SkillSubDefinition<Craft>(
                Enums.Craft.Alchemy
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.ArmsAndArmor
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.BonesAndHides
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.BowsAndArrows
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.Glass
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.Metal
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.Traps
            ),

            new SkillSubDefinition<Craft>(
                Enums.Craft.Wood
            )
            }
        );

        public static readonly SkillDefinition Deceive = new SkillDefinition(
            Enums.Skills.Deceive,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            false,
            "Convince others of lies, falsehoods, and create disguises."
        );

        public static readonly SkillDefinition Dodge = new SkillDefinition(
            Enums.Skills.Dodge,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.AGI
            },
            true,
            "Ability to avoid attacks."
        );

        public static readonly SkillDefinition Escape = new SkillDefinition(
            Enums.Skills.Escape,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.STR,
            Enums.Characteristics.AGI
            },
            false,
            "Capacity to remove oneself from bindings, grapples, and tight spaces. The method chosen determines the characteristic used."
        );

        public static readonly SkillDefinition Fly = new SkillDefinition(
            Enums.Skills.Fly,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.AGI
            },
            false,
            "Ability to maneuver in the air, hover, glide, and battle through harsh winds."
        );

        public static readonly SkillDefinition HandleAnimal = new SkillDefinition(
            Enums.Skills.HandleAnimal,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            false,
            "Command, train, or influence the disposition of animals."
        );

        public static readonly SkillDefinition Insight = new SkillDefinition(
            Enums.Skills.Insight,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.PER
            },
            false,
            "You are skilled in detecting falsehoods, illusions, and true intentions."
        );

        public static readonly SkillDefinition Intimidate = new SkillDefinition(
            Enums.Skills.Intimidate,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            true,
            "Ability to scare others into doing what you want, giving you information, or keeping enemies at bay."
        );

        public static readonly SkillDefinition Knowledge = new SkillDefinition(
            Enums.Skills.Knowledge,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.INT
            },
            false,
            "A broad field of specialized knowledge.",
            new List<ISkillSubDefinition>
            {
            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.Arcana,
                "Artifacts, mysteries, arcane symbols, dragons, and magical beasts. Used to identify spells, their effects, and origins. Also allows the detection and perception of magical presences, arcane disturbances, auras, and recently cast spells. Requires a minimum MP of 1."
            ),

            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.Engineering,
                "Architecture, aqueducts, bridges, and fortifications."
            ),

            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.History,
                "Lands, terrain, climate, peoples, wars, colonies, migrations, lineages, heraldry, personalities, and royalty."
            ),

            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.Local,
                "Legends, personalities, inhabitants, laws, customs, and traditions."
            ),

            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.Nature,
                "Animals, fey, monsters, plants, seasonal cycles, weather, and vermin."
            ),

            new SkillSubDefinition<Knowledge>(
                Enums.Knowledge.Religion,
                "Gods and goddesses, mythic history, ecclesiastical tradition, holy symbols, and undead."
            )
            }
        );

        public static readonly SkillDefinition Linguistics = new SkillDefinition(
            Enums.Skills.Linguistics,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.INT
            },
            false,
            "Ability to read, write, and understand each language you are fluent in. " +
            "Also covers the ability to create or forge documents and decipher unknown languages.",
            new List<ISkillSubDefinition>
            {
            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Abyssal
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Celestial
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Djinni
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Draconic
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Elven
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Enkidian
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Infernal
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Ishi
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Kamanali
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Lycan
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Orcish
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Saurian
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Scytho
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Sylvan
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Thessian
            ),

            new SkillSubDefinition<Enums.Languages>(
                Enums.Languages.Taheeli
            )
            }
        );

        public static readonly SkillDefinition Medicine = new SkillDefinition(
            Enums.Skills.Medicine,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.INT
            },
            false,
            "Proficiency with medical tools, herbs, dosages of medicine, and so on. " +
            "Understanding of humanoid bodies, their functions, toxins, and developments."
        );

        public static readonly SkillDefinition Navigate = new SkillDefinition(
            Enums.Skills.Navigate,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.INT
            },
            false,
            "Sea: Course the seas with charts, compasses, and constellations. " +
            "Land: Traverse the lands with maps, landmarks, and terrain."
        );

        public static readonly SkillDefinition Parry = new SkillDefinition(
            Enums.Skills.Parry,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.MSK
            },
            true,
            "Ability to block or deflect a melee attack."
        );

        public static readonly SkillDefinition Perform = new SkillDefinition(
            Enums.Skills.Perform,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            false,
            "Ability to play instruments, sing, dance, and orate. Each instrument or art is taken as a separate skill."
        );

        public static readonly SkillDefinition Persuade = new SkillDefinition(
            Enums.Skills.Persuade,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.CHA
            },
            false,
            "Ability to sway the minds of others through reason, diplomacy, and charm."
        );

        public static readonly SkillDefinition Ride = new SkillDefinition(
            Enums.Skills.Ride,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.AGI
            },
            true,
            "Ability to ride and steer a mount, maintain balance, prevent falling off of and being removed from a mount."
        );

        public static readonly SkillDefinition Stealth = new SkillDefinition(
            Enums.Skills.Stealth,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.AGI
            },
            false,
            "Sneak, move quietly, and otherwise avoid perception."
        );

        public static readonly SkillDefinition Survival = new SkillDefinition(
            Enums.Skills.Survival,
            new List<Enums.Characteristics>
            {
            Enums.Characteristics.PER
            },
            false,
            "Track foes or prey, hunt, fish, forage, find or create shelter, and identify animals."
        );
    }
}
