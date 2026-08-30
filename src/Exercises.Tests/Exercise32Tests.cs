using Exercises;

namespace Exercises.Tests;

public class Exercise32Tests
{
    [Fact]
    public void CountWordsByLength_OrdersByCountDescending()
    {
        var words = new List<string> { "cat", "dog", "fish", "bird", "ant", "lion", "owl", "bee" };

        var result = Exercise32.CountWordsByLength(words).ToList();

        Assert.Equal(new[] { (3, 5), (4, 3) }, result);
    }
}
