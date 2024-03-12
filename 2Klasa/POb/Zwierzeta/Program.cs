using Zwierzeta.Classes;

namespace Zwierzeta;

class Program
{
    static void Main()
    {
        List<Animal> animals = new();

        ShowMainMenu(animals);

        Console.ReadKey();
    }

    private static void ShowMainMenu(List<Animal> animals)
    {
        Console.Clear();

        Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
        Console.WriteLine("1. Dodaj zwierzę");
        Console.WriteLine("2. Pokaż listę zwierząt");
        Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
        Console.WriteLine("4. Usuń zwierzę");
        Console.WriteLine("5. Zakończ program\n");
        Console.Write("Wybierz jedną z opcji: ");

        string choice = Console.ReadLine()!;

        switch (choice)
        {
            case "1":
                AddNewAnimal(animals);
                break;
            case "2":
                ShowAnimalList(animals);
                break;
            case "3":
                ShowAnimalDetails(animals);
                break;
            case "4":
                RemoveAnimal(animals);
                break;
            case "5":
                Console.WriteLine("Dziękujemy za skorzystanie z programu");
                break;
            default:
                Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie");
                Console.ReadKey();
                ShowMainMenu(animals);
                break;
        }
    }

    private static void AddNewAnimal(List<Animal> animals)
    {
        Console.Clear();

        Console.Write("Podaj nazwę zwierzęcia: ");
        string name = Console.ReadLine()!;
        Console.Write("Podaj datę urodzenia zwierzęcia (w formacie RRRR-MM-DD): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Czy zwierzę jest ssakiem? (tak/nie): ");
        bool isMammal = Console.ReadLine()!.ToLower() == "tak";
        Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Płaz, Ssak): ");
        Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine()!);

        Animal animal = new Animal(name, birthDate, isMammal, kind);

        animals.Add(animal);

        Console.WriteLine("\nDodano nowe zwierzę: " + animal.Name);
        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu głównego\n");
        Console.ReadKey();
        ShowMainMenu(animals);
    }

    private static void ShowAnimalList(List<Animal> animals)
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("W liście nie ma zwierząt!");
        }
        else
        {
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {animals[i].Name}");
            }
        }


        Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego\n");
        Console.ReadKey();
        ShowMainMenu(animals);
    }

    private static void ShowAnimalDetails(List<Animal> animals)
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("W liście nie ma zwierząt!");
        }
        else
        {
            Console.Write("Wybierz zwierzę do sprawdzenia: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            try
            {
                Console.WriteLine(animals[index].Describe());
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("W liście nie ma zwierzęcia o takim numerze!");
            }
        }

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego\n");
        Console.ReadKey();
        ShowMainMenu(animals);
    }

    private static void RemoveAnimal(List<Animal> animals)
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("W liście nie ma zwierząt!");
        }
        else
        {
            Console.Write("Wybierz zwierzę do usunięcia: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            try
            {
                animals.RemoveAt(index);
                Console.WriteLine("Sukces!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("W liście nie ma zwierzęcia o takim numerze!");
            }
        }

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego\n");
        Console.ReadKey();
        ShowMainMenu(animals);
    }
}