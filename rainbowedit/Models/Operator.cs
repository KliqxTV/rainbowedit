﻿using rainbowedit.Models;

namespace RainbowEdit;

/// <summary>
/// An <see cref="Operator"/> in Siege.
/// </summary>
public class Operator
{
    /// <summary>
    /// A series of constants containing the different movement speeds of an <see cref="Operator"/> in in-game meters per second.
    /// </summary>
    public static class OperatorSpeed
    {
        #region Speed 3 (gathered using Ash)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_PRONE = 0.763052209M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_PRONE = 0.79731431M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWCROUCH = 1.18973075M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWCROUCH = 1.24671916M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWWALK = 1.43396226M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWWALK = 1.50346192M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_CROUCH = 1.82604517M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_CROUCH = 1.9216182M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_WALK = 3.02788845M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_WALK = 3.18791946M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_RUN = 4.51843044M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_RUN = 4.72636816M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_HEAVY_PRONE = 0.655172414M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_LIGHT_PRONE = 0.689655172M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_HEAVY_SLOWCROUCH = 1.01876676M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_LIGHT_SLOWCROUCH = 1.07770845M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_HEAVY_SLOWWALK = 1.2247529M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_LIGHT_SLOWWALK = 1.29626471M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_HEAVY_CROUCH = 1.57219694M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_LIGHT_CROUCH = 1.65289256M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_HEAVY_WALK = 2.25653207M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_AIM_LIGHT_WALK = 2.38993711M;
        #endregion

        #region Speed 2 (gathered using Thermite)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_PRONE = -1M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_PRONE = -1M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWCROUCH = -1M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWCROUCH = -1M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWWALK = -1M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWWALK = -1M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_CROUCH = -1M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_CROUCH = -1M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_WALK = -1M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_WALK = -1M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_RUN = -1M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_RUN = -1M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_HEAVY_PRONE = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_LIGHT_PRONE = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_HEAVY_SLOWCROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_LIGHT_SLOWCROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_HEAVY_SLOWWALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_LIGHT_SLOWWALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_HEAVY_CROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_LIGHT_CROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_HEAVY_WALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_AIM_LIGHT_WALK = -1M;
        #endregion

        #region Speed 1 (gathered using Gridlock, who else would be better suited as a Speed 1 example)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_PRONE = -1M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_PRONE = -1M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWCROUCH = -1M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWCROUCH = -1M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWWALK = -1M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWWALK = -1M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_CROUCH = -1M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_CROUCH = -1M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_WALK = 2.34M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_WALK = -1M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_RUN = -1M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_RUN = -1M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_HEAVY_PRONE = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_LIGHT_PRONE = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_HEAVY_SLOWCROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_LIGHT_SLOWCROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_HEAVY_SLOWWALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_LIGHT_SLOWWALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_HEAVY_CROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_LIGHT_CROUCH = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_HEAVY_WALK = -1M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_AIM_LIGHT_WALK = -1M;
        #endregion
    }

    /// <summary>
    /// The nickname of the <see cref="Operator"/>.
    /// </summary>
    public string Nickname { get; private set; }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public IEnumerable<Weapon> Primaries { get; private set; }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public IEnumerable<Weapon> Secondaries { get; private set; }
    /// <summary>
    /// A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.
    /// </summary>
    public Weapon.Gadget Gadgets { get; private set; }
    /// <summary>
    /// The name of the <see cref="Operator"/>'s special ability.
    /// </summary>
    public string SpecialAbility { get; private set; }
    /// <summary>
    /// A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.
    /// </summary>
    public IEnumerable<Specialty> Specialties { get; private set; }
    /// <summary>
    /// The name of the organization the <see cref="Operator"/> belongs to.
    /// </summary>
    public string Organization { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s birthplace.
    /// </summary>
    public string Birthplace { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s height in whole and fractional centimeters.
    /// </summary>
    public decimal Height { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s weight in whole and fractional kilograms.
    /// </summary>
    public decimal Weight { get; private set; }
    /// <summary>
    /// The in-game real name of the <see cref="Operator"/>.
    /// </summary>
    public string RealName { get; private set; }
    /// <summary>
    /// An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.
    /// </summary>
    public OperatorAge Age { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s speed rating.
    /// </summary>
    public int Speed { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s health rating.
    /// </summary>
    public int Health { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s base health / HP value.
    /// </summary>
    public int HP { get; private set; }

    /// <summary>
    /// Instantiates a new <see cref="Operator"/> object.
    /// </summary>
    /// <param name="nickname">The nickname of the <see cref="Operator"/>.</param>
    /// <param name="primaries">A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="secondaries">A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="gadgets">A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.</param>
    /// <param name="specialAbility">The name of the <see cref="Operator"/>'s special ability.</param>
    /// <param name="specialties">A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.</param>
    /// <param name="organization">The name of the organization the <see cref="Operator"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Operator"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Operator"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Operator"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Operator"/>.</param>
    /// <param name="age">An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Operator"/>'s speed rating.</param>
    internal Operator(string nickname, IEnumerable<Weapon> primaries, IEnumerable<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, IEnumerable<Specialty> specialties, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed)
    {
        Nickname = nickname;
        Primaries = primaries;
        Secondaries = secondaries;
        Gadgets = gadgets;
        SpecialAbility = specialAbility;
        Specialties = specialties;
        Organization = organization;
        Birthplace = birthplace;
        Height = height;
        Weight = weight;
        RealName = realName;
        Age = age;
        Speed = speed;

        Health = 4 - Speed;
        HP = Health switch
        {
            1 => 100,
            2 => 110,
            3 => 125,
            _ => throw new ArgumentException($"Invalid 'Speed' rating '{Speed}' resulted in unexpected Health rating '{Health}' for new Operator.", nameof(speed))
        };
    }

    /// <summary>
    /// Creates a <see cref="LoadoutConfiguration"/> from all possible <see cref="Primaries"/>, <see cref="Secondaries"/> (and those two's respective <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> options) and <see cref="Gadgets"/> loadout combinations.
    /// </summary>
    /// <returns>A <see cref="LoadoutConfiguration"/> as described.</returns>
    public LoadoutConfiguration GetRandomLoadout() => new(this);

    /// <inheritdoc/>
    public override string ToString() => Nickname.PadRight(Siege.LongestOperatorNickname.Length + 4);
    /// <inheritdoc/>
    public static implicit operator string(Operator op) => op.ToString();
}
