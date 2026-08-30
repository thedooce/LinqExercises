using Exercises;

namespace Exercises.Tests;

public class Exercise23Tests
{
    [Fact]
    public void MinMaxPrice_FindsCheapestAndMostExpensive()
    {
        var products = new List<Product>
        {
            new("Laptop", 999m),
            new("Mouse", 15m),
            new("Monitor", 250m),
            new("Keyboard", 45m),
        };

        var result = Exercise23.MinMaxPrice(products);

        Assert.Equal(15m, result.Min);
        Assert.Equal(999m, result.Max);
    }
}
