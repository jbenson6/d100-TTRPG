using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Location
{
    public class LocationDefinition
    {
        public Locations Location { get; set; }
        public List<Races>? Races { get; set; }

        public LocationDefinition(Locations location, List<Races> races)
        {
            Location = location;
            Races = races;
        }
    }
}
