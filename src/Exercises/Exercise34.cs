namespace Exercises;

/// <summary>
/// Exercise 34: Left Joining Employees and Departments
/// Perform a left outer join between Employees and Departments so that employees without a
/// department are still listed, formatted as "{EmployeeName}: {DepartmentName}" or
/// "{EmployeeName}: No Department".
/// </summary>
public static class Exercise34
{
    public static IEnumerable<string> LeftJoinEmployeesDepartments(
        List<EmployeeRecord> employees, List<DepartmentInfo> departments)
    {
        // TODO: use employees.GroupJoin(departments, e => e.DepartmentId, d => d.Id, (e, deps) => new { e, deps })
        //       .SelectMany(x => x.deps.DefaultIfEmpty(), (x, d) => $"{x.e.Name}: {d?.Name ?? "No Department"}")
        throw new NotImplementedException();
    }
}
