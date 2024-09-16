namespace KartkowkaDziedziczenie.Classes;

public class Car : Vehicle
{
    private int NumberOfDoors;

    public Car(string brand, string model, int numberOfDoors) : base(brand, model)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of doors: {NumberOfDoors}");
    }
}