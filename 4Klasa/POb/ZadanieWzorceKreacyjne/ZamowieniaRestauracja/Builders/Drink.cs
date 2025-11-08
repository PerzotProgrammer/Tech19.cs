using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

public class Drink
{
    public string DrinkType { get; private set; } = "";
    public string Size { get; private set; } = "";


    public Drink SetDrinkType(DrinkType drinkType)
    {
        DrinkType = drinkType.ToString();
        return this;
    }

    public Drink SetDrinkSize(Size size)
    {
        Size = size.ToString();
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