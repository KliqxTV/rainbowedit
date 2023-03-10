using RainbowEdit.Exceptions;
using RainbowEdit.Extensions;

namespace RainbowEdit;

/// <summary>
/// A single weapon configuration from all possible <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> combinations.
/// </summary>
public class WeaponConfiguration
{
    ///<summary>
    /// The <see cref="Weapon"/> this configuration applies to.
    ///</summary>
    public Weapon Source { get; private set; }
    /// <summary>
    /// A string detailing the sight to use.
    /// </summary>
    public string Sight { get; private set; }
    /// <summary>
    /// A string detailing the barrel attachment to use.
    /// </summary>
    public string Barrel { get; private set; }
    /// <summary>
    /// A string detailing the grip to use.
    /// </summary>
    public string Grip { get; private set; }
    /// <summary>
    /// Whether to use an underbarrel laser.
    /// </summary>
    public bool Underbarrel { get; private set; }

    /// <summary>
    /// Instantiates a new <see cref="WeaponConfiguration"/> object from just a <see cref="Weapon"/> to gather values from.
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to gather random values for this <see cref="WeaponConfiguration"/> instance's properties from.</param>
    public WeaponConfiguration(Weapon source)
    {
        Source = source;

        Random ran = new();

        List<Weapon.Sight> possibleSights = Source.Sights.GetSetFlags();
        List<Weapon.Barrel> possibleBarrels = Source.Barrels.GetSetFlags();
        List<Weapon.Grip> possibleGrips = Source.Grips.GetSetFlags();

        if (possibleSights.Any())
        {
            Weapon.Sight sight = possibleSights.Random();
            Sight = sight switch
            {
                Weapon.Sight.NonMagnifying => new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" }.Random(),
                Weapon.Sight.TwoPointFive => new List<string>() { "2.5x A", "2.5x B" }.Random(),
                _ => sight.Stringify()
            };
        }
        else
        {
            Sight = Weapon.Sight.Invalid.Stringify();
        }

        if (possibleBarrels.Any())
        {
            Barrel = possibleBarrels.Random().Stringify();
        }
        else
        {
            Barrel = Weapon.Barrel.None.Stringify();
        }

        if (possibleGrips.Any())
        {
            Grip = possibleGrips.Random().Stringify();
        }
        else
        {
            Grip = Weapon.Grip.None.Stringify();
        }

        if (Source.Underbarrel)
        {
            Underbarrel = ran.Next(2) == 0;
        }
    }

    /// <summary>
    /// Instantiates a new <see cref="WeaponConfiguration"/> object from and one each of their <see cref="Weapon.Sight"/>s, <see cref="Weapon.Barrel"/>s and <see cref="Weapon.Grip"/>s and a value indicating whether to use a <see cref="Weapon.Underbarrel"/> laser.
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to gather random values for this <see cref="WeaponConfiguration"/> instance's properties from.</param>
    /// <param name="sight">A <see cref="Weapon.Sight"/> enum value detailing the sight to use. If this is <see cref="Weapon.Sight.NonMagnifying"/> or <see cref="Weapon.Sight.TwoPointFive"/>, a random one of its variants is chosen.</param>
    /// <param name="barrel">A <see cref="Weapon.Barrel"/> enum value detailing the barrel attachment to use.</param>
    /// <param name="grip">A <see cref="Weapon.Grip"/> enum value detailing the grip to use.</param>
    /// <param name="underbarrel">Whether to use an underbarrel laser.</param>
    public WeaponConfiguration(Weapon source, Weapon.Sight sight, Weapon.Barrel barrel, Weapon.Grip grip, bool underbarrel)
    {
        Source = source;
        Barrel = barrel.Stringify();
        Grip = grip.Stringify();
        Underbarrel = underbarrel;

        Sight = sight switch
        {
            Weapon.Sight.NonMagnifying => new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" }.Random(),
            Weapon.Sight.TwoPointFive => new List<string>() { "2.5x A", "2.5x B" }.Random(),
            _ => sight.Stringify()
        };
    }

    /// <summary>
    /// <para>
    /// Instantiates a new fully customized <see cref="WeaponConfiguration"/> object from a <see cref="Weapon"/> and string representations of one each of their <see cref="Weapon.Sight"/>s, <see cref="Weapon.Barrel"/>s and <see cref="Weapon.Grip"/>s and a value indicating whether to use a <see cref="Weapon.Underbarrel"/> laser.
    /// </para>
    /// <para>
    /// An <see cref="EnumStringificationException{TEnum}"/> is thrown if one of the strings passed does not match any possible string representations for that enum.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to assign to this <see cref="WeaponConfiguration"/> instance.</param>
    /// <param name="sight">A string detailing the sight to use. This must match one of the string representations returned by <see cref="EnumExtensions.Stringify(Weapon.Sight)" /> OR one of the sub-sight names for <see cref="Weapon.Sight.NonMagnifying"/> or <see cref="Weapon.Sight.TwoPointFive"/>.</param>
    /// <param name="barrel">A string detailing the barrel attachment to use. This must match one of the string representations returned by <see cref="EnumExtensions.Stringify(Weapon.Barrel)" />.</param>
    /// <param name="grip">A string detailing the grip to use. This must match one of the string representations returned by <see cref="EnumExtensions.Stringify(Weapon.Grip)" />.</param>
    /// <param name="underbarrel">Whether to use an underbarrel laser.</param>
    /// <exception cref="EnumStringificationException{TEnum}">Thrown if one of the strings passed does not match any possible string representations for that enum.</exception>
    public WeaponConfiguration(Weapon source, string sight, string barrel, string grip, bool underbarrel)
    {
        Source = source;
        Underbarrel = underbarrel;

        if (!Enum.GetValues<Weapon.Barrel>().Select(@enum => @enum.Stringify()).Contains(barrel))
        {
            throw new EnumStringificationException<Weapon.Barrel>(barrel);
        }
        else
        {
            Barrel = barrel;
        }
        
        if (!Enum.GetValues<Weapon.Grip>().Select(@enum => @enum.Stringify()).Contains(grip))
        {
            throw new EnumStringificationException<Weapon.Grip>(grip);
        }
        else
        {
            Grip = grip;
        }
        
        if (!Enum.GetValues<Weapon.Sight>()
                 .Select(@enum => @enum.Stringify())
                 .Concat(new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" })
                 .Concat(new List<string>() { "2.5x A", "2.5x B" }
            ).Contains(sight)
        )
        {
            throw new EnumStringificationException<Weapon.Sight>(sight);
        }
        else
        {
            Sight = sight;
        }
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (!Source.IsSecondary)
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type.Stringify()}
                Sight: {Sight}
                Barrel: {Barrel}
                Grip: {Grip}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
        else
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type.Stringify()}
                Sight: {(Source.Sights.HasFlag(Weapon.Sight.Other) ? "\u2014" : Sight)}
                Barrel: {Barrel}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
    }
}
