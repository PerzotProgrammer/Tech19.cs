using SamochodyCiagDalszy.Classes;
using DriveType = SamochodyCiagDalszy.Classes.DriveType;

namespace SamochodyCiagDalszy;

class Program
{
    static List<Car> Cars = new();
    static bool loopFlag = true;

    static void Main()
    {
        Console.WriteLine("Witaj w menu wyboru samochodów!");
        while (loopFlag) Menu();
        Console.WriteLine("Naciśnij przycisk aby zamknąć program...");
        Console.ReadKey();
    }

    static void Menu()
    {
        Console.WriteLine("\nWybierz opcje:");
        Console.WriteLine("1: dodaj samochód");
        Console.WriteLine("2: wyświetl dane");
        Console.WriteLine("3: oblicz wiek");
        Console.WriteLine("4: sprawdź czy samochód jest klasykiem");
        Console.WriteLine("5: wyświetl dane w formacie JSON");
        Console.WriteLine("6: oblicz spalanie");
        Console.WriteLine("7: zamyka program");
        Console.WriteLine();
        Console.Write("Twój wybór: ");
        string chk = Console.ReadLine()!;
        Console.WriteLine();
        switch (chk)
        {
            case "1":
                AddCar();
                break;
            case "2":
                PrintData();
                break;
            case "3":
                PrintAge();
                break;
            case "4":
                CheckForClassic();
                break;
            case "5":
                PrintDataJSON();
                break;
            case "6":
                CalculateCompsumtion();
                break;
            case "7":
                ColorPrint("Dziękujemy za użycie programu!", ConsoleColor.Green);
                loopFlag = false;
                break;
            case "8": // DEBUG
                AddPlaceholder();
                break;
            default:
                ColorPrint("\nNIEPOPRAWNA OPCJA!", ConsoleColor.Red);
                break;
        }
    }

    static void AddCar()
    {
        try
        {
            Console.Write("Podaj markę: ");
            string brand = Console.ReadLine()!;

            Console.Write("Podaj model: ");
            string model = Console.ReadLine()!;

            Console.Write("Podaj rok produkcji: ");
            int yearOfProduction = int.Parse(Console.ReadLine()!);

            Console.Write("Podaj pojemność silnika (po przecinku): ");
            float engineCapacity = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Podaj datę rejestracji:");
            Console.Write("Dzień: ");
            int day = int.Parse(Console.ReadLine()!);

            Console.Write("Miesiąc: ");
            int month = int.Parse(Console.ReadLine()!);

            Console.Write("Rok: ");
            int year = int.Parse(Console.ReadLine()!);

            DateTime dateOfFirstRegistration = new(year, month, day);

            Console.Write("Podaj typ napędu (Petrol, Diesel, Electric, Hybrid): ");
            DriveType driveType = (DriveType)Enum.Parse(typeof(DriveType), Console.ReadLine()!);

            Cars.Add(new(brand, model, yearOfProduction, engineCapacity, dateOfFirstRegistration, driveType));
            ColorPrint("GOTOWE!", ConsoleColor.Green);
        }
        catch (Exception)
        {
            Console.WriteLine();
            ColorPrint("NIEPOPRAWNE DANE!", ConsoleColor.Red);
            Console.WriteLine("Spróbuj jeszcze raz");
            Console.WriteLine();
            AddCar();
        }
    }

    static void PrintData()
    {
        Console.WriteLine($"W systemie znajdują się {Cars.Count} samochody/ów");

        for (int i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"Samochód nr {i + 1}");
            Console.WriteLine(Cars[i].GetInfo());
            Console.WriteLine("-----------------------------");
        }
    }

    static void PrintAge()
    {
        if (Cars.Count > 0)
        {
            try
            {
                Console.Write($"Wybierz odpowiedni samochód (1 - {Cars.Count}): ");
                int select = int.Parse(Console.ReadLine()!) - 1;

                Console.WriteLine($"Wiek samochodu nr {select + 1} wynosi {Cars[select].GetAge()} lat");
            }
            catch (Exception)
            {
                ColorPrint("NIEPOPRAWNE DANE!", ConsoleColor.Red);
                Console.WriteLine("Spróbuj jeszcze raz");
                Console.WriteLine();
                PrintAge();
            }
        }
        else Console.WriteLine("Nie ma jeszcze żadnych samochodów w systemie");
    }

    static void CheckForClassic()
    {
        if (Cars.Count > 0)
        {
            try
            {
                Console.Write($"Wybierz odpowiedni samochód (1 - {Cars.Count}): ");
                int select = int.Parse(Console.ReadLine()!) - 1;

                string message = Cars[select].IsClassic()
                    ? "Tak, samochód jest klasykiem"
                    : "Nie, samochód nie jest klasykiem";

                Console.WriteLine(message);
            }
            catch (Exception)
            {
                ColorPrint("NIEPOPRAWNE DANE!", ConsoleColor.Red);
                Console.WriteLine("Spróbuj jeszcze raz");
                Console.WriteLine();
                CheckForClassic();
            }
        }
        else Console.WriteLine("Nie ma jeszcze żadnych samochodów w systemie");
    }

    static void PrintDataJSON()
    {
        if (Cars.Count > 0)
        {
            try
            {
                Console.Write($"Wybierz odpowiedni samochód (1 - {Cars.Count}): ");
                int select = int.Parse(Console.ReadLine()!) - 1;

                Console.WriteLine(Cars[select].GetInfoJSON());
            }
            catch (Exception)
            {
                ColorPrint("NIEPOPRAWNE DANE!", ConsoleColor.Red);
                Console.WriteLine("Spróbuj jeszcze raz");
                Console.WriteLine();
                PrintDataJSON();
            }
        }
        else Console.WriteLine("Nie ma jeszcze żadnych samochodów w systemie");
    }

    static void CalculateCompsumtion()
    {
        try
        {
            Console.Write("Podaj poziom paliwa (l, przecinek): ");
            float fuelLvl = float.Parse(Console.ReadLine()!);

            Console.Write("Podaj przebytą trasę (km, przecinek): ");
            float distance = float.Parse(Console.ReadLine()!);

            Console.Write($"Wybierz odpowiedni samochód (1 - {Cars.Count}): ");
            int select = int.Parse(Console.ReadLine()!) - 1;

            Console.WriteLine(
                $"Spalanie dla samochodu nr {select + 1} to {Cars[select].AvgFuelUsage(fuelLvl, distance) * 100} dm^3/100 km");
        }
        catch (Exception)
        {
            ColorPrint("NIEPOPRAWNE DANE!", ConsoleColor.Red);
            Console.WriteLine("Spróbuj jeszcze raz");
            Console.WriteLine();
            CalculateCompsumtion();
        }
    }

    static void AddPlaceholder()
    {
        Random random = new();
        Cars.Add(new(RandomStringGenerator(random.Next(3, 10)),
            RandomStringGenerator(random.Next(3, 10)),
            random.Next(1950, DateTime.Now.Year),
            (float)Math.Round(random.NextSingle(), 2, MidpointRounding.ToZero),
            new(random.Next(1950, DateTime.Now.Year - 1), random.Next(1, 12), random.Next(1, 28)),
            (DriveType)random.Next(1, 4)));

        ColorPrint("Użyto narzędzi Debugu!", ConsoleColor.Yellow);
    }

    static string RandomStringGenerator(int lengthOfString)
    {
        Random random = new();
        string valids = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        string output = "";
        for (int i = 0; i < lengthOfString; i++) output += valids[random.Next(0, valids.Length)];
        return output;
    }

    static void ColorPrint(string message, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}