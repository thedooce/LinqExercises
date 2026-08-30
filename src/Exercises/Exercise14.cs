namespace Exercises;

/// <summary>
/// Exercise 14: Flattening Nested Lists
/// Given a list of Department objects, where each department has a List<Employee>,
/// flatten this into a single IEnumerable<Employee>.
/// </summary>
public static class Exercise14
{
    public static IEnumerable<Employee> FlattenEmployees(List<Department> departments)
    {
        var allEmployees = departments.SelectMany(department => department.Employees);
        return allEmployees;
    }
}
