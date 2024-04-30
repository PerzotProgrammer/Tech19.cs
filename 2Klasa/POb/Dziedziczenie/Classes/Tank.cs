namespace Dziedziczenie.Classes;

public class Tank : Vehicle
{
    private int AmmunitionCount;

    public Tank(string brand, string model, int numberOfSeats, int ammunitionCount,
        FuelType fuelType = FuelType.Diesel) :
        base(brand, model, numberOfSeats)
    {
        VehicleType = "Czołg";
        NumberOfSeats = numberOfSeats;
        FuelType = fuelType;
        MinimumFuelToStart = 50f;
        AmmunitionCount = ammunitionCount;
    }

    public override void StartEngine()
    {
        FuelAmount -= MinimumFuelToStart;
        Console.WriteLine($"{VehicleType} {Brand} {Model} odpalił silnik!");
    }

    public override void Move()
    {
        if (FuelAmount <= MinimumFuelToStart * 1.5f)
        {
            Console.WriteLine($"{VehicleType} {Brand} {Model} nie może jechać, ponieważ nie ma paliwa!");
            return;
        }

        StartEngine();
        Console.WriteLine($"{VehicleType} {Brand} {Model} jedzie!");
    }

    public void Shoot()
    {
        if (AmmunitionCount <= 0)
        {
            Console.WriteLine($"{VehicleType} nie ma pocisków!");
            return;
        }

        AmmunitionCount--;
        Console.WriteLine($"{VehicleType} strzelił z działa!");
    }
}