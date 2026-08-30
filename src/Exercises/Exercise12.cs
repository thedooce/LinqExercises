namespace Exercises;

/// <summary>
/// Exercise 12: Projecting Object Properties
/// Given a list of User objects (with Id, Name, Email), project a new list containing only the Email strings.
/// </summary>
public static class Exercise12
{
    public static IEnumerable<string> ProjectEmails(List<User> users)
    {
        var emails = users.Select(u => u.Email);
        return emails;
    }
}
