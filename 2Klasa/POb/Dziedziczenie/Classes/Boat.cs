namespace Dziedziczenie.Classes;

public class Boat : Vehicle
{
    public Boat(string brand, string model, int numberOfSeats, FuelType fuelType = FuelType.Diesel) :
        base(brand, model, numberOfSeats)
    {
        VehicleType = "Łódź";
        MinimumFuelToStart = 150;
        FuelType = fuelType;
    }

    public override void StartEngine()
    {
        FuelAmount -= MinimumFuelToStart;
        Console.WriteLine($"{VehicleType} {Brand} {Model} odpalił silnik!");
    }

    public override void Move()
    {
        if (FuelAmount <= MinimumFuelToStart * 3)
        {
            Console.WriteLine($"{VehicleType} {Brand} {Model} nie może płynąć, ponieważ nie ma paliwa!");
            return;
        }

        StartEngine();
        Console.WriteLine($"{VehicleType} {Brand} {Model} płynie!");
    }
}