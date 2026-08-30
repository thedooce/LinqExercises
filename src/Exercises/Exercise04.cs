namespace Exercises;

/// <summary>
/// Exercise 04: Finding the Top 3 Unique Numbers
/// From an array of integers, select the top 3 highest unique values.
/// </summary>
public static class Exercise04
{
    public static IEnumerable<int> TopThreeUniqueNumbers(int[] numbers)
    {
        //        var topUnique = numbers.Distinct().OrderDescending().Take(3);

        var topUnique = (from n in numbers.Distinct()
                          orderby n descending
                          select n).Take(3);
        return topUnique;
    }
}
