namespace Budowa.Classes.Vehicles;

public class Tractor : Vehicle
{
    public Tractor(string model, string brand) : base(model, brand)
    {
        VehicleType = VehicleType.Tractor; 
        FuelType = FuelType.Diesel;
        MaxFuelCapacity = 200f;
        FuelToStart = 25f;
    }
    
    public void BringMaterials()
    {
        if (!CheckFuel())
        {
            Console.WriteLine($"{GetLongName()} ma za mało paliwa aby przywieźć materiały");
            return;
        }

        if (!IsRunning)
        {
            Console.WriteLine($"{GetLongName()} musi odpalić silnik aby przywieźć materiały");
            return;
        }

        CurrentFuelLevel -= FuelToStart;
        Console.WriteLine($"{GetLongName()} przywozi materiały!");
    }

    public override void Work()
    {
        BringMaterials();
    }
}