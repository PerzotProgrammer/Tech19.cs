namespace ZadanieDodatkowe.Classes;

public class Graph
{
    public List<Node> Nodes;

    public Graph(params Node[] nodes)
    {
        Nodes = new(nodes);
    }

    public void AddToGraph(Node node) // możnaby usunąć, lecz wtedy wierzchołki tylko w ctorze
    {
        Nodes.Add(node);
    }

    public void MakeJoints(int firstNodeIndex, int secondNodeIndex)
    {
        Nodes[firstNodeIndex].MakeJoint(Nodes[secondNodeIndex]);
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