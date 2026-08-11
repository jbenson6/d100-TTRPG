using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Skill
{
    public static class SkillDb
    {
        // ============================================================
        // CORE SKILLS
        // ============================================================

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
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Abyssal),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Celestial),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Djinni),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Draconic),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Elven),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Enkidian),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Infernal),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Ishi),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Kamanali),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Lycan),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Orcish),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Saurian),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Scytho),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Sylvan),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Thessian),
                new SkillSubDefinition<Enums.Languages>(Enums.Languages.Taheeli)
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
            "Ability to navigate through land and sea using maps, charts, landmarks, terrain, compasses, and constellations."
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


        // ============================================================
        // KNOWLEDGE SKILLS
        // ============================================================

        public static readonly SkillDefinition Arcana = new SkillDefinition(
            Enums.Skills.Arcana,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Artifacts, mysteries, arcane symbols, dragons, and magical beasts. " +
            "Used to identify spells, their effects, and origins. " +
            "Also allows the detection and perception of magical presences, arcane disturbances, auras, and recently cast spells. " +
            "Requires a minimum MP of 1."
        );

        public static readonly SkillDefinition Engineering = new SkillDefinition(
            Enums.Skills.Engineering,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Architecture, aqueducts, bridges, and fortifications."
        );

        public static readonly SkillDefinition History = new SkillDefinition(
            Enums.Skills.History,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Lands, terrain, climate, peoples, wars, colonies, migrations, lineages, heraldry, personalities, and royalty."
        );

        public static readonly SkillDefinition Local = new SkillDefinition(
            Enums.Skills.Local,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Legends, personalities, inhabitants, laws, customs, and traditions."
        );

        public static readonly SkillDefinition Nature = new SkillDefinition(
            Enums.Skills.Nature,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Animals, fey, monsters, plants, seasonal cycles, weather, and vermin."
        );

        public static readonly SkillDefinition Religion = new SkillDefinition(
            Enums.Skills.Religion,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Gods and goddesses, mythic history, ecclesiastical tradition, holy symbols, and undead."
        );


        // ============================================================
        // CRAFT SKILLS
        // ============================================================

        public static readonly SkillDefinition Alchemy = new SkillDefinition(
            Enums.Skills.Alchemy,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Create alchemical substances, reagents, and other specialized alchemical items."
        );

        public static readonly SkillDefinition ArmsAndArmor = new SkillDefinition(
            Enums.Skills.ArmsAndArmor,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft weapons, armor, and related equipment."
        );

        public static readonly SkillDefinition BonesAndHides = new SkillDefinition(
            Enums.Skills.BonesAndHides,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft items from bones, hides, leather, and other animal materials."
        );

        public static readonly SkillDefinition BowsAndArrows = new SkillDefinition(
            Enums.Skills.BowsAndArrows,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft bows, arrows, and related ranged equipment."
        );

        public static readonly SkillDefinition Glass = new SkillDefinition(
            Enums.Skills.Glass,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft objects and equipment from glass."
        );

        public static readonly SkillDefinition Metal = new SkillDefinition(
            Enums.Skills.Metal,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft objects, tools, weapons, armor, and equipment from metal."
        );

        public static readonly SkillDefinition Traps = new SkillDefinition(
            Enums.Skills.Traps,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Design, construct, and repair traps and similar mechanical devices."
        );

        public static readonly SkillDefinition Wood = new SkillDefinition(
            Enums.Skills.Wood,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Craft objects, tools, structures, and equipment from wood."
        );


        // ============================================================
        // NAVIGATION SKILLS
        // ============================================================

        public static readonly SkillDefinition Sea = new SkillDefinition(
            Enums.Skills.Sea,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Course the seas using charts, compasses, constellations, currents, and other navigational tools."
        );

        public static readonly SkillDefinition Land = new SkillDefinition(
            Enums.Skills.Land,
            new List<Enums.Characteristics>
            {
                Enums.Characteristics.INT
            },
            false,
            "Navigate across land using maps, landmarks, terrain, and other navigational tools."
        );


        // ============================================================
        // GET
        // ============================================================

        public static SkillDefinition Get(Enums.Skills skill)
        {
            return skill switch
            {
                Enums.Skills.Athletics => Athletics,
                Enums.Skills.Awareness => Awareness,
                Enums.Skills.Command => Command,

                Enums.Skills.Deceive => Deceive,
                Enums.Skills.Dodge => Dodge,
                Enums.Skills.Escape => Escape,
                Enums.Skills.Fly => Fly,
                Enums.Skills.HandleAnimal => HandleAnimal,
                Enums.Skills.Insight => Insight,
                Enums.Skills.Intimidate => Intimidate,

                Enums.Skills.Linguistics => Linguistics,
                Enums.Skills.Medicine => Medicine,
                Enums.Skills.Navigate => Navigate,
                Enums.Skills.Parry => Parry,
                Enums.Skills.Perform => Perform,
                Enums.Skills.Persuade => Persuade,
                Enums.Skills.Ride => Ride,
                Enums.Skills.Stealth => Stealth,
                Enums.Skills.Survival => Survival,

                // Knowledge
                Enums.Skills.Arcana => Arcana,
                Enums.Skills.Engineering => Engineering,
                Enums.Skills.History => History,
                Enums.Skills.Local => Local,
                Enums.Skills.Nature => Nature,
                Enums.Skills.Religion => Religion,

                // Craft
                Enums.Skills.Alchemy => Alchemy,
                Enums.Skills.ArmsAndArmor => ArmsAndArmor,
                Enums.Skills.BonesAndHides => BonesAndHides,
                Enums.Skills.BowsAndArrows => BowsAndArrows,
                Enums.Skills.Glass => Glass,
                Enums.Skills.Metal => Metal,
                Enums.Skills.Traps => Traps,
                Enums.Skills.Wood => Wood,

                // Navigation
                Enums.Skills.Sea => Sea,
                Enums.Skills.Land => Land,

                _ => throw new ArgumentOutOfRangeException(
                    nameof(skill),
                    skill,
                    "No SkillDefinition exists for this skill."
                )
            };
        }
    }
}
