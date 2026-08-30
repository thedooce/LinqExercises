using Exercises;

namespace Exercises.Tests;

public class Exercise18Tests
{
    [Fact]
    public void UniqueEmailDomains_ReturnsDistinctDomainsInFirstSeenOrder()
    {
        var emails = new List<string>
        {
            "alice@gmail.com", "bob@yahoo.com", "charlie@gmail.com", "dave@outlook.com", "eve@yahoo.com",
        };

        var result = Exercise18.UniqueEmailDomains(emails);

        Assert.Equal(new[] { "gmail.com", "yahoo.com", "outlook.com" }, result);
    }
}
