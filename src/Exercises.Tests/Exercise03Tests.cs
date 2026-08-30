using Exercises;

namespace Exercises.Tests;

public class Exercise03Tests
{
    [Fact]
    public void SortNamesDescending_SortsAlphabeticallyDescending()
    {
        var names = new List<string> { "Charlie", "Alice", "Bob", "Eve", "Dave" };

        var result = Exercise03.SortNamesDescending(names);

        Assert.Equal(new[] { "Eve", "Dave", "Charlie", "Bob", "Alice" }, result);
    }
}
