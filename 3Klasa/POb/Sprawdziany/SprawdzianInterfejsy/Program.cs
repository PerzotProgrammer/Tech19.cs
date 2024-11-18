using SprawdzianInterfejsy.Classes;

namespace SprawdzianInterfejsy;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Azor", "Pies", 2, "Jan Kowalski"),
            new Cat("Filemon", "Kot", 3, "Anna Nowak"),
            new Dog("Reksio", "Pies", 4, "Piotr Wiśniewski"),
            new Cat("Mruczek", "Kot", 1, "Katarzyna Zielińska")
        };

        Console.WriteLine("Witaj w naszym schronisku dla zwierząt!");
        Console.WriteLine("Oto lista zwierząt:");
        IterateOverAnimals(animals);
        while (true)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Wybierz jedną z opcji:");
            Console.WriteLine("1. Posortuj zwierzęta po właścicielu");
            Console.WriteLine("2. Posortuj zwierzęta po gatunku");
            Console.WriteLine("3. Posortuj zwierzęta po wieku");
            Console.WriteLine("4. Posortuj zwierzęta po imieniu");
            Console.WriteLine("5. Wyjdź");
            Console.WriteLine("--------------------------------");
            Console.Write("Podaj numer opcji: ");
            if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie.");
                Console.ResetColor();
                continue;
            }

            switch (option)
            {
                case 1:
                    SortByOwner(ref animals);
                    break;
                case 2:
                    SortBySpecies(ref animals);
                    break;
                case 3:
                    SortByAge(ref animals);
                    break;
                case 4:
                    SortByName(ref animals);
                    break;
                case 5:
                    Console.WriteLine("Do widzenia!");
                    return;
            }

            Console.WriteLine("Oto posortowana lista zwierząt:");
            IterateOverAnimals(animals);
        }
    }

    static void IterateOverAnimals(List<Animal> animals)
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine("--------------------------------");
            // Console.WriteLine($"{animal.Name} - {animal.Species} - {animal.Age} - {animal.Owner}");
            animal.MakeSound();
            animal.Eat();
        }
    }

    static void SortByOwner(ref List<Animal> animals)
    {
        animals = new List<Animal>(animals.OrderBy(animal => animal.Owner));
    }

    static void SortBySpecies(ref List<Animal> animals)
    {
        animals = new List<Animal>(animals.OrderBy(animal => animal.Species));
    }

    static void SortByAge(ref List<Animal> animals)
    {
        animals = new List<Animal>(animals.OrderBy(animal => animal.Age));
    }

    static void SortByName(ref List<Animal> animals)
    {
        animals = new List<Animal>(animals.OrderBy(animal => animal.Name));
    }
}