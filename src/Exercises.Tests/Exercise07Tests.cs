using Exercises;

namespace Exercises.Tests;

public class Exercise07Tests
{
    [Fact]
    public void FilterAgesInRange_KeepsInclusiveBounds()
    {
        var ages = new List<int> { 22, 25, 30, 35, 40, 28, 19, 33 };

        var result = Exercise07.FilterAgesInRange(ages);

        Assert.Equal(new[] { 25, 30, 35, 28, 33 }, result);
    }
}
