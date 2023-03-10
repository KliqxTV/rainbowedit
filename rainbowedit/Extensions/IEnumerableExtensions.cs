namespace RainbowEdit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="IEnumerable{T}"/> type and derived types.
/// </summary>
public static class IEnumerableExtensions
{
    /// <summary>
    /// Returns a random item from an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to choose an item from.</param>
    /// <returns>A random item from <paramref name="source"/>.</returns>
    public static T Random<T>(this IEnumerable<T> source)
    {
        List<T> enumerated = new(source);
        return enumerated[new Random().Next(enumerated.Count)];
    }

    /// <summary>
    /// Determines whether a sequence contains a specified element by using a specified comparer function.
    /// </summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to search.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <param name="comparer">The function that compares elements and ultimately determines whether <paramref name="source"/> contains <paramref name="value"/>.</param>
    /// <returns>A value indicating whether <paramref name="source"/> contains <paramref name="value"/>.</returns>
    public static bool Contains<T>(this IEnumerable<T> source, T value, Func<T, T, bool> comparer)
    {
        foreach (T item in source)
        {
            if (comparer(item, value))
            {
                return true;
            }
        }
        return false;
    }
}
