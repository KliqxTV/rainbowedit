using rainbowedit.Models;

namespace RainbowEdit;

/// <summary>
/// The <see cref="Attackers"/> in Siege.
/// </summary>
public sealed partial class Attackers : IEnumerable<Operator>, IEnumerator<Operator>
{
    static Attackers()
    {
        _operators = new()
        {
            Sledge,
            Thatcher,
            Ash,
            Thermite,
            Twitch,
            Montagne,
            Glaz,
            Fuze,
            Blitz,
            IQ,
            Buck,
            Blackbeard,
            Capitao,
            Hibana,
            Jackal,
            Ying,
            Zofia,
            Dokkaebi,
            Lion,
            Finka,
            Maverick,
            Nomad,
            Gridlock,
            Nokk,
            Amaru,
            Kali,
            Iana,
            Ace,
            Zero,
            Flores,
            Osa,
            Sens,
            Grim,
            Brava
        };

        // Needed because even though every Weapon object is instantiated using a reference to the containing Operator instance, at the time of instantiation, those Operator references are null
        foreach (Operator op in _operators)
        {
            foreach (Weapon wep in op.Primaries.Concat(op.Secondaries))
            {
                wep.Source = op;
            }
        }

        // Same as above
        Breach.Reward = Hibana;
        Support.Reward = Montagne;
        FrontLine.Reward = Ash;
        Intel.Reward = Twitch;
        AntiGadget.Reward = Fuze;
        MapControl.Reward = Lion;
    }

    #region Specialties
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Breach"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty Breach = new(
        "Breach",
        Hibana,
        new()
        {
            new("Destroy 5 barricades or hatches.", "Renown 250"),
            new("Breach 2 reinforced surfaces.", "3-Days Renown Booster 1x"),
            new("Score 125 points by breaching reinforced surfaces.", "Beginner Pack 3x")
        }
    );
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Support"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty Support = new(
        "Support",
        Montagne,
        new()
        {
            new("Play 1 times as a Support Attacker.", "Beginner Pack 1x"),
            new("Revive 5 teammates.", "Beginner Pack 2x"),
            new("Win by defusing bombs 1 times.", "Beginner Pack 3x")
        }
    );
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="FrontLine"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty FrontLine = new(
        "Front-Line",
        Ash,
        new()
        {
            new("Get 5 eliminations or assists.", "Beginner Pack 1x"),
            new("Blind 2 opponents.", "Renown 500"),
            new("Eliminate 5 opponents with explosives as an Attacker.", "7-Days Renown Booster 1x")
        }
    );
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Intel"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty Intel = new(
        "Intel",
        Twitch,
        new()
        {
            new("Scan and identify 7 Defenders as an Attacker.", "1-Day Renown Booster 1x"),
            new("Find the bomb as an Attacker 1 times without your drone being destroyed during the Preparation Phase.", "1-Day Battle Point Booster 2x"),
            new("Get 5 Opponents Scan Assists.", "Renown 750")
        }
    );
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="AntiGadget"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty AntiGadget = new(
        "Anti-Gadget",
        Fuze,
        new()
        {
            new("Destroy 5 trap devices as an Attacker.", "1-Day Battle Point Booster 1x"),
            new("Destroy 5 Observation Tools as an Attacker.", "1-Day Battle Point Booster 2x"),
            new("Deactivate 2 electronic devices as an Attacker.", "1-Day Battle Point Booster 3x")
        }
    );
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="MapControl"/> <see cref="Specialty"/>.
    /// </summary>
    public static readonly Specialty MapControl = new(
        "Map Control",
        Lion,
        new()
        {
            new("Walk or sprint 500 meters as an Attacker.", "Renown 250"),
            new("Get 5 headshots.", "3-Days Renown Booster 1x"),
            new("Eliminate 2 opponents through breakable surfaces.", "1-Day Battle Point Booster 3x")
        }
    );
    #endregion

