namespace GrafyCiagDalszy;

public class Vertex
{
    private List<int> Neighbours = new();

    public void AddNeigbour(int neigbour)
    {
        Neighbours.Add(neigbour);
    }

    public void DisplayNeighbours()
    {
        foreach (int neighbour in Neighbours) Console.Write($"{neighbour}; ");
        Console.WriteLine();
    }
}