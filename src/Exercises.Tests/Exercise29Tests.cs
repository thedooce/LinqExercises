using Exercises;

namespace Exercises.Tests;

public class Exercise29Tests
{
    [Fact]
    public void ProductOfNonZero_IgnoresZeroesInTheProduct()
    {
        var numbers = new int[] { 2, 0, 3, 4, 0, 5 };

        var result = Exercise29.ProductOfNonZero(numbers);

        Assert.Equal(120, result);
    }
}
