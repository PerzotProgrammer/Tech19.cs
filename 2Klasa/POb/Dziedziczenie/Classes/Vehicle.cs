namespace Dziedziczenie.Classes;

public abstract class Vehicle
{
    protected string Brand;
    protected string Model;
    protected string VehicleType;
    protected float FuelAmount;
    protected int NumberOfSeats;

    protected Vehicle(string brand, string model, int numberOfSeats, float fuelAmount)
    {
        Brand = brand;
        Model = model;
        VehicleType = "";
        NumberOfSeats = numberOfSeats;
        FuelAmount = fuelAmount;
    }

    public abstract void StartEngine();
    public abstract void Move();

    public int GetNumberOfSeats()
    {
        return NumberOfSeats;
    }

    public void Refuel(float fuelAmount)
    {
        FuelAmount += fuelAmount;
    }

    public float GetFuelLevel()
    {
        return FuelAmount;
    }
}