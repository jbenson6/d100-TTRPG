using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.PowerLevel
{
    public class PowerLevelDefinition
    {
        public PowerLevels Level { get; set; }
        public int Points { get; set; }
        public int Features { get; set; }
        public string? Description { get; set; }

        public PowerLevelDefinition(PowerLevels level, int points, int features, string? description = null)
        {
            Level = level;
            Points = points;
            Features = features;
            Description = description;
        }
    }
}
