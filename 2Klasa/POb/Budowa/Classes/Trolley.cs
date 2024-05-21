namespace Budowa.Classes;

public class Trolley : Vehicle
{
    public Trolley(string model, string brand) : base(model, brand)
    {
        VehicleType = VehicleType.Trolley;
        FuelType = FuelType.Diesel;
        MaxFuelCapacity = 150f;
        FuelToStart = 20f;
    }

    public void ThrowAwayTrash()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa aby wywieźć gruz");
            return;
        }

        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} musi odpalić silnik aby wywieźć gruz");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        Console.WriteLine($"{GetLongName()} wywozi gruz!");
    }

    public override void Work()
    {
        ThrowAwayTrash();
    }
}