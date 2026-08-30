using Exercises;

namespace Exercises.Tests;

public class Exercise12Tests
{
    [Fact]
    public void ProjectEmails_ReturnsJustEmails()
    {
        var users = new List<User>
        {
            new(1, "Alice", "alice@example.com"),
            new(2, "Bob", "bob@example.com"),
            new(3, "Charlie", "charlie@example.com"),
        };

        var result = Exercise12.ProjectEmails(users);

        Assert.Equal(new[] { "alice@example.com", "bob@example.com", "charlie@example.com" }, result);
    }
}
