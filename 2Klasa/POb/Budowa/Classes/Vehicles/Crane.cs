namespace Budowa.Classes.Vehicles;

public class Crane : Vehicle
{
    public Crane(string model, string brand) : base(model, brand)
    {
        VehicleType = VehicleType.Crane; 
        FuelType = FuelType.Diesel;
        MaxFuelCapacity = 250f;
        FuelToStart = 100f;
    }

    public void LiftUpMaterials()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa aby podnieść materiały");
            return;
        }

        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} musi odpalić silnik aby podnieść materiały");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        Console.WriteLine($"{GetLongName()} podnosi materiały!");
    }

    public override void Work()
    {
        LiftUpMaterials();
    }
}