using System.Text.Json;
using System.Text.Json.Serialization;

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
    // JsonInclude ponieważ Serializer nie używa domyślnie prywatnych pól
    [JsonInclude] private string Brand;
    [JsonInclude] private string Model;
    [JsonInclude] private int NumOfWheels;
    [JsonInclude] private int YearOfProduction;
    [JsonInclude] private float EngineCapacity;
    [JsonInclude] private DateTime DateOfFirstRegistration;
    [JsonInclude] private DriveType DriveType;

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