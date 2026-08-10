namespace d100_TTRPG.Data_Objects.Trade
{
    public class TradeDefinition
    {
        public Enums.Trades Trade { get; set; }
        public string? Description { get; set; }
        public Talent.Talent? Talent { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public string? AdditionalNotes { get; set; }

        public TradeDefinition(Enums.Trades trade, string description, Talent.Talent talent, List<Skill.Skill> skills, string additionalNotes)
        {
            Trade = trade;
            Description = description;
            Talent = talent; 
            Skills = skills;
            AdditionalNotes = additionalNotes;
        }
    }
}
