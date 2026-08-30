using Exercises;

namespace Exercises.Tests;

public class Exercise40Tests
{
    [Fact]
    public void ChunkList_SplitsIntoGroupsOfFive()
    {
        var numbers = Enumerable.Range(1, 12).ToList();

        var result = Exercise40.ChunkList(numbers).ToList();

        Assert.Equal(3, result.Count);
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result[0]);
        Assert.Equal(new[] { 6, 7, 8, 9, 10 }, result[1]);
        Assert.Equal(new[] { 11, 12 }, result[2]);
    }
}
