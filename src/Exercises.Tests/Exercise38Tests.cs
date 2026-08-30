using Exercises;

namespace Exercises.Tests;

public class Exercise38Tests
{
    [Fact]
    public void MostFrequentNumber_ReturnsTheModeValue()
    {
        var numbers = new int[] { 1, 3, 2, 3, 4, 3, 2, 5, 3 };

        var result = Exercise38.MostFrequentNumber(numbers);

        Assert.Equal(3, result);
    }
}
