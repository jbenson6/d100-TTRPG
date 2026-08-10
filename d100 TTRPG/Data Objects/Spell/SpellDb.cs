using System.Collections.Generic;
using d100_TTRPG.Data_Objects.Spell;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Spell
{
    public static class SpellDb
    {
        public static readonly Dictionary<Enums.Spells, SpellDefinition> Spells =
            new Dictionary<Enums.Spells, SpellDefinition>
            {
                // ============================================================
                // ABJURATION
                // ============================================================

                [Enums.Spells.Dispel] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = -10
                },

                [Enums.Spells.ElementalResistance] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30
                },

                [Enums.Spells.GlyphOfWarding] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Shield] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 30
                },

                [Enums.Spells.Seal] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Abjuration,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 6,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -20
                },

                // ============================================================
                // CONJURATION
                // ============================================================

                [Enums.Spells.AnimateWeapon] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 30
                },

                [Enums.Spells.ArcaneBind] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.ArcaneGate] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 500,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 45,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.MistyStep] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = -10
                },

                [Enums.Spells.CreateWater] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.EtherealChest] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Grease] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.Light] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.MageHand] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30
                },

                [Enums.Spells.PungentOdor] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.RuinousFog] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.SummonArmor] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Conjuration,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 30
                },

                // ============================================================
                // DIVINATION
                // ============================================================

                [Enums.Spells.Fateseal] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Track] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 150,
                    TestChar = Characteristics.PER,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.MemoryDelve] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Divination,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -20
                },

                // ============================================================
                // ENCHANTMENT
                // ============================================================

                [Enums.Spells.CharmPerson] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Despair] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Goad] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.InstillFear] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Obliviate] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Stupor] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.TurnFoe] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Enchantment,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                // ============================================================
                // EVOCATION
                // ============================================================

                [Enums.Spells.CallLightning] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.ElementalBarrier] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 350,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 30
                },

                [Enums.Spells.ElementalBlast] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.ElementalSphere] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.FeyFire] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Immolation] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.KineticBombardment] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 500,
                    TestChar = Characteristics.INT,
                    MPReq = 5,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10
                },

                [Enums.Spells.SonicBoom] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Radiance] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Evocation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                // ============================================================
                // ILLUSION
                // ============================================================

                [Enums.Spells.DoubleImage] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Invisibility] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.IllusionMinor] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.IllusionMass] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Illusion,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                // ============================================================
                // NECROMANCY
                // ============================================================

                [Enums.Spells.Curse] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 6,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10
                },

                [Enums.Spells.Enervation] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 400,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Hex] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.LifeTransfer] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.RaiseDead] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 350,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10
                },

                [Enums.Spells.RendFlesh] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Necromancy,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = -10
                },

                // ============================================================
                // RESTORATION
                // ============================================================

                [Enums.Spells.Cure] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Heal] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Regenerate] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Restoration,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                // ============================================================
                // TRANSMUTATION
                // ============================================================

                [Enums.Spells.Boost] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Crush] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.Expedite] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.FeatherFall] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.Reaction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Fly] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                [Enums.Spells.Jump] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 100,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Longstrider] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 30,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.Polymorph] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Prestidigitation] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 0,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.RapidGrowth] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 30
                },

                [Enums.Spells.Rust] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 200,
                    TestChar = Characteristics.INT,
                    MPReq = 2,
                    INTReq = 0,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.ShapeStone] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Transmutation,
                    XpCost = 250,
                    TestChar = Characteristics.INT,
                    MPReq = 3,
                    INTReq = 40,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.HalfAction,
                    CastDifficulty = 20
                },

                // ============================================================
                // UNIVERSAL
                // ============================================================

                [Enums.Spells.CircleOfTheMagi] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 300,
                    TestChar = Characteristics.INT,
                    MPReq = 4,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = 0
                },

                [Enums.Spells.Tongues] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 150,
                    TestChar = Characteristics.INT,
                    MPReq = 1,
                    INTReq = 35,
                    Range = 0,
                    NumTargets = 1,
                    CastingTime = CastingTimes.SwiftAction,
                    CastDifficulty = 10
                },

                [Enums.Spells.Wish] = new SpellDefinition
                {
                    MagicSchool = MagicSchools.Universal,
                    XpCost = 750,
                    TestChar = Characteristics.INT,
                    MPReq = 10,
                    INTReq = 50,
                    Range = 0,
                    NumTargets = 0,
                    CastingTime = CastingTimes.FullAction,
                    CastDifficulty = -10
                }
            };
    }
}