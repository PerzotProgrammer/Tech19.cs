namespace UML.Classes;

public abstract class Vehicle
{
    protected string Name;

    protected Vehicle(string name)
    {
        Name = name;
    }


    public void StartMoving()
    {
        StartEngine();
        Thread.Sleep(500);
        Move();
        Console.WriteLine();
    }

    protected abstract void StartEngine();
    protected abstract void Move();
}

public class Car : Vehicle
{
    public Car(string name) : base(name)
    {
        Console.WriteLine($"Stworzono samochód {Name}!");
        Console.WriteLine();

    }

    protected override void StartEngine()
    {
        Console.WriteLine($"Samochód {Name} odpalił silnik!");
    }

    protected override void Move()
    {
        Console.WriteLine($"Samochód {Name} jedzie!");
    }
}

public class Plane : Vehicle
{
    public Plane(string name) : base(name)
    {
        Console.WriteLine($"Stworzono samolot {Name}!");
        Console.WriteLine();

    }

    protected override void StartEngine()
    {
        Console.WriteLine($"Samolot {Name} odpalił silnik!");
    }

    protected override void Move()
    {
        Console.WriteLine($"Samolot {Name} leci!");
    }
}