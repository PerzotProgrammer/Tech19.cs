namespace DziedziczeniePowtorka.Classes;

public class Circle : Shape
{
    private float Radius;
    private float Diameter;

    public Circle(float radius)
    {
        Radius = radius;
        Diameter = CalculateDiameter();
        NumberOfAngles = 0;
    }

    public float CalculateDiameter()
    {
        Diameter = Radius * 2;
        return Diameter;
    }

    public override float CalculateArea()
    {
        return (float)Math.PI * Radius * Radius;
    }

    public override float CalculatePerimeter()
    {
        return (float)Math.PI * Radius * 2;
    }

    public override void Describe()
    {
        Console.WriteLine("Shape: Circle");
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Diameter: {CalculateDiameter()}");
        Console.WriteLine($"Number of Angles: {GetNumberOfAngles()}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}