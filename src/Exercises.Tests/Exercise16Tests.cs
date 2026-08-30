using Exercises;

namespace Exercises.Tests;

public class Exercise16Tests
{
    [Fact]
    public void ProjectWithIndex_FormatsIndexAndValue()
    {
        var items = new List<string> { "Red", "Green", "Blue" };

        var result = Exercise16.ProjectWithIndex(items);

        Assert.Equal(new[]
        {
            "Index: 0, Value: Red",
            "Index: 1, Value: Green",
            "Index: 2, Value: Blue",
        }, result);
    }
}
