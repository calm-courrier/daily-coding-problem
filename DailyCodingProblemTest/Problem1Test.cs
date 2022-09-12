using DailyCodingProblem;

namespace DailyCodingProblemTest;

public class Problem1Test
{
    [Fact]
    public void Test1()
    {
        var result = Problem1.Solve(new List<int>() { 10, 15, 3, 7 }, 17);
        Assert.True(result);
    }
    
    [Fact]
    public void Test2()
    {
        var result = Problem1.Solve(new List<int>() { 10, 15, 3, 7 }, 16);
        Assert.False(result);
    }
}