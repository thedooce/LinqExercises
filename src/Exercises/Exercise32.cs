using System.ComponentModel.DataAnnotations;

namespace Exercises;

/// <summary>
/// Exercise 32: Counting Words by Length
/// Group a list of words by their length, and return the length along with the count of
/// words that match that length, ordered by count descending.
/// </summary>
public static class Exercise32
{
    public static IEnumerable<(int Length, int Count)> CountWordsByLength(List<string> words)
    {
        var groupedByLength = words.GroupBy( word => word.Length)
                                    .Select (group => (Length: group.Key, Count: group.Count()))
                                    .OrderByDescending(group => group.Count);

        return groupedByLength;
    }
}
