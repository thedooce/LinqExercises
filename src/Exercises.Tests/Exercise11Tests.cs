using Exercises;

namespace Exercises.Tests;

public class Exercise11Tests
{
    [Fact]
    public void ToUpperCase_UppercasesEveryWord()
    {
        var words = new List<string> { "apple", "banana", "cherry" };

        var result = Exercise11.ToUpperCase(words);

        Assert.Equal(new[] { "APPLE", "BANANA", "CHERRY" }, result);
    }
}
