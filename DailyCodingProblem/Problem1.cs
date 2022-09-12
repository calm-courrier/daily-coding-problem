namespace DailyCodingProblem;

public static class Problem1
{
    public static bool Solve(IList<int> numbers, int k)
    {
        var required = numbers.Select(x => (x - k) * -1).ToHashSet();
        return numbers.Any(x => required.Contains(x));
    }
}