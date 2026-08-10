namespace d100_TTRPG.Data_Objects.Trade
{
    public class TradeDefinition
    {
        public Enums.Trades Trade { get; set; }
        public string? Description { get; set; }
        public Talent.Talent? Talent { get; set; }
        public List<Skill.Skill>? Skills { get; set; }
        public string? AdditionalNotes { get; set; }

    }
}
