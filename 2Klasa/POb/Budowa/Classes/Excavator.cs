namespace Budowa.Classes;

public class Excavator : Vehicle
{
    public Excavator(string model, string brand) : base(model, brand)
    {
        VehicleType = VehicleType.Excavator;
        FuelType = FuelType.Diesel;
        MaxFuelCapacity = 50f;
        FuelToStart = 10f;
    }

    public void Dig()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa aby kopać");
            return;
        }

        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} musi odpalić silnik aby kopać");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        Console.WriteLine($"{GetLongName()} rozpoczyna kopanie!");
    }

    public override void Work()
    {
        Dig();
    }
}