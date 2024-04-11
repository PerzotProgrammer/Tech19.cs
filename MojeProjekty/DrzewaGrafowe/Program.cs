namespace DrzewaGrafowe;

class Program
{
    static void Main()
    {
        Node i = new('I');
        Node h = new('H');
        Node g = new('G');
        Node f = new('F');
        Node e = new('E');
        Node d = new('D', h, i);
        Node c = new('C', f, g);
        Node b = new('B', d, e);
        Node a = new('A', b, c);

        List<Node> dfs = Dfs(a);
        List<Node> bfs = Bfs(a);

        Console.Write("DFS:");
        PrintNodes(dfs);
        Console.Write("BFS:");
        PrintNodes(bfs);
    }

    static List<Node> Dfs(Node root)
    {
        Stack<Node> stack = new();
        List<Node> visited = new();
        Node current = root;
        stack.Push(current);
        while (stack.Count > 0)
        {
            current = stack.Pop();
            visited.Add(current);
            foreach (Node child in current.GetChilds()) stack.Push(child);
        }

        return visited;
    }

    static List<Node> Bfs(Node root)
    {
        Queue<Node> stack = new();
        List<Node> visited = new();
        Node current = root;
        stack.Enqueue(current);
        while (stack.Count > 0)
        {
            current = stack.Dequeue();
            visited.Add(current);
            foreach (Node child in current.GetChilds()) stack.Enqueue(child);
        }

        return visited;
    }

    static void PrintNodes(List<Node> list)
    {
        foreach (Node node in list) Console.Write($" -> {node.GetValue()}");
        Console.WriteLine();
    }
}