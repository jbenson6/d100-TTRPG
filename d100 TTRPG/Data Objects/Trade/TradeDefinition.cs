namespace d100_TTRPG.Data_Objects.Trade
{
    public class TradeDefinition
    {
        public Enums.Trades Trade { get; set; }

        public string? Description { get; set; }

        public Talent.Talent? Talent { get; set; }

        // Normal skills granted by the Trade.
        public List<Enums.Skills>? Skills { get; set; }

        public string? AdditionalNotes { get; set; }

        public TradeDefinition(
            Enums.Trades trade,
            string description,
            Talent.Talent? talent = null,
            List<Enums.Skills>? skills = null,
            string? additionalNotes = null)
        {
            Trade = trade;
            Description = description;
            Talent = talent;
            Skills = skills ?? new List<Enums.Skills>();
            AdditionalNotes = additionalNotes;
        }
    }
}
