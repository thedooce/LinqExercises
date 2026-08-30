namespace Exercises;

/// <summary>
/// Exercise 15: Finding Unique Characters
/// Given a sentence, extract a list of all unique (non-space) characters used, sorted alphabetically.
/// </summary>
public static class Exercise15
{
    public static IEnumerable<char> UniqueCharactersSorted(string sentence)
    {
        var uniqueSorted = sentence.Where(c => c != ' ')
                                    .Distinct()
                                    .OrderBy(c => c);
        return uniqueSorted;
    }
}
