using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Talent
{
    public static class TalentPrerequisiteDb
    {
        public static TalentPrerequisite Stat(
            Characteristics characteristic,
            int value)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Characteristic,
                characteristic: characteristic,
                value: value);
        }

        public static TalentPrerequisite MP(int value)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Feature,
                name: "MP",
                value: value);
        }

        public static TalentPrerequisite Skill(
            Skills skill,
            SkillRank rank)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Skill,
                skill: skill,
                rank: rank);
        }

        public static TalentPrerequisite Talent(
            Talents talent)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Talent,
                talent: talent);
        }

        public static TalentPrerequisite WeaponProficiency(
            string weaponGroup)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.WeaponProficiency,
                weaponGroup: weaponGroup);
        }

        public static TalentPrerequisite WeaponFocus(
            string weaponGroup)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.WeaponFocus,
                weaponGroup: weaponGroup);
        }

        public static TalentPrerequisite SpellFocus(
            string school)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.SpellFocus,
                name: school);
        }

        public static TalentPrerequisite Feature(
            string name)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Feature,
                name: name);
        }

        public static TalentPrerequisite Feature(
            string name,
            int value)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Feature,
                name: name,
                value: value);
        }

        public static TalentPrerequisite Race(
            string race)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Race,
                name: race);
        }

        public static TalentPrerequisite Region(
            string region)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Region,
                name: region);
        }

        public static TalentPrerequisite Spell(
            string spell)
        {
            return new TalentPrerequisite(
                TalentPrerequisiteType.Spell,
                name: spell);
        }
    }
}