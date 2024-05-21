namespace Budowa.Classes;

public class ConcreteMixer : Vehicle
{
    public ConcreteMixer(string model, string brand) : base(model, brand)
    {
        VehicleType = VehicleType.ConcreteMixer;
        FuelType = FuelType.Diesel;
        MaxFuelCapacity = 300f;
        FuelToStart = 15f;
    }

    public void MixConcrete()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa aby wymieszać cement");
            return;
        }

        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} musi odpalić silnik aby wymieszać cement");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        Console.WriteLine($"{GetLongName()} miesza cement!");
    }

    public override void Work()
    {
        MixConcrete();
    }
}