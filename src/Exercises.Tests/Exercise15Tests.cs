using Exercises;

namespace Exercises.Tests;

public class Exercise15Tests
{
    [Fact]
    public void UniqueCharactersSorted_ExcludesSpacesAndSortsAlphabetically()
    {
        var sentence = "the quick brown fox";

        var result = Exercise15.UniqueCharactersSorted(sentence);

        Assert.Equal(new[] { 'b', 'c', 'e', 'f', 'h', 'i', 'k', 'n', 'o', 'q', 'r', 't', 'u', 'w', 'x' }, result);
    }
}
