namespace Budowa.Classes;

public class ConstructionManager
{
    public string Name;
    public List<Vehicle> Vehicles;

    public ConstructionManager(string name)
    {
        Name = name;
        Vehicles = new();
    }

    public void RefuelAllVehicles(float fuelAmount)
    {
        if (Vehicles.Count == 0)
        {
            Console.WriteLine("Na budowie nie ma maszyn!");
            return;
        }

        float fuelPerVehicle = fuelAmount / Vehicles.Count;
        foreach (Vehicle vehicle in Vehicles) vehicle.Refuel(fuelPerVehicle);
    }

    public void GetAllVehiclesToWork()
    {
        if (Vehicles.Count == 0)
        {
            Console.WriteLine("Na budowie nie ma maszyn!");
            return;
        }

        foreach (Vehicle vehicle in Vehicles)
        {
            vehicle.StartEngine();
            vehicle.Work();
        }
    }

    public void StopAllVehicles()
    {
        if (Vehicles.Count == 0)
        {
            Console.WriteLine("Na budowie nie ma maszyn!");
            return;
        }

        foreach (Vehicle vehicle in Vehicles) vehicle.StopEngine();
    }

    public void AddVehicle(string model, string brand, VehicleType vehicleType)
    {
        switch (vehicleType)
        {
            case VehicleType.Excavator:
                Vehicles.Add(new Excavator(model, brand));
                Console.WriteLine($"Dodano {vehicleType.ToString()} {model} {brand}");
                break;
            case VehicleType.Trolley:
                Vehicles.Add(new Trolley(model, brand));
                Console.WriteLine($"Dodano {vehicleType.ToString()} {model} {brand}");
                break;
            case VehicleType.Crane:
                Vehicles.Add(new Crane(model, brand));
                Console.WriteLine($"Dodano {vehicleType.ToString()} {model} {brand}");
                break;
            case VehicleType.Tractor:
                Vehicles.Add(new Tractor(model, brand));
                Console.WriteLine($"Dodano {vehicleType.ToString()} {model} {brand}");
                break;
            case VehicleType.ConcreteMixer:
                Vehicles.Add(new ConcreteMixer(model, brand));
                Console.WriteLine($"Dodano {vehicleType.ToString()} {model} {brand}");
                break;
            default:
                Console.WriteLine("Nie ma takiego typu maszyny!");
                break;
        }
    }
}