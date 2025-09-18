namespace HermetyzacjaDziedziczenie;

public class WashingMachine : Device
{
    private int _washingType;

    public WashingMachine()
    {
        _washingType = 0;
    }

    public void SetWashingType(int washingType)
    {
        if (washingType > 0 && washingType < 13) _washingType = washingType;
        else _washingType = 0;
    }

    public override void GetStatus()
    {
        Console.WriteLine($"Pralka ma włączony program numer: {_washingType}");
    }
}