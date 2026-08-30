using Exercises;

namespace Exercises.Tests;

public class Exercise34Tests
{
    [Fact]
    public void LeftJoinEmployeesDepartments_KeepsEmployeesWithNoDepartment()
    {
        var employees = new List<EmployeeRecord> { new("Alice", 10), new("Bob", 20), new("Charlie", 0) };
        var departments = new List<DepartmentInfo> { new(10, "Engineering"), new(20, "Sales") };

        var result = Exercise34.LeftJoinEmployeesDepartments(employees, departments);

        Assert.Equal(new[] { "Alice: Engineering", "Bob: Sales", "Charlie: No Department" }, result);
    }
}
