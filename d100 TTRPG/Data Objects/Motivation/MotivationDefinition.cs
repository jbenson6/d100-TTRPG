namespace d100_TTRPG.Data_Objects.Motivation
{
    public class MotivationDefinition
    {
        public Enums.Motivations Motivation { get; set; }
        public string? Description { get; set; }
        public Talent.Talent Talent { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public string AdditionalNotes { get; set; }
        public MotivationDefinition(Enums.Motivations motivation, string description, Talent.Talent talent, List<Skill.Skill> skills, string additionalNotes) 
        {
            Motivation = motivation;
            Description = description;
            Talent = talent;
            Skills = skills;
            AdditionalNotes = additionalNotes;
        }
    }
}
