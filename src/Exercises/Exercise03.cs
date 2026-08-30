namespace Exercises;

/// <summary>
/// Exercise 03: Sorting Names in Reverse
/// Given a list of names, sort them in descending alphabetical order.
/// </summary>
public static class Exercise03
{
    public static IEnumerable<string> SortNamesDescending(List<string> names)
    {
        //        var descendingNames = names.OrderByDescending(name => name);

        var descendingNames =   from name in names
                                orderby name descending
                                select name;
        return descendingNames;
    }
}
