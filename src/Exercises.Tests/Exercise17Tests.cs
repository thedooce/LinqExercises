using Exercises;

namespace Exercises.Tests;

public class Exercise17Tests
{
    [Fact]
    public void ZipFullNames_CombinesFirstAndLastNames()
    {
        var firstNames = new[] { "John", "Jane", "Jim" };
        var lastNames = new[] { "Doe", "Smith", "Brown" };

        var result = Exercise17.ZipFullNames(firstNames, lastNames);

        Assert.Equal(new[] { "John Doe", "Jane Smith", "Jim Brown" }, result);
    }
}
