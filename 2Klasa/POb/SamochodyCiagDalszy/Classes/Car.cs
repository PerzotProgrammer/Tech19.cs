namespace SamochodyCiagDalszy.Classes;

public enum DriveType
{
    Petrol,
    Diesel,
    Electric,
    Hybrid
}

public class Car
{
    private string Brand;
    private string Model;
    private int NumOfWheels = 4;
    private int YearOfProduction;
    private float EngineCapacity;
    private DateTime DateOfFirstRegistration;
    private DriveType DriveType;

    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        YearOfProduction = 0;
    }

    public Car(string brand, string model, int yearOfProduction, float engineCapacity, DateTime dateOfFirstRegistration,
        DriveType driveType)
    {
        Brand = brand;
        Model = model;
        YearOfProduction = yearOfProduction;
        EngineCapacity = engineCapacity;
        DateOfFirstRegistration = dateOfFirstRegistration;
        DriveType = driveType;
    }

    public string GetInfo()
    {
        return
            $"Brand: {Brand}\nModel: {Model}\nYearOfProduction: {YearOfProduction}\nEngineCapacity: {EngineCapacity}\nDateOfFirstRegistration: {DateOfFirstRegistration}\nDriveType: {DriveType}";
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

    public void GetInfoJSON()
    {
        throw new NotImplementedException();
        // TODO w domu: nie mieliśmy jeszcze konwersji na JSONa
    }

    public float AvgFuelUsage(float amountOfFuel, float kilometersTraveled)
    {
        return amountOfFuel / kilometersTraveled;
    }
}