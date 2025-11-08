using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

[Serializable]
public class Fries
{
    public string FriesType { get; private set; } = "";
    public string Size { get; private set; } = "";

    public Fries SetFriesType(FriesType friesType)
    {
        FriesType = friesType.ToString();
        return this;
    }

    public Fries SetSize(Size size)
    {
        Size = size.ToString();
        return this;
    }


    public void Describe()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("FRIES");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Fries type: {FriesType}");
        Console.WriteLine("------------------");
    }
}