using Exercises;

namespace Exercises.Tests;

public class Exercise37Tests
{
    [Fact]
    public void CombineWithoutDuplicates_MergesAndDeduplicates()
    {
        var listA = new List<string> { "Alice", "Bob", "Charlie" };
        var listB = new List<string> { "Bob", "Dave", "Alice", "Eve" };

        var result = Exercise37.CombineWithoutDuplicates(listA, listB);

        Assert.Equal(new[] { "Alice", "Bob", "Charlie", "Dave", "Eve" }, result);
    }
}
