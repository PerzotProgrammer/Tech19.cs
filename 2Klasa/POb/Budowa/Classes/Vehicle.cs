namespace Budowa.Classes;

public abstract class Vehicle
{
    protected string Model;
    protected string Brand;
    protected float MaxFuelCapacity;
    protected float CurrentFuelLevel;
    protected float FuelToStart;
    protected bool IsRunning;
    protected VehicleType VehicleType;
    protected FuelType FuelType;

    protected Vehicle(string model, string brand)
    {
        Model = model;
        Brand = brand;
        IsRunning = false;
    }

    public abstract void Work();

    protected string GetLongName()
    {
        return $"{VehicleType.ToString()} {Model} {Brand}";
    }

    protected bool CheckFuel()
    {
        if (CurrentFuelLevel < FuelToStart) return false;
        return true;
    }

    public void StartEngine()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa!");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        IsRunning = true;
        Console.WriteLine($"{GetLongName()} odpaliła swój silnik!");
    }

    public void StopEngine()
    {
        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} nie miała odpalonego silnika!");
        }

        IsRunning = false;
        Console.WriteLine($"{GetLongName()} wyłączyła swój silnik!");
    }

    public void Refuel(float fuelAmount, FuelType fuelType = FuelType.Diesel)
    {
        if (Math.Abs(CurrentFuelLevel - MaxFuelCapacity) < 0.1f)
        {
            Console.WriteLine("Nie można tankować ponieważ zbiorniki są pełne!");
            return;
        }

        if (IsRunning)
        {
            Console.WriteLine("Nie można tankować jeżeli działa silnik!");
            return;
        }

        if (fuelType != FuelType)
        {
            Console.WriteLine($"Niepoprawny typ paliwa!\nOczekiwano {FuelType} a dostano {fuelType}");
            return;
        }

        float oldLevel = CurrentFuelLevel;
        CurrentFuelLevel += fuelAmount;
        if (CurrentFuelLevel > MaxFuelCapacity) CurrentFuelLevel = MaxFuelCapacity;
        Console.WriteLine($"Zatankowano {CurrentFuelLevel - oldLevel} j^3 paliwa!");
    }
}