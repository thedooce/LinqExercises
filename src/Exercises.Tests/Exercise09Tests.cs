using Exercises;

namespace Exercises.Tests;

public class Exercise09Tests
{
    [Fact]
    public void FirstDivisibleBySeven_ReturnsDefaultWhenNoneFound()
    {
        var numbers = new List<int> { 10, 15, 22, 33, 41, 50 };

        var result = Exercise09.FirstDivisibleBySeven(numbers);

        Assert.Equal(0, result);
    }
}
