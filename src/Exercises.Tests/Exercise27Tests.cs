using Exercises;

namespace Exercises.Tests;

public class Exercise27Tests
{
    [Fact]
    public void SumDepartmentSalary_SumsSalariesForOneDepartment()
    {
        var employees = new List<Employee>
        {
            new("Alice", "Engineering", 8500m),
            new("Bob", "Sales", 6000m),
            new("Charlie", "Engineering", 9200m),
            new("Dave", "Marketing", 5500m),
            new("Eve", "Engineering", 7800m),
        };

        var result = Exercise27.SumDepartmentSalary(employees, "Engineering");

        Assert.Equal(25500m, result);
    }
}
