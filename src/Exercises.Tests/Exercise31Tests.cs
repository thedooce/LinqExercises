using Exercises;

namespace Exercises.Tests;

public class Exercise31Tests
{
    [Fact]
    public void GroupPeopleByAge_GroupsByMatchingAge()
    {
        var people = new List<Person>
        {
            new("Alice", 30),
            new("Bob", 25),
            new("Charlie", 30),
            new("Dave", 25),
            new("Eve", 35),
        };

        var result = Exercise31.GroupPeopleByAge(people).ToList();

        Assert.Equal(new[] { 30, 25, 35 }, result.Select(g => g.Key));
        Assert.Equal(new[] { "Alice", "Charlie" }, result.First(g => g.Key == 30).Select(p => p.Name));
        Assert.Equal(new[] { "Bob", "Dave" }, result.First(g => g.Key == 25).Select(p => p.Name));
        Assert.Equal(new[] { "Eve" }, result.First(g => g.Key == 35).Select(p => p.Name));
    }
}
