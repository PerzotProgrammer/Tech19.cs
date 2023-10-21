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

        StreamReader users = new("../../../data/users.txt");
        int index = 0;
        while (!users.EndOfStream)
        {
            UsersDB[index] = users.ReadLine();
            index++;
        }

        index = 0;
        StreamReader passwds = new("../../../data/passwds.txt");
        while (!passwds.EndOfStream)
        {
            PasswdsDB[index] = passwds.ReadLine();
            index++;
        }

        for (int i = 0; i < UsersDB.Length; i++)
        {
            if (user == UsersDB[i] && passwd == PasswdsDB[i])
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
        float promil = random.Next(0, 100) / 100f;

        if (promil < 0.2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{user} jesteś prawie trzeźwy, masz {promil} promili.");
            Console.ForegroundColor = ConsoleColor.Gray;
            return true;
        }

        if (promil < 0.6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"{user} jesteś prawie pijany, masz {promil} promili, lecz zezwalamy na użycie programu.");
            Console.ForegroundColor = ConsoleColor.Gray;
            return true;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{user} jesteś pijany, masz {promil} promili i nie możesz korzystać z tego progamu.");
        Console.ForegroundColor = ConsoleColor.Gray;
        return false;
    }

    // Obliczanie
    static void Obliczanie()
    {
        bool continueLoop = true;

        Console.WriteLine("To jak już możesz liczyć to daj jakieś działanie matematyczne.");
        DataTable dataTable = new();

        while (continueLoop)
        {
            Console.Write("Działanie: ");
            string? expr = Console.ReadLine();

            if (Validate(expr))
            {
                var v = dataTable.Compute(expr, "");
                Console.WriteLine($"Wynik: {v}");
                continueLoop = ContinueLoop();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawne działanie!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }

    // Funkcja walidująca poprawność działania matematycznego
    static bool Validate(string? expr)
    {
        string valids = "1234567890+-*/";
        bool isValid = true;

        if (expr == null) return false;

        foreach (var element in expr)
        {
            bool flag = false;
            foreach (char valid in valids)
            {
                if (element == valid) flag = true;
                if (flag) break;
            }

            if (!flag)
            {
                isValid = false;
                break;
            }
        }

        if (!isValid) return false;
        if (!((int.TryParse(expr[0].ToString(), out _) || expr[0] == '+' || expr[0] == '-') &&
              int.TryParse(expr[^1].ToString(), out _))) return false;

        return true;
    }

    // Funkcja pytająca o kontynuacje pętli
    static bool ContinueLoop()
    {
        Console.WriteLine("Czy chcesz kontynuować? tak/nie");
        while (true)
        {
            string? wybor = Console.ReadLine();
            if (wybor == "tak" || wybor == "t")
            {
                Console.Clear();
                return true;
            }

            if (wybor == "nie" || wybor == "n")
            {
                Console.Clear();
                return false;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj prawidłowe dane!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}