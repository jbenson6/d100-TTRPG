namespace d100_TTRPG.Data_Objects.Feature
{
    public class Feature
    {
        public FeatureDefinition Definition { get; set; }
        public Feature(FeatureDefinition definition)
        {
            Definition = definition;
        }
    }
}
