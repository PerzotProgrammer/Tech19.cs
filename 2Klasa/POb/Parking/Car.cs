namespace Parking;

public enum Color
{
    Red,
    Blue,
    Green,
    Black,
    White
}

public class Car(string Brand, string Model, int Year, Color Color)
{
    public void ShowInformation()
    {
        Console.WriteLine($"This is {Brand} {Model} from {Year}, color {Color}");
    }
}
