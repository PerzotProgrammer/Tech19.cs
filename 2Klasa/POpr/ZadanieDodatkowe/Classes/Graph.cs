namespace ZadanieDodatkowe.Classes;

public class Graph
{
    private List<Node> Nodes;

    public Graph()
    {
        Nodes = new();
    }

    public void AddToGraph(Node node)
    {
        Nodes.Add(node);
    }

    public int FindHighestDegree()
    {
        int max = 0;
        foreach (Node node in Nodes) max = Math.Max(max, node.CheckDegree());
        return max;
    }

    public void PrintJoints()
    {
        string[] joints = new string[Nodes.Count];
        for (int i = 0; i < joints.Length; i++) joints[i] = Nodes[i].ShowJoints();
        foreach (string joint in joints) Console.WriteLine(joint);
    }
}