using System.Globalization;

namespace Exercises;

/// <summary>
/// Exercise 01: Filtering Even Numbers
/// Given a list of integers, return only the even numbers.
/// </summary>
public static class Exercise01
{
    public static IEnumerable<int> FilterEvenNumbers(List<int> numbers)
    {
        //var evens = numbers.Where(x => x%2 == 0);
        var evens = from num in numbers
                    where num % 2 == 0
                    select num;
        return evens;
    }
}
