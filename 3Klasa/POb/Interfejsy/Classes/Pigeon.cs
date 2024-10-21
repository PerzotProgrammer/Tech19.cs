namespace Interfejsy.Classes;

public class Pigeon : IAnimal
{
    public AnimalTypeEnum TypeEnum { get; set; }
    public string Name { get; set; }
    public ColorEnum Color { get; set; }
    public int Age { get; set; }

    public Pigeon(string name, ColorEnum color, int age)
    {
        Name = name;
        Color = color;
        Age = age;
        TypeEnum = AnimalTypeEnum.Bird;
    }

    public void Eat()
    {
        Console.WriteLine($"Pigeon {Name} is eating");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Pigeon {Name} is cooing");
    }

    public void Sleep()
    {
        Console.WriteLine($"Pigeon {Name} is sleeping");
    }

    public void Move()
    {
        Console.WriteLine($"Pigeon {Name} is flying");
    }
}