namespace Samochody.Classes;

public enum CarStatus
{
    New,
    Used,
    Antique,
    Unknown
}

public class Car
{
    private string Brand;
    private string Model;
    private int ProductionYear;
    private double EngineCapacity;
    private bool IsDiesel;
    private DateTime PurchaseDate;
    private CarStatus Status;

    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        ProductionYear = 0;
        EngineCapacity = 0.0;
        IsDiesel = false;
        PurchaseDate = DateTime.Now;
        Status = CarStatus.Unknown;
    }

    public Car(string brand, string model, int productionYear) : this()
    {
        Brand = brand;
        Model = model;
        ProductionYear = productionYear;
    }

    public Car(string brand, string model, int productionYear, double engineCapacity) : this(brand, model,
        productionYear)
    {
        EngineCapacity = engineCapacity;
    }

    public Car(string brand, string model, int productionYear, double engineCapacity, bool isDiesel) : this(brand,
        model,
        productionYear, engineCapacity)
    {
        IsDiesel = isDiesel;
    }

    public Car(string brand, string model, int productionYear, double engineCapacity, bool isDiesel,
        DateTime purchaseDate, CarStatus status) : this(brand, model,
        productionYear, engineCapacity, isDiesel)
    {
        PurchaseDate = purchaseDate;
        Status = status;
    }

    public void GetInfo()
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"ProductionYear: {ProductionYear}");
        Console.WriteLine($"EngineCapacity: {EngineCapacity}");
        Console.WriteLine($"IsDiesel: {IsDiesel}");
        Console.WriteLine($"PurchaseDate: {PurchaseDate.ToShortDateString()}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"OwnershipYears: {CalculateOwnershipYears()}");
        Console.WriteLine("----------------------------------------------");
    }

    public string CalculateOwnershipYears()
    {
        int time = DateTime.Today.Year - PurchaseDate.Year;
        if (PurchaseDate.Month > DateTime.Today.Month ||
            PurchaseDate.Month == DateTime.Today.Month && PurchaseDate.Day > DateTime.Today.Day) time--;
        return time.ToString();
    }
}