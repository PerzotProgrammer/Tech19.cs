namespace Grafy;

class Program
{
    static void Main()
    {
        Graph graph = new(6);
        graph.AddJoints(0, 1, 2);
        graph.AddJoints(1, 0, 3);
        graph.AddJoints(2, 0, 3, 5);
        graph.AddJoints(3, 1, 2, 5);
        graph.AddJoints(5, 2, 3);

        graph.WriteAllJoints();
    }
}