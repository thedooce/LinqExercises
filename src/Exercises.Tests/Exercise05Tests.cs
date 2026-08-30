using Exercises;

namespace Exercises.Tests;

public class Exercise05Tests
{
    [Fact]
    public void PaginateProducts_SkipsTwentyTakesTen()
    {
        var products = Enumerable.Range(1, 100).Select(i => $"Product {i}").ToList();

        var result = Exercise05.PaginateProducts(products);

        var expected = Enumerable.Range(21, 10).Select(i => $"Product {i}");
        Assert.Equal(expected, result);
    }
}
