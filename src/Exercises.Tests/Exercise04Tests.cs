using Exercises;

namespace Exercises.Tests;

public class Exercise04Tests
{
    [Fact]
    public void TopThreeUniqueNumbers_ReturnsThreeHighestDistinctValues()
    {
        var numbers = new int[] { 50, 20, 50, 80, 80, 10, 30, 90 };

        var result = Exercise04.TopThreeUniqueNumbers(numbers);

        Assert.Equal(new[] { 90, 80, 50 }, result);
    }
}
