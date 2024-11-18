namespace SprawdzianInterfejsy.Classes;

public abstract class Animal : IAnimal
{
    public string Name { get; private set; }
    public string Species { get; private set; }
    public int Age { get; private set; }
    public string Owner { get; private set; }

    protected Animal(string name, string species, int age, string owner)
    {
        Name = name;
        Species = species;
        Age = age;
        Owner = owner;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} je");
    }

    public abstract void MakeSound();
}