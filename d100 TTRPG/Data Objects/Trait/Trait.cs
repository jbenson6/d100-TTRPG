namespace d100_TTRPG.Data_Objects.Trait
{
    public class Trait
    {
        public TraitDefinition Definition { get; set; }

        public int? Value { get; set; }

        public string? Category { get; set; }

        public Trait(
            TraitDefinition definition,
            int? value = null,
            string? category = null)
        {
            Definition = definition;
            Value = value;
            Category = category;
        }
    }
}
