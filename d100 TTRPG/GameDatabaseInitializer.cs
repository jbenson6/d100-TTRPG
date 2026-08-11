namespace d100_TTRPG
{
    using d100_TTRPG.Data_Objects.Armor;
    using d100_TTRPG.Data_Objects.Background;
    using d100_TTRPG.Data_Objects.Feature;
    using d100_TTRPG.Data_Objects.Location;
    using d100_TTRPG.Data_Objects.Motivation;
    using d100_TTRPG.Data_Objects.Race;
    using d100_TTRPG.Data_Objects.Spell;
    using d100_TTRPG.Data_Objects.Trade;
    using d100_TTRPG.Data_Objects.Weapon;
    using System.Runtime.CompilerServices;

    public static class GameDatabaseInitializer
    {
        public static void Initialize()
        {
            RuntimeHelpers.RunClassConstructor(typeof(FeatureDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(BackgroundDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(TradeDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(MotivationDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(RaceDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(LocationDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(WeaponDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(ArmorDb).TypeHandle);
            RuntimeHelpers.RunClassConstructor(typeof(SpellDb).TypeHandle);
        }
    }
}
