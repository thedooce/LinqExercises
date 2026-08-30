using Exercises;

namespace Exercises.Tests;

public class Exercise02Tests
{
    [Fact]
    public void FindLongWords_ReturnsWordsLongerThanFive()
    {
        var words = new List<string> { "cat", "elephant", "dog", "butterfly", "ox", "giraffe" };

        var result = Exercise02.FindLongWords(words);

        Assert.Equal(new[] { "elephant", "butterfly", "giraffe" }, result);
    }
}
