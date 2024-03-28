using System.Text.Json;

namespace SamochodyCiagDalszy.Classes;

public enum DriveType
{
    Unknown,
    Petrol,
    Diesel,
    Electric,
    Hybrid
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int NumOfWheels { get; set; }
    public int YearOfProduction { get; set; }
    public float EngineCapacity { get; set; }
    public DateTime DateOfFirstRegistration { get; set; }
    public DriveType DriveType { get; set; }

    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        YearOfProduction = 0;
        NumOfWheels = 4;
    }

    public Car(string brand, string model, int yearOfProduction, float engineCapacity, DateTime dateOfFirstRegistration,
        DriveType driveType)
    {
        Brand = brand;
        Model = model;
        NumOfWheels = 4;
        YearOfProduction = yearOfProduction;
        EngineCapacity = engineCapacity;
        DateOfFirstRegistration = dateOfFirstRegistration;
        DriveType = driveType;
    }

    public string GetInfo()
    {
        return
            $"Brand: {Brand}\nModel: {Model}\nYearOfProduction: {YearOfProduction}\nEngineCapacity: {EngineCapacity}\nDateOfFirstRegistration: {DateOfFirstRegistration.ToShortDateString()}\nDriveType: {DriveType}";
    }

    public int GetAge()
    {
        return DateTime.Now.Year - YearOfProduction;
    }

    public void ChangeBrandAndModel(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public bool IsClassic()
    {
        return GetAge() > 35;
    }

    public string GetInfoJSON()
    {
        return JsonSerializer.Serialize(this);
    }

    public float AvgFuelUsage(float amountOfFuel, float kilometersTraveled)
    {
        return amountOfFuel / kilometersTraveled;
    }
}