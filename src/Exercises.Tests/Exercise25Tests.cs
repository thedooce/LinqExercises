using Exercises;

namespace Exercises.Tests;

public class Exercise25Tests
{
    [Fact]
    public void JoinWordsAggregate_ProducesCommaSeparatedSentence()
    {
        var words = new List<string> { "apple", "banana", "cherry", "date" };

        var result = Exercise25.JoinWordsAggregate(words);

        Assert.Equal("apple, banana, cherry, date", result);
    }
}
