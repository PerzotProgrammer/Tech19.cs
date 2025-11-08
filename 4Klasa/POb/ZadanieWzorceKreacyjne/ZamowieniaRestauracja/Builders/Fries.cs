using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

[Serializable]
public class Fries
{
    public FriesType FriesType { get; private set; } = FriesType.Undefined;
    public Size Size { get; private set; } = Size.Undefined;

    public Fries SetFriesType(FriesType friesType)
    {
        FriesType = friesType;
        return this;
    }

    public Fries SetSize(Size size)
    {
        Size = size;
        return this;
    }

    public Fries Reset()
    {
        Size = Size.Undefined;
        FriesType = FriesType.Undefined;
        return this;
    }

    public void Describe()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("FRIES");
        Console.WriteLine($"Size: {Size.ToString()}");
        Console.WriteLine($"Fries type: {FriesType.ToString()}");
        Console.WriteLine("------------------");
    }
}