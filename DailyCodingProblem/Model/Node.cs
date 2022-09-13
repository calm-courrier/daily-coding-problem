namespace DailyCodingProblem.Model;

public class Node
{
    public string Value { get; }
    public Node? Left { get; }
    public Node? Right { get; }
    
    public Node(string value, Node? left, Node? right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
    public Node(string value, Node? left)
    {
        Value = value;
        Left = left;
        Right = null;
    }
    public Node(string value)
    {
        Value = value;
        Left = null;
        Right = null;
    }

    private bool Equals(Node other) {
        return Value == other.Value && Equals(Left, other.Left) && Equals(Right, other.Right);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Node)obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine(Value, Left, Right);
    }
}