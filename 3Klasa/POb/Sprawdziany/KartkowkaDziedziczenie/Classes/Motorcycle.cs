namespace KartkowkaDziedziczenie.Classes;

public class Motorcycle : Vehicle
{
    private bool HasSidecar;

    public Motorcycle(string brand, string model, bool hasSidecar) : base(brand, model)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has sidecar: {HasSidecar}");
    }
}