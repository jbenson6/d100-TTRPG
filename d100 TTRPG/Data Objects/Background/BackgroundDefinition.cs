using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Background
{
    public class BackgroundDefinition
    {
        public Enums.Backgrounds Background { get; set; }
        public string? Description { get; set; }
        public Talent.Talent? Talent { get; set; }
        public List<Skill.Skill>? Skill { get; set; }
        public string AdditionalNotes { get; set; }

        public BackgroundDefinition(Backgrounds background, string? description, Talent.Talent? talent, List<Skill.Skill>? skill, string additionalNotes)
        {
            Background = background;
            Description = description;
            Talent = talent;
            Skill = skill;
            AdditionalNotes = additionalNotes;
        }
    }
}
