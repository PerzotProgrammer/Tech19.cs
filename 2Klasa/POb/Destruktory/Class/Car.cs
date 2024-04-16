namespace Destruktory.Class;

public class Car
{
    private string Brand;
    private string Model;
    private bool IsDamaged;
    private string DamageType;

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        IsDamaged = false;
        DamageType = "";
    }

    private void RandomDamage()
    {
        Random random = new();
        int rand = random.Next(1, 10);
        if (rand == 1)
        {
            IsDamaged = true;
            DamageType = "przebitą oponę";
            Console.WriteLine("Uszkodziłeś oponę!");
        }
        else if (rand == 2)
        {
            IsDamaged = true;
            DamageType = "zatarty silnik";
            Console.WriteLine("Zatarłeś silnik!");
        }
    }

    public string GetName()
    {
        return $"{Brand} {Model}";
    }

    public void Drive()
    {
        if (IsDamaged)
        {
            Console.WriteLine($"Samochód {GetName()} ma {DamageType} i nie może jechać!");
            return;
        }

        Console.WriteLine($"Samochód {GetName()} jedzie!");
        RandomDamage();
    }

    ~Car() // Trochę to nie działa
    {
        Console.WriteLine($"Samochód {Brand} {Model} się zniszczył");
    }
}