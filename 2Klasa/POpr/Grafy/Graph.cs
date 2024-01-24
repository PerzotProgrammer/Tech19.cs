namespace Grafy;

public class Graph
{
    private List<Node> Nodes = new();

    public Graph(int numOfNodes)
    {
        for (int i = 0; i < numOfNodes; i++)
        {
            Nodes.Add(new());
        }
    }

    public void AddJoints(int index, params int[] joints)
    {
        foreach (int joint in joints)
        {
            Nodes[index].AddJoint(joint);
        }
    }

    public void WriteAllJoints()
    {
        for (int i = 0; i < Nodes.Count; i++)
        {
            List<int> Joints = Nodes[i].GetJoints();
            Console.Write($"{i} : ");
            foreach (int joint in Joints) Console.Write($"{joint};");
            Console.WriteLine();
        }
    }
}