namespace d100_TTRPG.Data_Objects.Skill
{
    public class SkillDefinition
    {
        public Enums.Skills Skill { get; set; }

        public List<Enums.Characteristics> Characteristics { get; set; }

        public bool CombatDiscount { get; set; }

        public string? Description { get; set; }

        public List<ISkillSubDefinition> SubSkills { get; set; }

        public SkillDefinition(
            Enums.Skills skill,
            List<Enums.Characteristics> characteristics,
            bool combatDiscount,
            string description,
            List<ISkillSubDefinition>? subSkills = null)
        {
            Skill = skill;
            Characteristics = characteristics;
            CombatDiscount = combatDiscount;
            Description = description;
            SubSkills = subSkills ?? new List<ISkillSubDefinition>();
        }
    }
}
