namespace DziedziczeniePowtorka.Classes;

public class Triangle : Shape
{
    private float SideA;
    private float SideB;
    private float SideC;

    public Triangle(float sideA, float sideB, float sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        NumberOfAngles = 3;
        if (!IsValidTriangle())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TRÓJKĄT NIE MOŻE POWSTAĆ!!!");
            Console.ResetColor();
            Console.WriteLine("Zmieniam na: 3, 4, 5");
            SideA = 3;
            SideB = 4;
            SideC = 5;
        }
    }

    private bool IsValidTriangle()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }

    public override float CalculateArea()
    {
        float s = (SideA + SideB + SideC) / 2;
        return (float)Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override float CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public override void Describe()
    {
        Console.WriteLine("Shape: Triangle");
        Console.WriteLine($"Sides: {SideA}, {SideB}, {SideC}");
        Console.WriteLine($"Number of Angles: {GetNumberOfAngles()}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}