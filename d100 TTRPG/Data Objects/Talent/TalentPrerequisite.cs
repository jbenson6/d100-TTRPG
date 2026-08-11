using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Talent
{
    public class TalentPrerequisite
    {
        public TalentPrerequisiteType Type { get; set; }

        public Characteristics? Characteristic { get; set; }

        public Skills? Skill { get; set; }

        public Talents? Talent { get; set; }

        public string? WeaponGroup { get; set; }

        public string? Name { get; set; }

        public int? Value { get; set; }

        public SkillRank? Rank { get; set; }

        public TalentPrerequisite(
            TalentPrerequisiteType type,
            Characteristics? characteristic = null,
            Skills? skill = null,
            Talents? talent = null,
            string? weaponGroup = null,
            string? name = null,
            int? value = null,
            SkillRank? rank = null)
        {
            Type = type;
            Characteristic = characteristic;
            Skill = skill;
            Talent = talent;
            WeaponGroup = weaponGroup;
            Name = name;
            Value = value;
            Rank = rank;
        }
    }
}