namespace d100_TTRPG.Data_Objects.Trait
{
    public class Trait
    {
        public TraitDefinition Definition { get; set; }
        public Trait(TraitDefinition definition)
        {
            Definition = definition;
        }
    }
}
