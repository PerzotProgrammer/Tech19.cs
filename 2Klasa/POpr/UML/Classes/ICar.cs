namespace UML.Classes;

public interface ICar
{
    void Build();
}

public class Chev : ICar
{
    public void Build()
    {
        Console.WriteLine("Chevy was build!");
    }
}

public class BMW : ICar
{
    public void Build()
    {
        Console.WriteLine("BMW was build!");
    }
}

public class Renault : ICar
{
    public void Build()
    {
        Console.WriteLine("Renault was build!");
    }
}

public class CarFactory
{
    private ICar Chev;
    private ICar BMW;
    private ICar Renault;

    public CarFactory(Chev chev, BMW bmw, Renault renault)
    {
        Chev = chev;
        BMW = bmw;
        Renault = renault;
    }

    public void BuildAll()
    {
        Chev.Build();
        BMW.Build();
        Renault.Build();
    }

    public void BuildChev()
    {
        Chev.Build();
    }

    public void BuildBMW()
    {
        BMW.Build();
    }

    public void BuildRenault()
    {
        Renault.Build();
    }
}