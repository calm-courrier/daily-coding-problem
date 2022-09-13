using DailyCodingProblem;
using DailyCodingProblem.Model;
using DailyCodingProblem.Problem;

namespace DailyCodingProblemTest;

public class Problem3Test
{
    [Fact]
    public void Test1()
    {
        var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
        Assert.Equal(node, Problem3.Deserialize(Problem3.Serialize(node)));
    }
}