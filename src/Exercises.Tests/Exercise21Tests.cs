using Exercises;

namespace Exercises.Tests;

public class Exercise21Tests
{
    [Fact]
    public void SumOfSquaresOfOdds_SumsSquaresOfOddNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = Exercise21.SumOfSquaresOfOdds(numbers);

        Assert.Equal(165, result);
    }
}
