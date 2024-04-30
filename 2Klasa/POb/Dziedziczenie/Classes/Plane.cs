namespace Dziedziczenie.Classes;

public class Plane : Vehicle
{
    public Plane(string brand, string model, int numberOfSeats, FuelType fuelType = FuelType.JetFuel) :
        base(brand, model, numberOfSeats)
    {
        VehicleType = "Samolot";
        MinimumFuelToStart = 50;
        FuelType = fuelType;
    }

    public override void StartEngine()
    {
        FuelAmount -= MinimumFuelToStart;
        Console.WriteLine($"{VehicleType} {Brand} {Model} odpalił silnik!");
        Console.WriteLine("Lepiej uciekać z płyty lotniska!");
    }

    public override void Move()
    {
        if (FuelAmount <= MinimumFuelToStart * 2)
        {
            Console.WriteLine($"{VehicleType} {Brand} {Model} nie może lecieć, ponieważ nie ma paliwa!");
            return;
        }

        StartEngine();
        Console.WriteLine($"{VehicleType} {Brand} {Model} leci!");
    }
}