using Exercises;

namespace Exercises.Tests;

public class Exercise35Tests
{
    [Fact]
    public void FindCommonNumbers_ReturnsIntersection()
    {
        var listA = new List<int> { 1, 2, 3, 4, 5, 6 };
        var listB = new List<int> { 4, 5, 6, 7, 8, 9 };

        var result = Exercise35.FindCommonNumbers(listA, listB);

        Assert.Equal(new[] { 4, 5, 6 }, result);
    }
}
