using d100_TTRPG.Data_Objects.Language;
using d100_TTRPG.Data_Objects.Skill;
using d100_TTRPG.Data_Objects.Spell;
using d100_TTRPG.Data_Objects.Talent;
using d100_TTRPG.Data_Objects.Trait;
using System.Collections.Generic;

namespace d100_TTRPG.Data_Objects.Race
{
    public static class RaceDb
    {
        public static readonly RaceDefinition Aasimar =
            new RaceDefinition(
                Enums.Races.Aasimar,
                10,
                20, 20, 20, 20, 20, 25, 20, 25, 35,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.Religion),
                    new Skill.Skill(SkillDb.Linguistics),
                    new Skill.Skill(SkillDb.Medicine),
                    new Skill.Skill(SkillDb.Persuade)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Celestial),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune)
                },

                new List<Spell.Spell>
                {
                    new Spell.Spell(SpellDb.Spells.GetValueOrDefault(Enums.Spells.Heal))
                },

                null
            );


        public static readonly RaceDefinition Anurans =
            new RaceDefinition(
                Enums.Races.Anurans,
                4,
                0, 0, 0, 0, 0, 0, 0, 0, 0,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Amphibious),

                },

                null,
                null
            );


        public static readonly RaceDefinition Bear =
            new RaceDefinition(
                Enums.Races.Bear,
                13,
                25, 15, 35, 20, 30, 20, 20, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival),
                    new Skill.Skill(SkillDb.Intimidate)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Endurance)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.NaturalArmor)
                },

                null,
                null
            );


        public static readonly RaceDefinition Faun =
            new RaceDefinition(
                Enums.Races.Faun,
                10,
                20, 20, 25, 25, 25, 20, 20, 25, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival),
                    new Skill.Skill(SkillDb.Acrobatics)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.ImprovedCombatManeuver)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.NaturalArmor)
                },

                null,
                null
            );


        public static readonly RaceDefinition Hare =
            new RaceDefinition(
                Enums.Races.Hare,
                9,
                20, 20, 20, 35, 20, 20, 25, 15, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Stealth)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Haste)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),

                },

                null,
                null
            );


        public static readonly RaceDefinition Shark =
            new RaceDefinition(
                Enums.Races.Shark,
                12,
                25, 15, 30, 20, 20, 20, 35, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Sea)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.ImprovedCombatManeuver)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Enkidian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Amphibious),
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.Swim),
                    new Trait.Trait(TraitDb.Tail)
                },

                null,
                null
            );


        public static readonly RaceDefinition Catfolk =
            new RaceDefinition(
                Enums.Races.Catfolk,
                10,
                20, 20, 20, 35, 20, 20, 25, 15, 25,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Deceive),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Persuade),
                    new Skill.Skill(SkillDb.Stealth)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Catfall)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.CatsLuck),
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.NaturalArmor),
                    new Trait.Trait(TraitDb.Tail)
                },

                null,
                null
            );


        public static readonly RaceDefinition Dhampir =
            new RaceDefinition(
                Enums.Races.Dhampir,
                10,
                20, 20, 20, 30, 20, 20, 25, 20, 30,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Deceive),
                    new Skill.Skill(SkillDb.Persuade),
                    new Skill.Skill(SkillDb.Stealth)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Ishi),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.Darkvision),
                    new Trait.Trait(TraitDb.Sleepless)
                },

                null,

                null
            );


        public static readonly RaceDefinition Djinn =
            new RaceDefinition(
                Enums.Races.Djinn,
                10,
                25, 25, 20, 20, 20, 25, 20, 30, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Arcana),
                    new Skill.Skill(SkillDb.Religion),
                    new Skill.Skill(SkillDb.Persuade)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Draconic),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Scytho)
                },

                new List<Trait.Trait>
                {

                },

                new List<Spell.Spell>
                {
                    new Spell.Spell(SpellDb.Spells.GetValueOrDefault(Enums.Spells.ElementalBlast))
                },

                null
            );


        public static readonly RaceDefinition MoonElf =
            new RaceDefinition(
                Enums.Races.MoonElf,
                9,
                20, 20, 20, 25, 20, 35, 25, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Arcana),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Deceive),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Stealth),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Abyssal),
                    new Language.Language(LanguageDb.Giant)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Darkvision),

                },

                null,
                null
            );


        public static readonly RaceDefinition SunElf =
            new RaceDefinition(
                Enums.Races.SunElf,
                9,
                20, 20, 20, 25, 20, 35, 25, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Arcana),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Geography),
                    new Skill.Skill(SkillDb.Local)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Darkvision),

                },

                null,
                null
            );


        public static readonly RaceDefinition Melondi =
            new RaceDefinition(
                Enums.Races.Melondi,
                9,
                20, 20, 20, 25, 20, 35, 25, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Arcana),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Linguistics)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Darkvision),

                },

                null,
                null
            );


        public static readonly RaceDefinition Gnoll =
            new RaceDefinition(
                Enums.Races.Gnoll,
                12,
                20, 20, 30, 20, 35, 15, 25, 20, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Parry),
                    new Skill.Skill(SkillDb.Survival)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.LightSleeper),
                    new Talent.Talent(TalentDb.Paranoia)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Orcish),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Taheeli)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.NaturalArmor)
                },

                null,
                null
            );


        public static readonly RaceDefinition Goblin =
            new RaceDefinition(
                Enums.Races.Goblin,
                7,
                20, 20, 15, 25, 20, 25, 20, 15, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Stealth)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Orcish),
                    new Language.Language(LanguageDb.Giant),
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {

                },

                null,
                null
            );


        public static readonly RaceDefinition Mithranite =
            new RaceDefinition(
                Enums.Races.Mithranite,
                10,
                20, 20, 20, 20, 20, 20, 25, 25, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Local),
                    new Skill.Skill(SkillDb.Deceive),
                    new Skill.Skill(SkillDb.Persuade),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.History)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Minion)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Taheeli)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Nubian =
            new RaceDefinition(
                Enums.Races.Nubian,
                10,
                20, 20, 20, 25, 25, 15, 20, 15, 20,

                new List<Skill.Skill>
                {

                    new Skill.Skill(SkillDb.Local),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Survival)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Endurance)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Taheeli),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Oriental =
            new RaceDefinition(
                Enums.Races.Oriental,
                10,
                20, 20, 20, 25, 20, 25, 20, 20, 20,

                new List<Skill.Skill>
                {

                    new Skill.Skill(SkillDb.Acrobatics),
                    new Skill.Skill(SkillDb.Athletics)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.UnarmedWarrior)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Ishi),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Sylvan)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Thessian =
            new RaceDefinition(
                Enums.Races.Thessian,
                10,
                20, 20, 25, 20, 20, 25, 20, 20, 20,

                new List<Skill.Skill>
                {

                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Persuade)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Thessian),
                    new Language.Language(LanguageDb.Draconic),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Enkidian),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Sylvan)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Zymen =
            new RaceDefinition(
                Enums.Races.Zymen,
                10,
                20, 20, 20, 20, 20, 15, 25, 20, 25,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Kamanali),
                    new Language.Language(LanguageDb.Enkidian),
                    new Language.Language(LanguageDb.Giant),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Sylvan)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Ifrit =
            new RaceDefinition(
                Enums.Races.Ifrit,
                10,
                30, 30, 20, 20, 20, 20, 20, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Parry),
                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Ride)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Draconic),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Scytho)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune),
                    
                },

                new List<Spell.Spell>
                {
                  new Spell.Spell(SpellDb.Spells.GetValueOrDefault(Enums.Spells.Immolation))
                },

                null
            );


        public static readonly RaceDefinition Kitsune =
            new RaceDefinition(
                Enums.Races.Kitsune,
                9,
                20, 20, 20, 30, 20, 25, 25, 20, 25,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Escape),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Local)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Haste)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Ishi),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Sylvan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Scent)
                },

                null,
                null
            );


        public static readonly RaceDefinition Kobold =
            new RaceDefinition(
                Enums.Races.Kobold,
                8,
                25, 20, 25, 20, 30, 20, 20, 15, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Traps),
                    new Skill.Skill(SkillDb.Engineering),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Orcish),
                    new Language.Language(LanguageDb.Sylvan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune),
                    new Trait.Trait(TraitDb.NaturalArmor),
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),

                },

                null,
                null
            );


        public static readonly RaceDefinition Atlanteans =
            new RaceDefinition(
                Enums.Races.Atlanteans,
                10,
                20, 15, 25, 25, 25, 20, 20, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Giant),
                    new Language.Language(LanguageDb.Kamanali),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Amphibious),
                    new Trait.Trait(TraitDb.Darkvision),
                    new Trait.Trait(TraitDb.Swim)
                },

                null,
                null
            );


        public static readonly RaceDefinition Merrow =
            new RaceDefinition(
                Enums.Races.Merrow,
                11,
                25, 15, 25, 25, 25, 20, 30, 25, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Local),
                    new Skill.Skill(SkillDb.Sea),
                    new Skill.Skill(SkillDb.Survival),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Escape),
                    new Skill.Skill(SkillDb.Parry),
                    new Skill.Skill(SkillDb.Stealth)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.Endurance)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Enkidian),
                    new Language.Language(LanguageDb.Abyssal),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Ishi),
                    new Language.Language(LanguageDb.Scytho)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Amphibious),
                    new Trait.Trait(TraitDb.Darkvision),
                    new Trait.Trait(TraitDb.NaturalArmor),
                    new Trait.Trait(TraitDb.Swim)
                },

                null,
                null
            );


        public static readonly RaceDefinition Monitori =
            new RaceDefinition(
                Enums.Races.Monitori,
                12,
                30, 15, 30, 20, 30, 15, 20, 20, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Saurian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune),
                    new Trait.Trait(TraitDb.NaturalArmor),
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.Scent),
                    new Trait.Trait(TraitDb.Tail)
                },

                null,
                null
            );


        public static readonly RaceDefinition Orc =
            new RaceDefinition(
                Enums.Races.Orc,
                12,
                20, 20, 30, 20, 30, 15, 20, 15, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Nature)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Orcish),
                    new Language.Language(LanguageDb.Giant),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Darkvision),

                },

                null,
                null
            );


        public static readonly RaceDefinition Raptor =
            new RaceDefinition(
                Enums.Races.Raptor,
                8,
                20, 20, 20, 30, 20, 20, 30, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.Land),
                    new Skill.Skill(SkillDb.Stealth)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.BerserkCharge),
                    new Talent.Talent(TalentDb.DeadeyeShot),
                    new Talent.Talent(TalentDb.SureStrike)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Flight),
                    new Trait.Trait(TraitDb.Wings)
                },

                null,
                null
            );


        public static readonly RaceDefinition Scavenger =
            new RaceDefinition(
                Enums.Races.Scavenger,
                9,
                20, 20, 20, 20, 30, 20, 30, 25, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Medicine),
                    new Skill.Skill(SkillDb.Nature),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune)
                },

                null,
                null
            );


        public static readonly RaceDefinition Tengu =
            new RaceDefinition(
                Enums.Races.Tengu,
                8,
                20, 20, 20, 20, 20, 30, 25, 20, 30,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Local),
                    new Skill.Skill(SkillDb.Stealth)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Ishi),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Sylvan)
                },

                null,
                null,
                null
            );


        public static readonly RaceDefinition Sylph =
            new RaceDefinition(
                Enums.Races.Sylph,
                9,
                20, 20, 20, 35, 20, 25, 20, 20, 25,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Acrobatics),
                    new Skill.Skill(SkillDb.Dodge),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Local),
                    new Skill.Skill(SkillDb.Stealth)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Djinni),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Enkidian),
                    new Language.Language(LanguageDb.Giant),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Kamanali),
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Saurian),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian),
                    new Language.Language(LanguageDb.Taheeli)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Immune),

                },

                new List<Spell.Spell>
                {
                    new Spell.Spell(SpellDb.Spells.GetValueOrDefault(Enums.Spells.FeatherFall))
                },

                null
            );


        public static readonly RaceDefinition Cow =
            new RaceDefinition(
                Enums.Races.Cow,
                11,
                20, 15, 30, 20, 35, 20, 20, 20, 25,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.HandleAnimal),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Persuade),
                    new Skill.Skill(SkillDb.History),
                    new Skill.Skill(SkillDb.Local)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Horns),
                    new Trait.Trait(TraitDb.NaturalArmor),

                },

                null,
                null
            );


        public static readonly RaceDefinition Varruck =
            new RaceDefinition(
                Enums.Races.Varruck,
                10,
                15, 15, 15, 15, 15, 15, 15, 15, 15,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Deceive),
                    new Skill.Skill(SkillDb.Persuade),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Parry),
                    new Skill.Skill(SkillDb.Stealth)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Abyssal),
                    new Language.Language(LanguageDb.Draconic),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Lycan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Darkvision),
                    new Trait.Trait(TraitDb.DeadlyNaturalWeapons),
                    new Trait.Trait(TraitDb.PrehensileTail)
                },

                null,
                null
            );


        public static readonly RaceDefinition Werewolf =
            new RaceDefinition(
                Enums.Races.Werewolf,
                11,
                25, 20, 20, 20, 25, 20, 25, 15, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Awareness),
                    new Skill.Skill(SkillDb.Insight),
                    new Skill.Skill(SkillDb.Survival)
                },

                null,

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Orcish),
                    new Language.Language(LanguageDb.Thessian),
                    new Language.Language(LanguageDb.Sylvan)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Scent),
                    new Trait.Trait(TraitDb.HybridForm)
                },

                null,
                null
            );


        public static readonly RaceDefinition Bull =
            new RaceDefinition(
                Enums.Races.Bull,
                15,
                25, 15, 50, 20, 50, 15, 20, 20, 20,

                new List<Skill.Skill>
                {
                    new Skill.Skill(SkillDb.Athletics),
                    new Skill.Skill(SkillDb.Intimidate),
                    new Skill.Skill(SkillDb.Survival)
                },

                new List<Talent.Talent>
                {
                    new Talent.Talent(TalentDb.ImprovedCombatManeuver)
                },

                new List<Language.Language>
                {
                    new Language.Language(LanguageDb.Lycan),
                    new Language.Language(LanguageDb.Elven),
                    new Language.Language(LanguageDb.Infernal),
                    new Language.Language(LanguageDb.Scytho),
                    new Language.Language(LanguageDb.Sylvan),
                    new Language.Language(LanguageDb.Thessian)
                },

                new List<Trait.Trait>
                {
                    new Trait.Trait(TraitDb.Horns),
                    new Trait.Trait(TraitDb.NaturalArmor),

                },

                null,
                null
            );


        // The following races are retained from the existing RaceDb.
        // They are not present in the supplied Tier 1 Mortal Races PDF,
        // so their existing characteristic values are preserved.

        public static readonly RaceDefinition Drake =
            new RaceDefinition(
                Enums.Races.Drake,
                14,
                25, 25, 30, 25, 40, 25, 25, 25, 25,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Dryad =
            new RaceDefinition(
                Enums.Races.Dryad,
                10,
                20, 20, 20, 40, 30, 25, 20, 20, 25,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Gnome =
            new RaceDefinition(
                Enums.Races.Gnome,
                5,
                25, 25, 15, 40, 20, 40, 25, 25, 15,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Nymph =
            new RaceDefinition(
                Enums.Races.Nymph,
                10,
                25, 25, 20, 40, 25, 30, 25, 25, 40,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Hornet =
            new RaceDefinition(
                Enums.Races.Hornet,
                0,
                20, 20, 20, 35, 25, 30, 30, 25, 30,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Jotun =
            new RaceDefinition(
                Enums.Races.Jotun,
                15,
                25, 25, 50, 20, 50, 20, 20, 20, 15,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Lamia =
            new RaceDefinition(
                Enums.Races.Lamia,
                0,
                25, 20, 40, 40, 25, 25, 25, 25, 20,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Nectarine =
            new RaceDefinition(
                Enums.Races.Nectarine,
                0,
                20, 20, 20, 30, 30, 25, 30, 20, 40,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Angel =
            new RaceDefinition(
                Enums.Races.Angel,
                0,
                35, 35, 35, 35, 35, 35, 35, 35, 35,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Cyclops =
            new RaceDefinition(
                Enums.Races.Cyclops,
                0,
                30, 30, 60, 20, 60, 30, 30, 35, 20,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Oni =
            new RaceDefinition(
                Enums.Races.Oni,
                0,
                0, 0, 0, 0, 0, 0, 0, 0, 0,
                null,
                null,
                null,
                null,
                null,
                null
            );


        public static readonly RaceDefinition Succubus =
            new RaceDefinition(
                Enums.Races.Succubus,
                0,
                0, 0, 0, 0, 0, 0, 0, 0, 0,
                null,
                null,
                null,
                null,
                null,
                null
            );
    }
}