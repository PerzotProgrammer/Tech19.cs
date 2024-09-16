namespace KartkowkaDziedziczenie.Classes;

public abstract class Vehicle
{
    protected string Brand;
    protected string Model;

    protected Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
    }
}