using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Weapon
{
    public static class WeaponPropertyDb
    {
        public static readonly WeaponPropertyDefinition Thrown =
            new WeaponPropertyDefinition(
                WeaponProperty.Thrown,
                "This weapon may be thrown using its listed range."
            );

        public static readonly WeaponPropertyDefinition Reach =
            new WeaponPropertyDefinition(
                WeaponProperty.Reach,
                "This weapon has extended melee reach."
            );

        public static readonly WeaponPropertyDefinition Mounted =
            new WeaponPropertyDefinition(
                WeaponProperty.Mounted,
                "This weapon is designed to be used while mounted."
            );

        public static readonly WeaponPropertyDefinition Nonlethal =
            new WeaponPropertyDefinition(
                WeaponProperty.Nonlethal,
                "This weapon deals nonlethal damage."
            );
    }
}
