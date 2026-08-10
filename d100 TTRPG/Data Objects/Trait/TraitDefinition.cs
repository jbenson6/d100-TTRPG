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

        // Standard constructor
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

        // Compatibility constructor for TraitDb entries that use:
        // trait, type, description, hasValue, valueDescription, categories
        //
        // The bool is retained for compatibility with the existing
        // TraitDb definitions. Whether a trait has a value is determined
        // by ValueDescription being present.
        public TraitDefinition(
            Enums.Traits trait,
            TraitType type,
            string? description,
            bool hasValue,
            string? valueDescription,
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

