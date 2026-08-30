using Exercises;

namespace Exercises.Tests;

public class Exercise01Tests
{
    [Fact]
    public void FilterEvenNumbers_ReturnsOnlyEvens()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = Exercise01.FilterEvenNumbers(numbers);

        Assert.Equal(new[] { 2, 4, 6, 8, 10 }, result);
    }
}
