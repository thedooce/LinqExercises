namespace Exercises;

/// <summary>
/// Exercise 13: Creating Anonymous Types
/// Convert a list of Product objects into a list of anonymous types containing only
/// ProductName and CalculatedTax (Price x 0.15).
/// </summary>
public static class Exercise13
{
    public static IEnumerable<dynamic> ProjectProductTax(List<Product> products)
    {
        // TODO: use Select() to project: new { ProductName = p.Name, CalculatedTax = p.Price * 0.15m }
        throw new NotImplementedException();
    }
}
