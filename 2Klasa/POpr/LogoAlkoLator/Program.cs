using System.Data;

namespace LogoAlkoLator;

static class Program
{
    static void Main()
    {
        string? user = Logowanie();
        bool trzezwosc = Trzezwosc(user);
        if (trzezwosc) Obliczanie();
    }
    
    // SYSTEM LOGOWANIA
    static string? Logowanie()
    {
        Console.Write("Podaj nazwę użytkownika: ");
        string? user = Console.ReadLine();
        Console.Write("Podaj hasło użytkownika: ");
        string? passwd = Console.ReadLine();

        string?[] UsersDB = new string[100];
        string?[] PasswdsDB = new string[100];
        
        StreamReader users = new("users.txt");
        int index = 0;
        while (!users.EndOfStream)
        {
            UsersDB[index] = users.ReadLine();
            index++;
        }

        index = 0;
        StreamReader passwds = new("passwds.txt");
        while (!passwds.EndOfStream)
        {
            PasswdsDB[index] = passwds.ReadLine();
            index++;
        }

        for (int i = 0; i < UsersDB.Length; i++)
        {
            if(user == UsersDB[i] && passwd == PasswdsDB[i])
            {
                Console.WriteLine("Logowanie udane!");
                return user;
            }
        }

        Console.WriteLine("Logowanie nieudane!");
        return "niezalogowany";
    }
    
    // Sprawdzanie trzeźwości
    static bool Trzezwosc(string? user = "debug")
    {
        Random random = new();
        int los = random.Next(0,200);
        float promil = los / 100f;
        if (promil < 0.2)
        {
            Console.WriteLine($"{user} jesteś prawie trzeźwy, masz {promil} promili.");
            return true;
        }
        if (promil < 0.6)
        {
            Console.WriteLine($"{user} jesteś prawie pijany, masz {promil} promili, lecz zezwalamy na użycie programu.");
            return true;
        }
        Console.WriteLine($"{user} jesteś pijany, masz {promil} promili i nie możesz korzystać z tego progamu.");
        return false;
    }

    // Obliczanie
    // UWAGA!!! na razie nie obsługuje niepoprawnego działania
    static void Obliczanie()
    {
        Console.WriteLine("To jak już możesz liczyć to daj jakieś działanie matematyczne.");
        DataTable dataTable = new();
        Console.Write("Działanie: ");
        string? expr = Console.ReadLine();
        var v = dataTable.Compute(expr,"");
        Console.WriteLine($"Wynik: {v}");
    }
}