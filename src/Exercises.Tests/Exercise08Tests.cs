using Exercises;

namespace Exercises.Tests;

public class Exercise08Tests
{
    [Fact]
    public void SquareNumbers_ProjectsEachValueSquared()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        var result = Exercise08.SquareNumbers(numbers);

        Assert.Equal(new[] { 1, 4, 9, 16, 25 }, result);
    }
}
