using KartkowkaDziedziczenie.Classes;

namespace KartkowkaDziedziczenie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stwórz swój samochód");

        string cBrand = StrNullCheck("Podaj markę: ");
        string cModel = StrNullCheck("Podaj model: ");
        int numOfSeats = NumberCheck("Podaj ilość siedzeń: ");

        Car car = new Car(cBrand, cModel, numOfSeats);
        car.DisplayInfo();

        Console.WriteLine("Stwórz swój motocykl");
        string mBrand = StrNullCheck("Podaj markę: ");
        string mModel = StrNullCheck("Podaj model: ");
        bool hasSidecar = BoolCheck("Czy posiada kosz? (tak/nie): ");

        Motorcycle motorcycle = new Motorcycle(mBrand, mModel, hasSidecar);
        motorcycle.DisplayInfo();
    }

    static int NumberCheck(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (!int.TryParse(Console.ReadLine(), out int result) || result <= 0)
            {
                Console.WriteLine("Niepoprawna liczba");
            }
            else return result;
        }
    }

    static bool BoolCheck(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (input == "tak") return true;
            if (input == "nie") return false;
            Console.WriteLine("Niepoprawny boolean");
        }
    }

    static string StrNullCheck(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Nazwa nie może być pusta!");
            }
            else if (input != null) return input;
        }
    }
}