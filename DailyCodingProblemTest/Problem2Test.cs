using DailyCodingProblem;
using DailyCodingProblem.Problem;

namespace DailyCodingProblemTest;

public class Problem2Test
{
    [Fact]
    public void Test1()
    {
        var nums = new List<int> { 1, 2, 3, 4, 5 };
        var expected = new List<int> { 120, 60, 40, 30, 24 };
        var actual = Problem2.Solve(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var nums = new List<int> { 3, 2, 1 };
        var expected = new List<int> { 2, 3, 6 };
        var actual = Problem2.Solve(nums);
        Assert.Equal(expected, actual);
    }
}