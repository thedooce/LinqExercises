namespace Exercises;

/// <summary>
/// Exercise 33: Joining Students and Courses
/// Given a list of Student objects and Course objects, perform an inner join to list student
/// names alongside their courses, formatted as "{StudentName}: {CourseName}".
/// </summary>
public static class Exercise33
{
    public static IEnumerable<string> InnerJoinStudentsCourses(List<Student> students, List<Course> courses)
    {
        // TODO: use students.Join(courses, s => s.Id, c => c.StudentId, (s, c) => $"{s.Name}: {c.Name}")
        throw new NotImplementedException();
    }
}
