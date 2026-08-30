using Exercises;

namespace Exercises.Tests;

public class Exercise26Tests
{
    [Fact]
    public void FactorialLinq_ComputesFactorialOfFive()
    {
        var result = Exercise26.FactorialLinq(5);

        Assert.Equal(120, result);
    }
}
