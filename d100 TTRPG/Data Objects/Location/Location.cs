namespace d100_TTRPG.Data_Objects.Location
{
    public class Location
    {
        public LocationDefinition Definition { get; set; }
        public Location(LocationDefinition definition)
        {
            Definition = definition;
        }
    }
}
