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
        var productTaxes = products.Select(product => new 
            {
                ProductName = product.Name,
                CalculatedTax = product.Price * 0.15m
            });
        return productTaxes;
    }
}
