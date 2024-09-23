using DziedziczeniePowtorka.Classes;

namespace DziedziczeniePowtorka;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(CreateCircle());
        shapes.Add(CreateRectangle());
        shapes.Add(CreateTriangle());
        PrintShapes(shapes);
    }

    static Circle CreateCircle()
    {
        Console.WriteLine("TWORZYSZ KÓŁKO");
        Console.Write("Podaj promień: ");
        float radius = float.Parse(Console.ReadLine()!);
        Circle circle = new Circle(radius);
        return circle;
    }

    static Rectangle CreateRectangle()
    {
        Console.WriteLine("TWORZYSZ PROSTOKĄT");
        Console.Write("Podaj długość: ");
        float width = float.Parse(Console.ReadLine()!);
        Console.Write("Podaj wysokość: ");
        float height = float.Parse(Console.ReadLine()!);
        Rectangle rectangle = new Rectangle(width, height);
        return rectangle;
    }

    static Triangle CreateTriangle()
    {
        Console.WriteLine("TWORZYSZ TRÓJKĄT");
        Console.Write("Podaj boki (po przecinku): ");
        float[] sides = Console.ReadLine()!.Split(",").Select(float.Parse).ToArray();
        Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
        return triangle;
    }


    static void PrintShapes(List<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("-------------");
            shape.Describe();
        }
    }
}