using Exercises;

namespace Exercises.Tests;

public class Exercise13Tests
{
    [Fact]
    public void ProjectProductTax_ComputesFifteenPercentTax()
    {
        var products = new List<Product>
        {
            new("Laptop", 1000m),
            new("Mouse", 20m),
            new("Keyboard", 50m),
        };

        var result = Exercise13.ProjectProductTax(products).Cast<dynamic>().ToList();

        Assert.Equal(3, result.Count);
        Assert.Equal("Laptop", (string)result[0].ProductName);
        Assert.Equal(150.00m, (decimal)result[0].CalculatedTax);
        Assert.Equal("Mouse", (string)result[1].ProductName);
        Assert.Equal(3.00m, (decimal)result[1].CalculatedTax);
        Assert.Equal("Keyboard", (string)result[2].ProductName);
        Assert.Equal(7.50m, (decimal)result[2].CalculatedTax);
    }
}
