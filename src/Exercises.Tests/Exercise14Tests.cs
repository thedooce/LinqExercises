using Exercises;

namespace Exercises.Tests;

public class Exercise14Tests
{
    [Fact]
    public void FlattenEmployees_CombinesAllDepartmentEmployees()
    {
        var departments = new List<Department>
        {
            new("Engineering", new List<Employee> { new("Alice", "Engineering", 0m), new("Bob", "Engineering", 0m) }),
            new("Sales", new List<Employee> { new("Charlie", "Sales", 0m) }),
            new("Marketing", new List<Employee> { new("Dave", "Marketing", 0m), new("Eve", "Marketing", 0m) }),
        };

        var result = Exercise14.FlattenEmployees(departments).Select(e => e.Name);

        Assert.Equal(new[] { "Alice", "Bob", "Charlie", "Dave", "Eve" }, result);
    }
}
