using Destruktory.Class;

namespace Destruktory;

class Program
{
    static Dictionary<int, Car?> CarsDict = new();
    static bool LoopFlag = true;

    static void Main()
    {
        Console.WriteLine("Symulator jazdy samochodem");
        while (LoopFlag)
        {
            Console.WriteLine();
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Stwórz samochód");
            Console.WriteLine("2. Wyświetl listę");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. Zniszcz samochód");
            Console.WriteLine("5. Wyjdź z programu");
            string? chk = Console.ReadLine();
            switch (chk)
            {
                case "1":
                    Car car = CreateCar();
                    Console.WriteLine($"Dodano samochód {car.GetName()}");
                    CarsDict.Add(CarsDict.Count + 1, car);
                    break;
                case "2":
                    ShowCars();
                    break;
                case "3":
                    DriveSelectedCar();
                    break;
                case "4":
                    DestroyCar();
                    break;
                case "5":
                    LoopFlag = false;
                    break;
                default:
                    Console.WriteLine("Niepoprawna operacja!");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Dziękujemy za skorzystanie z tego programu");
    }

    static Car CreateCar()
    {
        Console.Write("Marka: ");
        string brand = Console.ReadLine()!;
        Console.Write("Model: ");
        string model = Console.ReadLine()!;
        Car car = new(brand, model);
        return car;
    }

    static void ShowCars()
    {
        if (CarsDict.Count == 0)
        {
            Console.WriteLine("Nie ma na liście żadnego samochodu!");
            return;
        }

        Console.WriteLine("Lista samochodów:");
        foreach (KeyValuePair<int, Car?> pair in CarsDict) Console.WriteLine($"{pair.Key}: {pair.Value!.GetName()}");
    }

    static void DriveSelectedCar()
    {
        if (CarsDict.Count == 0)
        {
            Console.WriteLine("Nie ma na liście żadnego samochodu!");
            return;
        }

        try
        {
            Console.Write($"Wybierz samochód(1 - {CarsDict.Count}): ");
            int select = int.Parse(Console.ReadLine()!);
            CarsDict[select]!.Drive();
        }
        catch (Exception)
        {
            Console.WriteLine("NIEPOPRAWNE DANE!");
        }
    }

    static void DestroyCar()
    {
        if (CarsDict.Count == 0)
        {
            Console.WriteLine("Nie ma na liście żadnego samochodu!");
            return;
        }

        try
        {
            Console.Write($"Wybierz samochód(1 - {CarsDict.Count}): ");
            int select = int.Parse(Console.ReadLine()!);
            CarsDict[select] = null;
            CarsDict.Remove(select);
            Console.WriteLine("Samochód został zniszczony");
            GC.Collect();
        }
        catch (Exception)
        {
            Console.WriteLine("NIEPOPRAWNE DANE!");
        }
    }
}