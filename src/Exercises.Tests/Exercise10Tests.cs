using Exercises;

namespace Exercises.Tests;

public class Exercise10Tests
{
    [Fact]
    public void LastWordEndingWithE_ReturnsLastMatch()
    {
        var words = new List<string> { "apple", "banana", "grape", "cherry", "orange", "kiwi" };

        var result = Exercise10.LastWordEndingWithE(words);

        Assert.Equal("orange", result);
    }
}
