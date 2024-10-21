using Interfejsy.Classes;

namespace Interfejsy;

class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(CreateAnimal());
        animals.Add(CreateAnimal());
        animals.Add(CreateAnimal());
        foreach (IAnimal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
            Console.WriteLine($"He is of color {animal.Color}");
        }
    }

    static Cat CreateCat(string name, ColorEnum color, int age)
    {
        return new Cat(name, color, age);
    }

    static Pigeon CreatePigeon(string name, ColorEnum color, int age)
    {
        return new Pigeon(name, color, age);
    }

    static Carp CreateCarp(string name, ColorEnum color, int age)
    {
        return new Carp(name, color, age);
    }

    static IAnimal CreateAnimal()
    {
        Console.WriteLine("Enter animal type (1 - Cat, 2 - Pigeon, 3 - Carp): ");
        int type = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter animal name: ");
        string name = Console.ReadLine()!;
        Console.WriteLine("Enter animal color (number): ");
        ColorEnum color = (ColorEnum)int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter animal age: ");
        int age = int.Parse(Console.ReadLine()!);

        switch (type)
        {
            case 1:
                return CreateCat(name, color, age);
            case 2:
                return CreatePigeon(name, color, age);
            case 3:
                return CreateCarp(name, color, age);
            default:
                throw new ArgumentException();
        }
    }
}