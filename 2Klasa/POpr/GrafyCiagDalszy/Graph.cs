namespace GrafyCiagDalszy;

public class Graph
{
    private List<Vertex> Vertices = new();

    public Graph(int numOfVertices)
    {
        for (int i = 0; i <= numOfVertices; i++)
        {
            Vertices.Add(new Vertex());
        }
    }

    public void AddNeighbours(int vertex, int neighbour)
    {
        Vertices[vertex].AddNeigbour(neighbour);
        Vertices[neighbour].AddNeigbour(vertex);
    }

    public void DisplayGraph()
    {
        foreach (Vertex vertex in Vertices)
        {
            vertex.DisplayNeighbours();
        }
    }
}