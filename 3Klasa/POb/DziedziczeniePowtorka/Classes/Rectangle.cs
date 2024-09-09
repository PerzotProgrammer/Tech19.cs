namespace DziedziczeniePowtorka.Classes;

public class Rectangle : Shape
{
    private float Width;
    private float Height;
    private float Diagonal;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
        Diagonal = CalculateDiagonal();
        NumberOfAngles = 4;
    }

    public float CalculateDiagonal()
    {
        Diagonal = (float)Math.Sqrt(Width * Width + Height * Height);
        return Diagonal;
    }

    public override float CalculateArea()
    {
        return Width * Height;
    }

    public override float CalculatePerimeter()
    {
        return (Width + Height) * 2;
    }

    public override void Describe()
    {
        Console.WriteLine($"Shape: Rectangle");
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Diagonal: {CalculateDiagonal()}");
        Console.WriteLine($"Number of Angles: {GetNumberOfAngles()}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}