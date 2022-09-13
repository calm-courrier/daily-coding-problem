using System.Text;
using DailyCodingProblem.Model;

namespace DailyCodingProblem.Problem;

public static class Problem3 {
    public static string Serialize(Node node) {
        return SerializeNode(node);
    }

    private static string SerializeNode(Node? node) {
        if (node is null) {
            return "[]";
        }

        return "[" + node.Value + ";" + SerializeNode(node.Left) + ";" + SerializeNode(node.Right) + "]";
    }

    public static Node? Deserialize(string str) {
        return DeserializeNode(str);
    }

    private static Node? DeserializeNode(string str) {
        if (str.Equals("[]")) {
            return null;
        }

        var indentationCnt = 0;
        var partIndex = 0;
        var parts = new StringBuilder[] { new(), new(), new() };
        foreach (var c in str) {
            switch (c) {
                case '[':
                    if (indentationCnt != 0) {
                        parts[partIndex].Append(c);
                    }

                    indentationCnt++;
                    break;
                case ']':
                    indentationCnt--;
                    if (indentationCnt != 0) {
                        parts[partIndex].Append(c);
                    }

                    break;
                case ';':
                    if (indentationCnt == 1) {
                        partIndex++;
                    }
                    else {
                        parts[partIndex].Append(c);
                    }

                    break;
                default:
                    parts[partIndex].Append(c);
                    break;
            }
        }

        return new Node(value: parts[0].ToString(),
            left: DeserializeNode(parts[1].ToString()),
            right: DeserializeNode(parts[2].ToString()));
    }
}