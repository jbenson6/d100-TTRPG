using d100_TTRPG.Data_Objects.Trait;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Weapon
{
    public static class WeaponDb
    {
        // ============================================================
        // AXES
        // ============================================================

        public static readonly WeaponDefinition OneHandedAxe =
            new WeaponDefinition(
                "One-Handed Axe",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 1),
                1,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unbalanced)
                }
            );

        public static readonly WeaponDefinition TwoHandedAxe =
            new WeaponDefinition(
                "Two-Handed Axe",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(2, 10, 1),
                2,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition HeavyPick =
            new WeaponDefinition(
                "Pick, Heavy",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition LightPick =
            new WeaponDefinition(
                "Pick, Light",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition ThrowingAxe =
            new WeaponDefinition(
                "Throwing Axe",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 2),
                new DamageDefinition(1, 5, 1),
                1,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );


        // ============================================================
        // BLADES
        // ============================================================

        public static readonly WeaponDefinition OneHandedSword =
            new WeaponDefinition(
                "One-Handed Sword",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 1),
                1,
                new List<DamageType>
                {
                DamageType.Piercing,
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Balanced)
                }
            );

        public static readonly WeaponDefinition TwoHandedSword =
            new WeaponDefinition(
                "Two-Handed Sword",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(2, 10, 1),
                2,
                new List<DamageType>
                {
                DamageType.Piercing,
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unbalanced)
                }
            );

        public static readonly WeaponDefinition Dagger =
            new WeaponDefinition(
                "Dagger",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 2),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Piercing,
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Balanced)
                },
                new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );

        public static readonly WeaponDefinition Scythe =
            new WeaponDefinition(
                "Scythe",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(3, 5, -1),
                2,
                new List<DamageType>
                {
                DamageType.Slashing
                }
            );

        public static readonly WeaponDefinition Sickle =
            new WeaponDefinition(
                "Sickle",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 9)
                }
            );


        // ============================================================
        // BOWS
        // ============================================================

        public static readonly WeaponDefinition HeavyCrossbow =
            new WeaponDefinition(
                "Crossbow, Heavy",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Fixed, 60),
                new DamageDefinition(3, 5, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Proven, 2)
                }
            );

        public static readonly WeaponDefinition LightCrossbow =
            new WeaponDefinition(
                "Crossbow, Light",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Fixed, 60),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );

        public static readonly WeaponDefinition HandCrossbow =
            new WeaponDefinition(
                "Hand Crossbow",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Fixed, 10),
                new DamageDefinition(1, 5, 1),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );

        public static readonly WeaponDefinition Longbow =
            new WeaponDefinition(
                "Longbow",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Fixed, 100),
                new DamageDefinition(3, 5, 1),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Proven, 2)
                }
            );

        public static readonly WeaponDefinition Shortbow =
            new WeaponDefinition(
                "Shortbow",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Fixed, 80),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );


        // ============================================================
        // CLOSE
        // ============================================================

        public static readonly WeaponDefinition Gauntlets =
            new WeaponDefinition(
                "Gauntlets",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );

        public static readonly WeaponDefinition Sap =
            new WeaponDefinition(
                "Sap",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Nonlethal
                }
            );

        public static readonly WeaponDefinition SpikedArmor =
            new WeaponDefinition(
                "Spiked Armor",
                WeaponHands.Armor,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );

        public static readonly WeaponDefinition UnarmedStrike =
            new WeaponDefinition(
                "Unarmed Strike",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );


        // ============================================================
        // FLAILS
        // ============================================================

        public static readonly WeaponDefinition Chain =
            new WeaponDefinition(
                "Chain",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(2, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition HeavyFlail =
            new WeaponDefinition(
                "Flail, Heavy",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition LightFlail =
            new WeaponDefinition(
                "Flail, Light",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition Whip =
            new WeaponDefinition(
                "Whip",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );


        // ============================================================
        // HAMMERS
        // ============================================================

        public static readonly WeaponDefinition OneHandedClub =
            new WeaponDefinition(
                "One-Handed Club",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 3),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7),
                new Trait.Trait(TraitDb.Unbalanced)
                },
                new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );

        public static readonly WeaponDefinition TwoHandedClub =
            new WeaponDefinition(
                "Two-Handed Club",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(2, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7),
                new Trait.Trait(TraitDb.Unwieldy)
                }
            );

        public static readonly WeaponDefinition HeavyMace =
            new WeaponDefinition(
                "Mace, Heavy",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                2,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unbalanced)
                }
            );

        public static readonly WeaponDefinition LightMace =
            new WeaponDefinition(
                "Mace, Light",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unbalanced)
                }
            );

        public static readonly WeaponDefinition Staff =
            new WeaponDefinition(
                "Staff",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7)
                }
            );

        public static readonly WeaponDefinition Warhammer =
            new WeaponDefinition(
                "Warhammer",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 1),
                2,
                new List<DamageType>
                {
                DamageType.Bashing,
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Unbalanced)
                }
            );


        // ============================================================
        // NATURAL
        // ============================================================

        public static readonly WeaponDefinition Bite =
            new WeaponDefinition(
                "NA [Bite]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7)
                }
            );

        public static readonly WeaponDefinition Claws =
            new WeaponDefinition(
                "NA [Claws]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(2, 5),
                0,
                new List<DamageType>
                {
                DamageType.Slashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 4)
                }
            );

        public static readonly WeaponDefinition Gore =
            new WeaponDefinition(
                "NA [Gore]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 8)
                }
            );

        public static readonly WeaponDefinition Ram =
            new WeaponDefinition(
                "NA [Ram]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7)
                }
            );

        public static readonly WeaponDefinition Slam =
            new WeaponDefinition(
                "NA [Slam]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );

        public static readonly WeaponDefinition Tail =
            new WeaponDefinition(
                "NA [Tail]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Slashing
                }
            );

        public static readonly WeaponDefinition Tongue =
            new WeaponDefinition(
                "NA [Tongue]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );

        public static readonly WeaponDefinition Wing =
            new WeaponDefinition(
                "NA [Wing]",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );

        public static readonly WeaponDefinition NaturalUnarmedStrike =
            new WeaponDefinition(
                "Unarmed Strike",
                WeaponHands.Natural,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                }
            );


        // ============================================================
        // POLEARMS
        // ============================================================

        public static readonly WeaponDefinition Bardiche =
            new WeaponDefinition(
                "Bardiche",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                1,
                new List<DamageType>
                {
                DamageType.Slashing
                }
            );

        public static readonly WeaponDefinition Glaive =
            new WeaponDefinition(
                "Glaive",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing,
                DamageType.Slashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Reach
                }
            );

        public static readonly WeaponDefinition Poleaxe =
            new WeaponDefinition(
                "Poleaxe",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Bashing,
                DamageType.Piercing,
                DamageType.Slashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Reach
                }
            );


        // ============================================================
        // SPEARS
        // ============================================================

        public static readonly WeaponDefinition Javelin =
            new WeaponDefinition(
                "Javelin",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 5),
                new DamageDefinition(1, 10),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 8)
                },
                new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );

        public static readonly WeaponDefinition Lance =
            new WeaponDefinition(
                "Lance",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Mounted,
                WeaponPropertyDb.Reach
                }
            );

        public static readonly WeaponDefinition Longspear =
            new WeaponDefinition(
                "Longspear",
                WeaponHands.TwoHanded,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Reach
                }
            );

        public static readonly WeaponDefinition Spear =
            new WeaponDefinition(
                "Spear",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 3),
                new DamageDefinition(1, 10, 1),
                1,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );

        public static readonly WeaponDefinition Trident =
            new WeaponDefinition(
                "Trident",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.Strength, 2),
                new DamageDefinition(2, 5, 2),
                2,
                new List<DamageType>
                {
                DamageType.Piercing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Thrown
                }
            );


        // ============================================================
        // THROWN
        // ============================================================

        public static readonly WeaponDefinition Blowgun =
            new WeaponDefinition(
                "Blowgun",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.RangedSkill, 3),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );

        public static readonly WeaponDefinition Bolas =
            new WeaponDefinition(
                "Bolas",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.RangedSkill, 5),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Nonlethal,
                WeaponPropertyDb.Thrown
                },
                traits: new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Snare, 2)
                }
            );

        public static readonly WeaponDefinition Dart =
            new WeaponDefinition(
                "Dart",
                WeaponHands.Natural,
                new WeaponRange(RangeType.RangedSkill, 3),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Piercing
                }
            );

        public static readonly WeaponDefinition Net =
            new WeaponDefinition(
                "Net",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.RangedSkill, 1, 5),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                properties: new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Nonlethal,
                WeaponPropertyDb.Thrown
                },
                traits: new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Snare, 3)
                }
            );

        public static readonly WeaponDefinition Sling =
            new WeaponDefinition(
                "Sling",
                WeaponHands.OneHanded,
                new WeaponRange(RangeType.RangedSkill, 5),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Primitive, 7)
                }
            );


        // ============================================================
        // SHIELDS
        // ============================================================

        public static readonly WeaponDefinition HeavyIronShield =
            new WeaponDefinition(
                "Shield, Heavy Iron",
                WeaponHands.Shield,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10, 1),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                }
            );

        public static readonly WeaponDefinition LightIronShield =
            new WeaponDefinition(
                "Shield, Light Iron",
                WeaponHands.Shield,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5, 1),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                }
            );

        public static readonly WeaponDefinition HeavyWoodShield =
            new WeaponDefinition(
                "Shield, Heavy Wood",
                WeaponHands.Shield,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 10),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                }
            );

        public static readonly WeaponDefinition LightWoodShield =
            new WeaponDefinition(
                "Shield, Light Wood",
                WeaponHands.Shield,
                new WeaponRange(RangeType.Melee),
                new DamageDefinition(1, 5),
                0,
                new List<DamageType>
                {
                DamageType.Bashing
                },
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                }
            );

        public static readonly WeaponDefinition IronTowerShield =
            new WeaponDefinition(
                "Tower Shield, Iron",
                WeaponHands.TowerShield,
                new WeaponRange(RangeType.Melee),
                null,
                0,
                new List<DamageType>(),
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                },
                new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Reach
                }
            );

        public static readonly WeaponDefinition WoodTowerShield =
            new WeaponDefinition(
                "Tower Shield, Wood",
                WeaponHands.TowerShield,
                new WeaponRange(RangeType.Melee),
                null,
                0,
                new List<DamageType>(),
                new List<Trait.Trait>
                {
                new Trait.Trait(TraitDb.Defensive)
                },
                new List<WeaponPropertyDefinition>
                {
                WeaponPropertyDb.Reach
                }
            );
    }
}
