using System.Data;

namespace LogoAlkoLator;

static class Program
{
    // PROGRAM STWORZONY NA ZAJĘCIA PROJEKTOWANIA OPROGRAMOWANIA
    // Nie jest on stworzony na serio i nie sprawdza poziomu upojenia alkoholowego

    static void Main()
    {
        string? user = Logowanie();
        bool trzezwosc = Trzezwosc(user);
        if (trzezwosc) Obliczanie();
    }

    // Funkcja logująca
    static string? Logowanie()
    {
        string?[] UsersDB = new string[100];
        string?[] PasswdsDB = new string[100];

        // Wczytanie plików z danymi
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

        bool loggedIn = false;

        // Pętla logująca
        while (!loggedIn)
        {
            Console.Write("Podaj nazwę użytkownika: ");
            string? user = Console.ReadLine();
            Console.Write("Podaj hasło użytkownika: ");
            string? passwd = Console.ReadLine();

            for (int i = 0; i < UsersDB.Length; i++)
            {
                if (user == UsersDB[i] && passwd == PasswdsDB[i])
                {
                    Console.WriteLine("Logowanie udane!\n");
                    return user;
                }
            }

            Console.WriteLine("Logowanie nieudane!");
            loggedIn = !ContinueLoop("spróbować ponownie się zalogować");
        }

        return "niezalogowany";
    }

    // Sprawdzanie trzeźwości
    static bool Trzezwosc(string? user = "debug")
    {
        if (user == "niezalogowany") return false;
        // Losowanko, losowanko
        Random random = new();
        float promil = random.Next(0, 100) / 100f;

        if (promil < 0.2)
        {
            ColorWrite($"{user} jesteś prawie trzeźwy, masz {promil} promili.", ConsoleColor.Green);
            return true;
        }

        if (promil < 0.6)
        {
            ColorWrite($"{user} jesteś prawie pijany, masz {promil} promili, lecz zezwalamy na użycie programu.",
                ConsoleColor.Yellow);
            return true;
        }

        ColorWrite($"{user} jesteś pijany, masz {promil} promili i nie możesz korzystać z tego progamu.",
            ConsoleColor.Red);
        Console.WriteLine("Naciśnij przycisk aby zamknąć aplikację...");
        Console.ReadKey();
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
            // Taktyczny try chatch od Pana Szypera
            try
            {
                var v = dataTable.Compute(expr, "").ToString();
                double.TryParse(v, out double conv);
                if (double.IsInfinity(conv)) throw new DivideByZeroException();
                Console.WriteLine($"Wynik: {v}");
                continueLoop = ContinueLoop();
            }
            catch (DivideByZeroException)
            {
                ColorWrite("Nie można podzielić przez 0!", ConsoleColor.Red);
            }
            catch (SyntaxErrorException)
            {
                ColorWrite("Użyto złego znaku lub nie ma liczby przed lub po znaku!", ConsoleColor.Red);
            }
            catch (EvaluateException)
            {
                ColorWrite("Nie można obliczyć takiego wyrażenia!", ConsoleColor.Red);
            }
            catch (Exception)
            {
                ColorWrite("Błąd w wyrażeniu!", ConsoleColor.Red);
            }
        }
    }

    // Funkcja pytająca o kontynuacje pętli
    static bool ContinueLoop(string message = "kontynuować")
    {
        Console.WriteLine($"Czy chcesz {message}? tak/nie");
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

            ColorWrite("Podaj prawidłowe dane!", ConsoleColor.Red);
        }
    }

    static void ColorWrite(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}