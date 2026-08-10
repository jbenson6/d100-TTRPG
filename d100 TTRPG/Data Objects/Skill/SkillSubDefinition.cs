namespace d100_TTRPG.Data_Objects.Skill
{
    public class SkillSubDefinition<T> : ISkillSubDefinition
    where T : Enum
    {
        public T SubSkill { get; set; }
        public string? Description { get; set; }

        Enum ISkillSubDefinition.SubSkill => SubSkill;

        public SkillSubDefinition(T subSkill, string? description = null)
        {
            SubSkill = subSkill;
            Description = description;
        }
    }
}
