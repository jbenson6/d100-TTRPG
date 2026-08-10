namespace d100_TTRPG.Data_Objects.Trait
{
    public enum TraitType
    {
        Creature = 1,
        Weapon = 2
    }

    public class TraitDefinition
    {
        public Enums.Traits Trait { get; set; }

        public TraitType Type { get; set; }

        public string? Description { get; set; }

        public string? ValueDescription { get; set; }

        public List<string> Categories { get; set; }

        public TraitDefinition(
            Enums.Traits trait,
            TraitType type,
            string? description = null,
            string? valueDescription = null,
            List<string>? categories = null)
        {
            Trait = trait;
            Type = type;
            Description = description;
            ValueDescription = valueDescription;
            Categories = categories ?? new List<string>();
        }
    }
}
