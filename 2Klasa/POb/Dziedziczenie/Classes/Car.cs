namespace Dziedziczenie.Classes;

public class Car : Vehicle
{
    public Car(string brand, string model, int numberOfSeats, FuelType fuelType = FuelType.Petrol) :
        base(brand, model, numberOfSeats)
    {
        VehicleType = "Samochód";
        MinimumFuelToStart = 10;
        FuelType = fuelType;
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
}