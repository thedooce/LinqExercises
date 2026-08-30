using Exercises;

namespace Exercises.Tests;

public class Exercise24Tests
{
    [Fact]
    public void CountContainingLinq_CountsSentencesWithTheWordLinq()
    {
        var sentences = new List<string>
        {
            "I love LINQ", "This has nothing", "LINQ is powerful", "Another sentence", "LINQ makes life easier",
        };

        var result = Exercise24.CountContainingLinq(sentences);

        Assert.Equal(3, result);
    }
}
