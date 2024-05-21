using Budowa.Classes;

namespace Budowa;

class Program
{
    static void Main(string[] args)
    {
        ConstructionManager constructionManager = new("Losowa firma Bolka i Lolka");
        
        constructionManager.AddVehicle("Wolwo", "Koparka", VehicleType.Excavator);
        constructionManager.AddVehicle("Skania", "Traktor", VehicleType.Tractor);
        constructionManager.AddVehicle("Nysa", "Łużycka", VehicleType.Crane);
        constructionManager.AddVehicle("Staliniec", "Ruski", VehicleType.Trolley);
        constructionManager.AddVehicle("Polonez", "Caro", VehicleType.ConcreteMixer);
        
        constructionManager.RefuelAllVehicles(2000f);
        constructionManager.GetAllVehiclesToWork();
        constructionManager.StopAllVehicles();
    }
}