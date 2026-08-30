using Exercises;

namespace Exercises.Tests;

public class Exercise36Tests
{
    [Fact]
    public void FindMissingProducts_ReturnsProductsOnlyInA()
    {
        var inventoryA = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        var inventoryB = new List<string> { "Banana", "Date", "Fig" };

        var result = Exercise36.FindMissingProducts(inventoryA, inventoryB);

        Assert.Equal(new[] { "Apple", "Cherry", "Elderberry" }, result);
    }
}
