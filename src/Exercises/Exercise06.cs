namespace Exercises;

/// <summary>
/// Exercise 06: Finding Fruits Starting with A
/// Find all fruits in a string array that start with the letter 'A' (case-insensitive).
/// </summary>
public static class Exercise06
{
    public static IEnumerable<string> FruitsStartingWithA(string[] fruits)
    {
        //var startsWithA = fruits.Where(word => word[0] == 'a' || word[0] == 'A');
        var startsWithA = fruits.Where(fruit => fruit.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        return startsWithA;
    }
}
