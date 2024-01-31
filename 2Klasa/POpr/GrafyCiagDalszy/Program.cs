namespace GrafyCiagDalszy;

class Program
{
    static void Main()
    {
        List<string>? lines = Console.ReadLine()?.Split().ToList();

        int n = int.Parse(lines![0]);
        int m = int.Parse(lines[1]);

        Graph graph = new(n);

        for (int i = 0; i < m; i++)
        {
            lines = Console.ReadLine()?.Split().ToList();
            int a = int.Parse(lines![0]);
            int b = int.Parse(lines[1]);
            graph.AddNeighbours(a, b);
        }
        
        graph.DisplayGraph();
    }
}