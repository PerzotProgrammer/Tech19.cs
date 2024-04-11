namespace DrzewaGrafowe;

public class Node
{
    private List<Node> Childs;
    private char Value;

    public Node(char value, params Node[] childs)
    {
        Childs = new();
        Value = value;
        foreach (Node child in childs) Childs.Add(child);
    }

    public List<Node> GetChilds()
    {
        return Childs;
    }

    public char GetValue()
    {
        return Value;
    }
}