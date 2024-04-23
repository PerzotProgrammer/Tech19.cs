namespace Dziedziczenie.Classes;

public class Plane : Vehicle
{
    public Plane(string brand, string model, int numberOfSeats, float baseFuel = 0) : base(brand, model, numberOfSeats,
        baseFuel)
    {
        VehicleType = "Samolot";
        NumberOfSeats = numberOfSeats;
    }

    public override void StartEngine()
    {
        FuelAmount -= 50;
        Console.WriteLine($"{VehicleType} {Brand} {Model} odpalił silnik!");
        Console.WriteLine("Lepiej uciekać z płyty lotniska!");
    }

    public override void Move()
    {
        if (FuelAmount <= 100)
        {
            Console.WriteLine($"{VehicleType} {Brand} {Model} nie może lecieć, ponieważ nie ma paliwa!");
            return;
        }

        StartEngine();
        Console.WriteLine($"{VehicleType} {Brand} {Model} leci!");
    }
}