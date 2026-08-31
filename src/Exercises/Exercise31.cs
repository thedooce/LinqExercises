namespace Exercises;

/// <summary>
/// Exercise 31: Grouping People by Age
/// Given a list of Person objects, group them by their Age.
/// </summary>
public static class Exercise31
{
    public static IEnumerable<IGrouping<int, Person>> GroupPeopleByAge(List<Person> people)
    {
        var groups = people.GroupBy(person => person.Age);
        return groups;
    }
}
