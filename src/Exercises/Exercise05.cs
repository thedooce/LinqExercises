namespace Exercises;

/// <summary>
/// Exercise 05: Paginating a Product List
/// Given a list of 100 products, skip the first 20 and take the next 10.
/// </summary>
public static class Exercise05
{
    public static IEnumerable<string> PaginateProducts(List<string> products)
    {
        // var paginated = (from p in products
        //                   select p).Skip(20).Take(10);
        
        var paginated = products.Skip(20).Take(10);
        return paginated;
    }
}
