using Exercises;

namespace Exercises.Tests;

public class Exercise33Tests
{
    [Fact]
    public void InnerJoinStudentsCourses_OnlyIncludesMatchedStudents()
    {
        var students = new List<Student> { new(1, "Alice"), new(2, "Bob"), new(3, "Charlie") };
        var courses = new List<Course> { new(1, "Math"), new(1, "Science"), new(2, "History"), new(4, "Art") };

        var result = Exercise33.InnerJoinStudentsCourses(students, courses);

        Assert.Equal(new[] { "Alice: Math", "Alice: Science", "Bob: History" }, result);
    }
}
