namespace SprintUML.Composite;

public class Circle : Dot
{
    private int Radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Kółko jest na pozycji {X} {Y} i ma promień {Radius}.");
    }
}