namespace Exercises;

/// <summary>
/// Exercise 39: Finding the Highest Paid Employee per Department
/// Group a list of Employee objects by Department and find the highest-paid employee in
/// each department.
/// </summary>
public static class Exercise39
{
    public static IEnumerable<Employee> HighestPaidPerDepartment(List<Employee> employees)
    {
        var highestPaidEmployees = employees.GroupBy(employee => employee.Department)
                                            .Select(group => group.MaxBy(employee => employee.Salary));
        return highestPaidEmployees;
    }
}