#pragma warning disable CS8604 // Possible null reference argument.

    #region Attacker instances
    /// <summary>
    /// The <see cref="Operator"/> <see cref="Sledge"/>.
    /// </summary>
    public static readonly Operator Sledge = new(
        "Sledge",
        new List<Weapon>()
        {
            new(
                Sledge,
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4030,
                4510
            ),
            new(
                Sledge,
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            )
        },
        new List<Weapon>()
        {
            new(
                Sledge,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Tactical Breaching Hammer \"The Caber\"",
        new List<Specialty>()
        {
            Breach,
            AntiGadget
        },
        "SAS",
        "John O'Groats, Scotland",
        192,
        95,
        "Seamus Cowden",
        new(2, 4, 35),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thatcher"/>.
    /// </summary>
    public static readonly Operator Thatcher = new(
        "Thatcher",
        new List<Weapon>()
        {
            new(
                Thatcher,
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new(
                Thatcher,
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            ),
            new(
                Thatcher,
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4030,
                4510
            )
        },
        new List<Weapon>()
        {
            new(
                Thatcher,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "EG Mk 0-EMP Grenade",
        new List<Specialty>()
        {
            AntiGadget,
            Support
        },
        "SAS",
        "Bideford, England",
        180,
        72,
        "Mike Baker",
        new(22, 6, 56),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ash"/>.
    /// </summary>
    public static readonly Operator Ash = new(
        "Ash",
        new List<Weapon>()
        {
            new(
                Ash,
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            ),
            new(
                Ash,
                "R4-C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                39,
                860,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2200
            )
        },
        new List<Weapon>()
        {
            new(
                Ash,
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1100,
                1300
            ),
            new(
                Ash,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "M120 CREM Breaching Rounds",
        new List<Specialty>()
        {
            Breach,
            FrontLine
        },
        "FBI SWAT",
        "Jerusalem, Israel",
        170,
        63,
        "Eliza Cohen",
        new(24, 12, 33),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thermite"/>.
    /// </summary>
    public static readonly Operator Thermite = new(
        "Thermite",
        new List<Weapon>()
        {
            new(
                Thermite,
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4450,
                5330
            ),
            new(
                Thermite,
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            )
        },
        new List<Weapon>()
        {
            new(
                Thermite,
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1100,
                1300
            ),
            new(
                Thermite,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
        "Brimstone BC-3 Exothermic Charges",
        new List<Specialty>()
        {
            Breach,
            Support
        },
        "FBI SWAT",
        "Plano, Texas",
        178,
        80,
        "Jordan Trace",
        new(14, 3, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Twitch"/>.
    /// </summary>
    public static readonly Operator Twitch = new(
        "Twitch",
        new List<Weapon>()
        {
            new(
                Twitch,
                "F2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                37,
                980,
                25,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1420,
                2320
            ),
            new(
                Twitch,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new(
                Twitch,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        },
        new List<Weapon>()
        {
            new(
                Twitch,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            ),
            new(
                Twitch,
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "RSD Model 1 - Shock Drone",
        new List<Specialty>()
        {
            AntiGadget,
            Intel
        },
        "GIGN",
        "Nancy, France",
        168,
        58,
        "Emmanuelle Pichon",
        new(12, 10, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Montagne"/>.
    /// </summary>
    public static readonly Operator Montagne = new(
        "Montagne",
        new List<Weapon>()
        {
            new(
                Montagne,
                "Le Roc",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        new List<Weapon>()
        {
            new(
                Montagne,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            ),
            new(
                Montagne,
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade | Weapon.Gadget.EmpGrenade,
        "Extendable Shield \"Le Roc\"",
        new List<Specialty>()
        {
            Intel,
            Support
        },
        "GIGN",
        "Bordeaux, France",
        190,
        90,
        "Gilles Touré",
        new(11, 10, 48),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Glaz"/>.
    /// </summary>
    public static readonly Operator Glaz = new(
        "Glaz",
        new List<Weapon>()
        {
            new(
                Glaz,
                "OTs-03",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                71,
                360,
                10,
                Weapon.Sight.Four,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1430,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Glaz,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                Glaz,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Glaz,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.FragGrenade | Weapon.Gadget.Claymore,
        "HDS Flip Sight OTs-03 MARKSMAN Rifle",
        new List<Specialty>()
        {
            Intel,
            Support
        },
        "SPETSNAZ",
        "Vladivostok, Russia",
        178,
        79,
        "Timur Glazkov",
        new(2, 7, 30),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Fuze"/>.
    /// </summary>
    public static readonly Operator Fuze = new(
        "Fuze",
        new List<Weapon>()
        {
            new(
                Fuze,
                "Ballistic Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Fuze,
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new(
                Fuze,
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            )
        },
        new List<Weapon>()
        {
            new(
                Fuze,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                Fuze,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "APM-6 Cluster Charge \"Matryoshka\"",
        new List<Specialty>()
        {
            AntiGadget
        },
        "SPETSNAZ",
        "Samarkand, Uzbekistan",
        180,
        80,
        "Shuhrat Kessikbayev",
        new(12, 10, 34),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Blitz"/>.
    /// </summary>
    public static readonly Operator Blitz = new(
        "Blitz",
        new List<Weapon>()
        {
            new(
                Blitz,
                "G52-Tactical Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        new List<Weapon>()
        {
            new(
                Blitz,
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1230,
                1560
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge,
        "G52-Tactical Light Shield",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "GSG 9",
        "Bremen, Germany",
        175,
        75,
        "Elias Kötz",
        new(2, 4, 37),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="IQ"/>.
    /// </summary>
    public static readonly Operator IQ = new(
        "IQ",
        new List<Weapon>()
        {
            new(
                IQ,
                "AUG A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                720,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1470,
                2340
            ),
            new(
                IQ,
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new(
                IQ,
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            )
        },
        new List<Weapon>()
        {
            new(
                IQ,
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1230,
                1560
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "Electronics Detector RED Mk III \"Spectre\"",
        new List<Specialty>()
        {
            Intel,
            Support
        },
        "GSG 9",
        "Leipzig, Germany",
        175,
        70,
        "Monika Weiss",
        new(1, 8, 38),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Buck"/>.
    /// </summary>
    public static readonly Operator Buck = new(
        "Buck",
        new List<Weapon>()
        {
            new(
                Buck,
                "C8-SFW",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                837,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1370,
                1540
            ),
            new(
                Buck,
                "CAMRS",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1460,
                2290
            )
        },
        new List<Weapon>()
        {
            new(
                Buck,
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1110,
                1320
            ),
            new(
                Buck,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.HardBreachCharge,
        "Skeleton Key SK 4-12",
        new List<Specialty>()
        {
            Breach,
            Support
        },
        "JTF2",
        "Montréal, Quebec",
        178,
        78,
        "Sebastien Côté",
        new(20, 8, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Blackbeard"/>.
    /// </summary>
    public static readonly Operator Blackbeard = new(
        "Blackbeard",
        new List<Weapon>()
        {
            new(
                Blackbeard,
                "MK17 CQB",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                49,
                585,
                20,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2230
            ),
            new(
                Blackbeard,
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                Blackbeard,
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1450
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "TARS Mk 0-Transparent Armored Rifle Shield",
        new List<Specialty>()
        {
            Support
        },
        "NAVY SEAL",
        "Bellevue, Washington",
        180,
        84,
        "Craig Jenson",
        new(12, 2, 32),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Capitao"/>.
    /// </summary>
    public static readonly Operator Capitao = new(
        "Capitão",
        new List<Weapon>()
        {
            new(
                Capitao,
                "PARA-308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                650,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2000,
                2300
            ),
            new(
                Capitao,
                "M249",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                100,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6320,
                6320
            )
        },
        new List<Weapon>()
        {
            new(
                Capitao,
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1590
            ),
            new(
                Capitao,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.HardBreachCharge,
        "Tactical Crossbow TAC Mk0",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "BOPE",
        "Nova Iguaçu, Brazil",
        183,
        86,
        "Vicente Souza",
        new(17, 11, 49),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Hibana"/>.
    /// </summary>
    public static readonly Operator Hibana = new(
        "Hibana",
        new List<Weapon>()
        {
            new(
                Hibana,
                "TYPE-89",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                20,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1340,
                2320
            ),
            new(
                Hibana,
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                4080,
                4560
            )
        },
        new List<Weapon>()
        {
            new(
                Hibana,
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1450
            ),
            new(
                Hibana,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "X-KAIROS Grenade Launcher",
        new List<Specialty>()
        {
            Breach,
            FrontLine
        },
        "SAT",
        "Tokyo, Japan (Suginami-ki)",
        173,
        57,
        "Yumiko Imagawa",
        new(12, 7, 34),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Jackal"/>.
    /// </summary>
    public static readonly Operator Jackal = new(
        "Jackal",
        new List<Weapon>()
        {
            new(
                Jackal,
                "C7E",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                46,
                800,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1140,
                2010
            ),
            new(
                Jackal,
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new(
                Jackal,
                "ITA12L",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                50,
                85,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                5440,
                7190
            )
        },
        new List<Weapon>()
        {
            new(
                Jackal,
                "USP40",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1250,
                1410
            ),
            new(
                Jackal,
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3200,
                4580
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "Eyenox Model III",
        new List<Specialty>()
        {
            Intel,
            MapControl
        },
        "GEO",
        "Ceuta, Spain",
        190,
        78,
        "Ryad Ramírez Al-Hassar",
        new(1, 3, 49),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ying"/>.
    /// </summary>
    public static readonly Operator Ying = new(
        "Ying",
        new List<Weapon>()
        {
            new(
                Ying,
                "T-95 LSW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                650,
                80,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1300,
                2180
            ),
            new(
                Ying,
                "SIX12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1400,
                1400
            )
        },
        new List<Weapon>()
        {
            new(
                Ying,
                "Q-929",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                60,
                550,
                10,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1140,
                1440
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "Candela Cluster Charges",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "SDU",
        "Hong Kong, Central",
        160,
        52,
        "Siu Mei Lin",
        new(12, 5, 33),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Zofia"/>.
    /// </summary>
    public static readonly Operator Zofia = new(
        "Zofia",
        new List<Weapon>()
        {
            new(
                Zofia,
                "LMG-E",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                41,
                720,
                150,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6180,
                5430
            ),
            new(
                Zofia,
                "M762",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                730,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2350
            )
        },
        new List<Weapon>()
        {
            new(
                Zofia,
                "RG15",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                38,
                550,
                15,
                Weapon.Sight.NonMagnifying | Weapon.Sight.Other,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1200,
                1370
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "KS79 Lifeline",
        new List<Specialty>()
        {
            Breach,
            AntiGadget
        },
        "GROM",
        "Wrocław, Poland",
        179,
        72,
        "Zofia Bosak",
        new(28, 1, 36),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Dokkaebi"/>.
    /// </summary>
    public static readonly Operator Dokkaebi = new(
        "Dokkaebi",
        new List<Weapon>()
        {
            new(
                Dokkaebi,
                "Mk 14 EBR",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                60,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new(
                Dokkaebi,
                "BOSG.12.2",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                125,
                500,
                2,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1160,
                1430
            )
        },
        new List<Weapon>()
        {
            new(
                Dokkaebi,
                "SMG-12",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                28,
                1270,
                32,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2300
            ),
            new(
                Dokkaebi,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Dokkaebi,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                1320,
                2220
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Logic Bomb",
        new List<Specialty>()
        {
            Intel,
            MapControl
        },
        "707th SMB",
        "Seoul, South Korea",
        180,
        70,
        "Grace Nam",
        new(2, 2, 29),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Lion"/>.
    /// </summary>
    public static readonly Operator Lion = new(
        "Lion",
        new List<Weapon>()
        {
            new(
                Lion,
                "V308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                700,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1550,
                2330
            ),
            new(
                Lion,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new(
                Lion,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        },
        new List<Weapon>()
        {
            new(
                Lion,
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            ),
            new(
                Lion,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0),
            new(
                Lion,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade,
        "EE-ONE-D Scanning Drone",
        new List<Specialty>()
        {
            Intel,
            MapControl
        },
        "CBRN THREAT UNIT",
        "Toulouse, France",
        185,
        87,
        "Olivier Flament",
        new(29, 8, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Finka"/>.
    /// </summary>
    public static readonly Operator Finka = new(
        "Finka",
        new List<Weapon>()
        {
            new(
                Finka,
                "Spear .308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                700,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1510,
                2460
            ),
            new(
                Finka,
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new(
                Finka,
                "SASG-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                50,
                330,
                10,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1520,
                2180
            )
        },
        new List<Weapon>()
        {
            new(
                Finka,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                Finka,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Finka,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
        "Adrenal Surge",
        new List<Specialty>()
        {
            FrontLine,
            Support
        },
        "CBRN THREAT UNIT",
        "Gomel, Belarus",
        171,
        68,
        "Lera Melnikova",
        new(7, 6, 27),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Maverick"/>.
    /// </summary>
    public static readonly Operator Maverick = new(
        "Maverick",
        new List<Weapon>()
        {
            new(
                Maverick,
                "AR-15.50",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                67,
                450,
                10,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2120
            ),
            new(
                Maverick,
                "M4",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                750,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1530,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                Maverick,
                "1911 TACOPS",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                55,
                450,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1240,
                1440
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore,
        "Breaching Torch",
        new List<Specialty>()
        {
            Breach,
            FrontLine
        },
        "GSUTR",
        "Boston, Massachusetts",
        180,
        82,
        "Erik Thorn",
        new(20, 4, 36),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Nomad"/>.
    /// </summary>
    public static readonly Operator Nomad = new(
        "Nomad",
        new List<Weapon>()
        {
            new(
                Nomad,
                "AK-74M",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                650,
                40,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1430,
                2440
            ),
            new(
                Nomad,
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            )
        },
        new List<Weapon>()
        {
            new(
                Nomad,
                ".44 Mag Semi-Auto",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                54,
                450,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                Nomad,
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1590
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "Airjab Launcher",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "GIGR",
        "Marrakesh, Morocco",
        171,
        63,
        "Sanaa El Maktoub",
        new(27, 7, 39),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Gridlock"/>.
    /// </summary>
    public static readonly Operator Gridlock = new(
        "Gridlock",
        new List<Weapon>()
        {
            new(
                Gridlock,
                "F90",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2290
            ),
            new(
                Gridlock,
                "M249 SAW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                60,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2030,
                3560
            )
        },
        new List<Weapon>()
        {
            new(
                Gridlock,
                "Super Shorty",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                85,
                3,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1300,
                2450
            ),
            new(
                Gridlock,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Gridlock,
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1050,
                1450
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge | Weapon.Gadget.EmpGrenade,
        "Trax Stingers",
        new List<Specialty>()
        {
            Support,
            MapControl
        },
        "SASR",
        "Longreach, Central Queensland, Australia",
        177,
        102,
        "Tori Tallyo Fairous",
        new(5, 8, 36),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Nokk"/>.
    /// </summary>
    public static readonly Operator Nokk = new(
        "Nøkk",
        new List<Weapon>()
        {
            new(
                Nokk,
                "FMG-9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1420,
                2210
            ),
            new(
                Nokk,
                "SIX12 SD",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1400,
                1400
            )
        },
        new List<Weapon>()
        {
            new(
                Nokk,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            ),
            new(
                Nokk,
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1450
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.EmpGrenade,
        "HEL Presence Reduction",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "JAEGER CORPS",
        "[REDACTED]",
        -1M,
        -1M,
        "[REDACTED]",
        OperatorAge.Redacted,
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Amaru"/>.
    /// </summary>
    public static readonly Operator Amaru = new(
        "Amaru",
        new List<Weapon>()
        {
            new(
                Amaru,
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            ),
            new(
                Amaru,
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                4080,
                4560
            )
        },
        new List<Weapon>()
        {
            new(
                Amaru,
                "SMG-11",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1270,
                16,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1270,
                2130
            ),
            new(
                Amaru,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                Amaru,
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3200,
                4580
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.StunGrenade,
        "Garra Hook",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "APCA",
        "Cojata, Peru",
        189,
        84,
        "Azucena Rocío Quispe",
        new(6, 5, 48),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kali"/>.
    /// </summary>
    public static readonly Operator Kali = new(
        "Kali",
        new List<Weapon>()
        {
            new(
                Kali,
                "CSRX 300",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                135,
                50,
                5,
                Weapon.Sight.FiveTwelve,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                1500,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Kali,
                "SPSMG9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                980,
                20,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1350,
                1590
            ),
            new(
                Kali,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                1320,
                2220
            ),
            new(
                Kali,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.BreachCharge,
        "Low Velocity (LV) Explosive Lance",
        new List<Specialty>()
        {
            AntiGadget,
            Support
        },
        "NIGHTHAVEN",
        "Amreli, India",
        170,
        67,
        "Jaimini Kalimohan Shah",
        new(21, 8, 34),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Iana"/>.
    /// </summary>
    public static readonly Operator Iana = new(
        "Iana",
        new List<Weapon>()
        {
            new(
                Iana,
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            ),
            new(
                Iana,
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            )
        },
        new List<Weapon>()
        {
            new(
                Iana,
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1110,
                1320
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.SmokeGrenade,
        "Gemini Replicator",
        new List<Specialty>()
        {
            FrontLine,
            Intel
        },
        "REU",
        "Katwijk, Netherlands",
        157,
        56,
        "Nienke Meijer",
        new(27, 8, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ace"/>.
    /// </summary>
    public static readonly Operator Ace = new(
        "Ace",
        new List<Weapon>()
        {
            new(
                Ace,
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            ),
            new(
                Ace,
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4450,
                5330
            )
        },
        new List<Weapon>()
        {
            new(
                Ace,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "S.E.L.M.A. Aqua Breacher",
        new List<Specialty>()
        {
            Breach,
            AntiGadget
        },
        "NIGHTHAVEN",
        "Lærdalsøyri, Norway",
        187,
        75,
        "Håvard Haugland",
        new(15, 3, 33),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Zero"/>.
    /// </summary>
    public static readonly Operator Zero = new(
        "Zero",
        new List<Weapon>()
        {
            new(
                Zero,
                "SC3000K",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                850,
                25,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1520,
                2470
            ),
            new(
                Zero,
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1320,
                2250
            )
        },
        new List<Weapon>()
        {
            new(
                Zero,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                35,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1260,
                1490
            ),
            new(
                Zero,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "ARGUS Launcher",
        new List<Specialty>()
        {
            AntiGadget,
            Intel
        },
        "ROS",
        "Baltimore, Maryland",
        178,
        77,
        "Samuel Leo Fisher",
        new(8, 8, 63),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Flores"/>.
    /// </summary>
    public static readonly Operator Flores = new(
        "Flores",
        new List<Weapon>()
        {
            new(
                Flores,
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new(
                Flores,
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                Flores,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore,
        "RCE-Ratero Charge",
        new List<Specialty>()
        {
            AntiGadget,
            Intel
        },
        "UNAFFILIATED",
        "Buenos Aires, Argentina",
        181,
        72,
        "Santiago Miguel Lucero",
        new(2, 10, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Osa"/>.
    /// </summary>
    public static readonly Operator Osa = new(
        "Osa",
        new List<Weapon>()
        {
            new(
                Osa,
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            ),
            new(
                Osa,
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Osa,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade,
        "Talon-8 Clear Shield",
        new List<Specialty>()
        {
            Intel,
            Support
        },
        "NIGHTHAVEN",
        "Split, Croatia",
        180,
        71,
        "Anja Katarina Janković",
        new(29, 4, 27),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Sens"/>.
    /// </summary>
    public static readonly Operator Sens = new(
        "Sens",
        new List<Weapon>()
        {
            new(
                Sens,
                "POF-9",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                35,
                740,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1470,
                2240
            ),
            new(
                Sens,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1350,
                2190
            )
        },
        new List<Weapon>()
        {
            new(
                Sens,
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1050,
                1450
            ),
            new(
                Sens,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "R.O.U. Projector System",
        new List<Specialty>()
        {
            Support,
            MapControl
        },
        "SFG",
        "Brussels, Belgium",
        178,
        73,
        "Néon Ngoma Mutombo",
        new(3, 3, 30),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Grim"/>.
    /// </summary>
    public static readonly Operator Grim = new(
        "Grim",
        new List<Weapon>()
        {
            new(
                Grim,
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new(
                Grim,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        },
        new List<Weapon>()
        {
            new(
                Grim,
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1450
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "Kawan Hive Launcher",
        new List<Specialty>()
        {
            FrontLine,
            MapControl
        },
        "NIGHTHAVEN",
        "Jurong, Singapore",
        179,
        89.8M,
        "Charlie Tho Keng Boon",
        new(5, 4, 39),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Brava"/>.
    /// </summary>
    public static readonly Operator Brava = new(
        "Brava",
        new List<Weapon>()
        {
            new(
                Brava,
                "PARA-308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                650,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2000,
                2300
            ),
            new(
                Brava,
                "CAMRS",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2290
            )
        },
        new List<Weapon>()
        {
            new(
                Brava,
                "Super Shorty",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                85,
                3,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1300,
                2450
            ),
            new(
                Brava,
                "USP40",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1250,
                1410
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.Claymore,
        "Kludge Drone",
        new List<Specialty>()
        {
            AntiGadget,
            Intel
        },
        "COT",
        "Curitiba, Brazil",
        170,
        71M,
        "Nayara Cardoso",
        new(10, 1, 40),
        3
    );
    #endregion

#pragma warning restore CS8604 // Possible null reference argument.

    /// <summary>
    /// Compiles specific challenges from all <see cref="Attackers"/>' specialties into a collection.
    /// </summary>
    /// <param name="breach">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Breach" /> <see cref="Specialty" />.</param>
    /// <param name="support">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Support" /> <see cref="Specialty" />.</param>
    /// <param name="frontline">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="FrontLine" /> <see cref="Specialty" />.</param>
    /// <param name="intel">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Intel" /> <see cref="Specialty" />.</param>
    /// <param name="antigadget">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AntiGadget" /> <see cref="Specialty" />.</param>
    /// <param name="mapcontrol">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="MapControl" /> <see cref="Specialty" />.</param>
    /// <returns>A</returns>
    public static Dictionary<Specialty, string> GetPersonalSpecialtyChallengeSet(int breach, int support, int frontline, int intel, int antigadget, int mapcontrol)
    {
        Dictionary<Specialty, string> challenges = new();

        if (breach is >= 1 and <= 3)
        {
            challenges.Add(Breach, $"{Breach.Name,-13} -> {Breach.Challenges[breach - 1].Description}");
        }
        if (support is >= 1 and <= 3)
        {
            challenges.Add(Support, $"{Support.Name,-13} -> {Support.Challenges[support - 1].Description}");
        }
        if (frontline is >= 1 and <= 3)
        {
            challenges.Add(FrontLine, $"{FrontLine.Name,-13} -> {FrontLine.Challenges[frontline - 1].Description}");
        }
        if (intel is >= 1 and <= 3)
        {
            challenges.Add(Intel, $"{Intel.Name,-13} -> {Intel.Challenges[intel - 1].Description}");
        }
        if (antigadget is >= 1 and <= 3)
        {
            challenges.Add(AntiGadget, $"{AntiGadget.Name,-13} -> {AntiGadget.Challenges[antigadget - 1].Description}");
        }
        if (mapcontrol is >= 1 and <= 3)
        {
            challenges.Add(MapControl, $"{MapControl.Name,-13} -> {MapControl.Challenges[mapcontrol - 1].Description}");
        }

        return challenges;
    }
}
