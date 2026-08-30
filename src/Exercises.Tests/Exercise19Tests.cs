using Exercises;

namespace Exercises.Tests;

public class Exercise19Tests
{
    [Fact]
    public void FlattenMatrix_FlattensJaggedArray()
    {
        var matrix = new int[][]
        {
            new[] { 1, 2, 3 },
            new[] { 4, 5 },
            new[] { 6, 7, 8, 9 },
        };

        var result = Exercise19.FlattenMatrix(matrix);

        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
    }
}
