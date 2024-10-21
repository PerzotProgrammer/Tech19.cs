namespace Interfejsy.Classes;

public class Cat : IAnimal
{
    public AnimalTypeEnum TypeEnum { get; set; }
    public string Name { get; set; }
    public ColorEnum Color { get; set; }
    public int Age { get; set; }

    public Cat(string name, ColorEnum color, int age)
    {
        Name = name;
        Color = color;
        Age = age;
        TypeEnum = AnimalTypeEnum.Mammal;
    }


    public void Eat()
    {
        Console.WriteLine($"Cat {Name} is eating");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Cat {Name} is meowing");
    }

    public void Sleep()
    {
        Console.WriteLine($"Cat {Name} is sleeping");
    }

    public void Move()
    {
        Console.WriteLine($"Cat {Name} is moving");
    }
}