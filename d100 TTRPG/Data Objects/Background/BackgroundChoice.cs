namespace d100_TTRPG.Data_Objects.Background
{
    public enum BackgroundChoiceType
    {
        Skill = 1
    }

    public class BackgroundChoice
    {
        public BackgroundChoiceType Type { get; set; }

        public int Amount { get; set; }

        public string? Description { get; set; }

        public Enums.Skills? Skill { get; set; }

        public BackgroundChoice(
            BackgroundChoiceType type,
            int amount,
            string? description = null,
            Enums.Skills? skill = null)
        {
            Type = type;
            Amount = amount;
            Description = description;
            Skill = skill;
        }
    }
}
