using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.PowerLevel
{
    public static class PowerLevelDb
    {
        public static readonly PowerLevelDefinition Casual =
            new PowerLevelDefinition(
                PowerLevels.Casual,
                100,
                2,
                "Casual: fewer points and features"
            );

        public static readonly PowerLevelDefinition Standard =
            new PowerLevelDefinition(
                PowerLevels.Standard,
                120,
                3,
                "Standard: balanced play"
            );

        public static readonly PowerLevelDefinition Heroic =
            new PowerLevelDefinition(
                PowerLevels.Heroic,
                140,
                4,
                "Heroic: more points and features"
            );
    }
}
