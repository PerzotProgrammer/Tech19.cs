namespace ZadanieDodatkowe.Classes;

public class Node
{
    private List<int> Joints;
    private int Value;

    public Node(int value, Graph graph)
    {
        Value = value;
        Joints = new();
        graph.AddToGraph(this);
    }

    public void MakeJoints(Node node)
    {
        Joints.Add(node.Value);
        node.Joints.Add(Value);
    }

    public int CheckDegree()
    {
        return Joints.Count;
    }

    public string ShowJoints()
    {
        string output = $"{Value}: ";
        foreach (int joint in Joints) output += $"{joint}, ";
        return output;
    }
}