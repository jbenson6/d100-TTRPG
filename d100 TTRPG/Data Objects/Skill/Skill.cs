namespace d100_TTRPG.Data_Objects.Skill
{
    public class Skill
    {
        public SkillDefinition Definition { get; set; }
        public Skill(SkillDefinition definition)
        {
            Definition = definition;
        }
    }
}
