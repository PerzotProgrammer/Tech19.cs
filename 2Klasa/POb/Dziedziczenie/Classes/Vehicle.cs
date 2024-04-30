namespace Dziedziczenie.Classes;

public abstract class Vehicle
{
    protected string Brand;
    protected string Model;
    protected string VehicleType;
    protected int NumberOfSeats;
    protected FuelType FuelType;
    protected float FuelAmount;
    protected float MinimumFuelToStart;

    protected Vehicle(string brand, string model, int numberOfSeats)
    {
        Brand = brand;
        Model = model;
        VehicleType = "unknown";
        NumberOfSeats = numberOfSeats;
        FuelType = FuelType.Unknown;
        FuelAmount = 0;
        MinimumFuelToStart = 0;
    }

    public abstract void StartEngine();
    public abstract void Move();

    public int GetNumberOfSeats()
    {
        return NumberOfSeats;
    }

    public void Refuel(FuelType fuelType, float fuelAmount)
    {
        if (fuelType != FuelType)
        {
            Console.WriteLine(
                $"Nie możesz zatankować {fuelType.ToString()} do pojazdu napędzanego na {FuelType.ToString()}");
            return;
        }

        FuelingAnimator.Animate(fuelAmount, FuelType, 100);
        FuelAmount += fuelAmount;
        Console.WriteLine($"Udało ci się zatankować {VehicleType}!");
    }

    public float GetFuelLevel()
    {
        return FuelAmount;
    }
}