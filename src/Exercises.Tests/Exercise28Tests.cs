using Exercises;

namespace Exercises.Tests;

public class Exercise28Tests
{
    [Fact]
    public void CountVowels_CountsCaseInsensitively()
    {
        var text = "Programming in LINQ is enjoyable";

        var result = Exercise28.CountVowels(text);

        Assert.Equal(10, result);
    }
}
