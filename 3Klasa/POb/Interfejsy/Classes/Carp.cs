namespace Interfejsy.Classes;

public class Carp : IAnimal
{
    public AnimalTypeEnum TypeEnum { get; set; }
    public string Name { get; set; }
    public ColorEnum Color { get; set; }
    public int Age { get; set; }

    public Carp(string name, ColorEnum color, int age)
    {
        Name = name;
        Color = color;
        Age = age;
        TypeEnum = AnimalTypeEnum.Fish;
    }

    public void Eat()
    {
        Console.WriteLine($"Carp {Name} is eating");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Carp {Name} is making bubbles");
    }

    public void Sleep()
    {
        Console.WriteLine($"Carp {Name} is sleeping");
    }

    public void Move()
    {
        Console.WriteLine($"Carp {Name} is swimming");
    }
}