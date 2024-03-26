using SamochodyCiagDalszy.Classes;

namespace SamochodyCiagDalszy;

class Program
{
    static List<Car> Cars = new();
    static bool loopFlag = true;

    static void Main()
    {
        Console.WriteLine("Witaj w menu wyboru samochodów!");
        while (loopFlag)
        {
            Menu();
        }
    }

    static void Menu()
    {
        Console.WriteLine("\nWybierz opcje:");
        Console.WriteLine("1: dodaj samochód");
        Console.WriteLine("2: wyświetl dane");
        Console.WriteLine("3: oblicz wiek");

        switch (Console.ReadKey().ToString())
        {
            case "1":
                AddCar();
                break;
            case "2":
                PrintData();
                break;
            default:
                Console.WriteLine("\nNIEPOPRAWNA OPCJA!");
                break;
        }
    }

    static void AddCar()
    {
        throw new NotImplementedException();
    }

    static void PrintData()
    {
        throw new NotImplementedException();
    }
}