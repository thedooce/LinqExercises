using Exercises;

namespace Exercises.Tests;

public class Exercise39Tests
{
    [Fact]
    public void HighestPaidPerDepartment_PicksTopEarnerInEachGroup()
    {
        var employees = new List<Employee>
        {
            new("Alice", "Engineering", 8500m),
            new("Bob", "Sales", 6000m),
            new("Charlie", "Engineering", 9200m),
            new("Dave", "Sales", 7200m),
            new("Eve", "Marketing", 5500m),
        };

        var result = Exercise39.HighestPaidPerDepartment(employees).ToList();

        Assert.Equal(3, result.Count);
        Assert.Contains(result, e => e is { Name: "Charlie", Department: "Engineering", Salary: 9200m });
        Assert.Contains(result, e => e is { Name: "Dave", Department: "Sales", Salary: 7200m });
        Assert.Contains(result, e => e is { Name: "Eve", Department: "Marketing", Salary: 5500m });
    }
}
