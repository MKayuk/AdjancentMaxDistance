using AdjacentMaxDistance;
namespace Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new int[] { 0, 3, 3, 7, 5, 3, 11, 1 }, 2)]
    [InlineData(new int[] { 0, 3, 3, 12, 5, 3, 7, 1 }, 5)]
    public void FindAdjacentMaxDistance_Should_Be_True(int[] arrayOfNumbers, int result)
    {
        Assert.True(Calculator.FindAdjacentMaxDistance(arrayOfNumbers) == result);
    }
}