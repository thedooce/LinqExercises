namespace Exercises;

/// <summary>
/// Exercise 02: Finding Long Words
/// Given a list of words, find all words that have more than 5 characters.
/// </summary>
public static class Exercise02
{
    public static IEnumerable<string> FindLongWords(List<string> words)
    {
        // TODO: implement
        //var longWords = words.Where( word => word.Length > 5);
        var longWords = from word in words
                        where word.Length > 5
                        select word;
        return longWords;
    }
}
