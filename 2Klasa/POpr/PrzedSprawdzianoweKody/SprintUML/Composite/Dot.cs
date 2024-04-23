namespace SprintUML.Composite;

public class Dot : IGraphic
{
    protected int X;
    protected int Y;

    public Dot(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Kropka jest na pozycji {X} {Y}");
    }
}