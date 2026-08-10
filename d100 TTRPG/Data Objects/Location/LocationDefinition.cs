using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Location
{
    public class LocationDefinition
    {
        public Locations Location { get; set; }
        public List<Race.Race>? Races { get; set; }

        public LocationDefinition(Locations location, List<Race.Race>? races)
        {
            Location = location;
            Races = races;
        }
    }
}
