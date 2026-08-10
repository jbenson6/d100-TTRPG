namespace d100_TTRPG.Data_Objects.Armor
{
    public static class ArmorDb
    {
        public static readonly ArmorDefinition PaddedArmor =
            new ArmorDefinition(Enums.Armor.Padded, 0, 0, 1);

        public static readonly ArmorDefinition LightArmor =
            new ArmorDefinition(Enums.Armor.Light, 0, 0, 2);

        public static readonly ArmorDefinition MediumArmor =
            new ArmorDefinition(Enums.Armor.Medium, 0, -10, 4);

        public static readonly ArmorDefinition HeavyArmor =
            new ArmorDefinition(Enums.Armor.Heavy, -1, -20, 6);

        public static readonly ArmorDefinition SuperHeavyArmor =
            new ArmorDefinition(Enums.Armor.SuperHeavy, -2, -20, 8);

    }
}
