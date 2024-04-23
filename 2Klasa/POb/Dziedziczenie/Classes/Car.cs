namespace Dziedziczenie.Classes;

public class Car : Vehicle
{
    public Car(string brand, string model, int numberOfSeats, float baseFuel = 0) : base(brand, model, numberOfSeats,
        baseFuel)
    {
        VehicleType = "Samochód";
    }

    public override void StartEngine()
    {
        FuelAmount -= 10;
        Console.WriteLine($"{VehicleType} {Brand} {Model} odpalił silnik!");
    }

    public override void Move()
    {
        if (FuelAmount <= 10)
        {
            Console.WriteLine($"{VehicleType} {Brand} {Model} nie może jechać, ponieważ nie ma paliwa!");
            return;
        }

        StartEngine();
        Console.WriteLine($"{VehicleType} {Brand} {Model} jedzie!");
    }
}