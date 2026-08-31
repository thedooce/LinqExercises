namespace Exercises;

/// <summary>
/// Exercise 38: Finding the Most Frequent Number
/// Find the most frequently occurring integer in an array.
/// </summary>
public static class Exercise38
{
    public static int MostFrequentNumber(int[] numbers)
    {
        var stuff = numbers.GroupBy(number => number).MaxBy(group => group.Count()).Key;
                    
        return stuff;
    }
}
