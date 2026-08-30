using Exercises;

namespace Exercises.Tests;

public class Exercise06Tests
{
    [Fact]
    public void FruitsStartingWithA_IsCaseInsensitive()
    {
        var fruits = new string[] { "apple", "Banana", "Avocado", "cherry", "apricot", "Mango" };

        var result = Exercise06.FruitsStartingWithA(fruits);

        Assert.Equal(new[] { "apple", "Avocado", "apricot" }, result);
    }
}
