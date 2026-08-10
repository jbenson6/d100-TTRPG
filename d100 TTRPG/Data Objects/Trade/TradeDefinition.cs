namespace d100_TTRPG.Data_Objects.Trade
{
    public class TradeDefinition
    {
        public Enums.Trades Trade { get; set; }

        public string? Description { get; set; }

        public Talent.Talent? Talent { get; set; }

        // Normal skills granted by the Trade.
        public List<Enums.Skills>? Skills { get; set; }

        // Knowledge skills granted by the Trade.
        public List<Enums.Knowledge>? Knowledge { get; set; }

        // Craft specializations granted by the Trade.
        public List<Enums.Craft>? Crafts { get; set; }

        // Additional specialization text where the rules allow
        // player/GM selection rather than a fixed enum value.
        public List<string>? Specializations { get; set; }

        public string? AdditionalNotes { get; set; }

        public TradeDefinition(
            Enums.Trades trade,
            string description,
            Talent.Talent? talent = null,
            List<Enums.Skills>? skills = null,
            List<Enums.Knowledge>? knowledge = null,
            List<Enums.Craft>? crafts = null,
            List<string>? specializations = null,
            string? additionalNotes = null)
        {
            Trade = trade;
            Description = description;
            Talent = talent;
            Skills = skills ?? new List<Enums.Skills>();
            Knowledge = knowledge ?? new List<Enums.Knowledge>();
            Crafts = crafts ?? new List<Enums.Craft>();
            Specializations = specializations ?? new List<string>();
            AdditionalNotes = additionalNotes;
        }
    }
}
