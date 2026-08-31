namespace Exercises;

/// <summary>
/// Exercise 24: Counting Matching Elements
/// Count how many elements in a list of strings contain the word "LINQ".
/// </summary>
public static class Exercise24
{
    public static int CountContainingLinq(List<string> sentences)
    {
        var count = sentences.Count(sentence => sentence.Contains("LINQ"));
        return count;
    }
}
