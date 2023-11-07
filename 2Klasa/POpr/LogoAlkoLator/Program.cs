using System.Data;

namespace LogoAlkoLator;

static class Program
{
    // PROGRAM STWORZONY NA ZAJĘCIA PROJEKTOWANIA OPROGRAMOWANIA
    // Nie jest on stworzony na serio i nie sprawdza poziomu upojenia alkoholowego

    static DataTable dataTable = new();

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
        for (int i = 0; !users.EndOfStream; i++) UsersDB[i] = users.ReadLine();

        StreamReader passwds = new("../../../data/passwds.txt");
        for (int i = 0; !passwds.EndOfStream; i++) PasswdsDB[i] = passwds.ReadLine();


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
        ColorWrite($"Urzytkowniku {user}, musimy sprawdzić czy nie jesteś pijany.", ConsoleColor.Yellow);


        Random random = new();
        string firstNum = random.Next(-100, 100).ToString();
        string secNum = random.Next(-100, 100).ToString();
        string op = random.Next(0, 3).ToString();

        switch (op)
        {
            case "0":
                op = "+";
                break;
            case "1":
                op = "-";
                break;
            case "2":
                op = "*";
                break;
            case "3":
                op = "/";
                break;
            default: // na wszelki wypadek
                op = "+";
                break;
        }

        string expr = firstNum + " " + op + " " + secNum;

        Console.Write($"Podaj wynik działania:\n{expr} = ");
        float input;
        while (!float.TryParse(Console.ReadLine(), out input))
        {
            ColorWrite("Nie poprawne dane!", ConsoleColor.Red);
            Console.Write($"Podaj wynik działania:\n{expr} = ");
        }

        var value = dataTable.Compute(expr, "").ToString();
        if (Convert.ToSingle(value) == input)
        {
            ColorWrite("\nWynik jest poprawny!\nMożesz korzystać z kalkulatora!\n", ConsoleColor.Green);
            return true;
        }

        ColorWrite("\nWynik niepoprawny!\nAlbo nie umiesz liczyć, albo jesteś pijany!\n", ConsoleColor.Red);
        return false;
    }

    // Obliczanie
    static void Obliczanie()
    {
        bool continueLoop = true;

        Console.WriteLine("To jak już możesz liczyć to daj jakieś działanie matematyczne.");

        while (continueLoop)
        {
            Console.Write("Działanie: ");
            string? expr = Console.ReadLine();
            // Taktyczny try chatch od Pana Szypera
            try
            {
                var value = dataTable.Compute(expr, "").ToString();
                double.TryParse(value, out double conv);
                if (double.IsInfinity(conv)) throw new DivideByZeroException();
                Console.WriteLine($"Wynik: {value}");
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