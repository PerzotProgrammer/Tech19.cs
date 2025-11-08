using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

public class Drink
{
    public DrinkType DrinkType { get; private set; } = DrinkType.Undefined;
    public Size Size { get; private set; } = Size.Undefined;


    public Drink SetDrinkType(DrinkType drinkType)
    {
        DrinkType = drinkType;
        return this;
    }

    public Drink SetDrinkSize(Size size)
    {
        Size = size;
        return this;
    }

    public void Describe()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Drink");
        Console.WriteLine($"Drink type: {DrinkType.ToString()}");
        Console.WriteLine($"Size: {Size.ToString()}");
        Console.WriteLine("------------------");
    }
}