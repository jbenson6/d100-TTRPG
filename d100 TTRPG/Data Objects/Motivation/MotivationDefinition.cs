using d100_TTRPG.Data_Objects.Skill;
using d100_TTRPG.Data_Objects.Talent;

namespace d100_TTRPG.Data_Objects.Motivation
{
    public class MotivationDefinition
    {
        public Enums.Motivations Motivation { get; set; }

        public string? Description { get; set; }

        public Talent.Talent? Talent { get; set; }

        public List<Skill.Skill>? Skills { get; set; }

        public string? AdditionalNotes { get; set; }

        public MotivationDefinition(
            Enums.Motivations motivation,
            string description,
            Talent.Talent? talent = null,
            List<Skill.Skill>? skills = null,
            string? additionalNotes = null)
        {
            Motivation = motivation;
            Description = description;
            Talent = talent;
            Skills = skills;
            AdditionalNotes = additionalNotes;
        }
    }
}