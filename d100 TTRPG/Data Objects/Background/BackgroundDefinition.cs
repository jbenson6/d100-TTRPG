using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Background
{
    public class BackgroundDefinition
    {
        public Enums.Backgrounds Background { get; set; }

        public string? Description { get; set; }

        public Talent.TalentDefinition? Talent { get; set; }

        public List<Skill.SkillDefinition> Skills { get; set; }

        public List<BackgroundChoice> Choices { get; set; }

        public string AdditionalNotes { get; set; }

        public BackgroundDefinition(
            Enums.Backgrounds background,
            string? description,
            Talent.TalentDefinition? talent,
            List<Skill.SkillDefinition>? skills,
            List<BackgroundChoice>? choices,
            string additionalNotes)
        {
            Background = background;
            Description = description;
            Talent = talent;
            Skills = skills ?? new List<Skill.SkillDefinition>();
            Choices = choices ?? new List<BackgroundChoice>();
            AdditionalNotes = additionalNotes;
        }
    }
}
