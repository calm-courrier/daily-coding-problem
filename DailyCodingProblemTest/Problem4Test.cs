using DailyCodingProblem.Problem;

namespace DailyCodingProblemTest;

public class Problem4Test {
    [Fact]
    public void Test1() {
        var solution = Problem4.Solve(new[] { 3, 4, -1, 1 });
        Assert.Equal(2, solution);
    }

    [Fact]
    public void Test2() {
        var solution = Problem4.Solve(new[] { 1, 2, 0 });
        Assert.Equal(3, solution);
    }

    [Fact]
    public void Test3() {
        var solution = Problem4.Solve(new[] { 3, 2, 1, 0 });
        Assert.Equal(4, solution);
    }

    [Fact]
    public void Test4() {
        var solution = Problem4.Solve(new[] { 3, 2, 4, -1, 1 });
        Assert.Equal(5, solution);
    }
}