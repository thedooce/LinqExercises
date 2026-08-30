using Exercises;

namespace Exercises.Tests;

public class Exercise30Tests
{
    [Fact]
    public void LongestWordMaxBy_ReturnsTheLongestWord()
    {
        var words = new string[] { "cat", "elephant", "dog", "hippopotamus", "ox" };

        var result = Exercise30.LongestWordMaxBy(words);

        Assert.Equal("hippopotamus", result);
    }
}
