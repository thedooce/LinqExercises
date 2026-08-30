using Exercises;

namespace Exercises.Tests;

public class Exercise22Tests
{
    [Fact]
    public void AveragePriceAfterYear_AveragesBooksPublishedAfter2010()
    {
        var books = new List<Book>
        {
            new("Clean Code", 2008, 35m),
            new("The Pragmatic Programmer", 2019, 40m),
            new("C# in Depth", 2019, 45m),
            new("Design Patterns", 1994, 50m),
            new("Refactoring", 2018, 42m),
        };

        var result = Exercise22.AveragePriceAfterYear(books);

        Assert.Equal(42.33, Math.Round(result, 2));
    }
}
