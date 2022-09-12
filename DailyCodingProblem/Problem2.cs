namespace DailyCodingProblem;

public static class Problem2
{
    public static IEnumerable<int> Solve(IEnumerable<int> nums)
    {
        var arr = nums as int[] ?? nums.ToArray();
        long product = arr.Aggregate(1, (acc, x) => acc * x);
        return arr.Select(x => product / x).Select(x => (int)x).ToList();
    }
}