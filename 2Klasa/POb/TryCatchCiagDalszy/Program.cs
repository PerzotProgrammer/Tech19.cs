namespace TryCatchCiagDalszy;

class Program
{
    static void Main()
    {
        Zadanie1();
        Zadanie2();
    }

    static void Zadanie1()
    {
        // Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
        // Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
        // Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
        // Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.

        bool loop = true;
        while (loop)
        {
            try
            {
                Console.Write("Podaj liczbę całkowitą nieujemną: ");
                long liczba = Convert.ToInt64(Console.ReadLine());
                if (liczba < 0) throw new ArgumentOutOfRangeException();
                Console.WriteLine($"Pierwiastek kwadratowy liczby {liczba}: {Math.Sqrt(liczba)}");
            }
            catch (FormatException)
            {
                ColorWrite("Nieprawidłowe dane!", ConsoleColor.Red);
            }
            catch (ArgumentOutOfRangeException)
            {
                ColorWrite("Liczba jest ujemna!", ConsoleColor.Red);
            }
            catch (OverflowException)
            {
                ColorWrite("Liczba poza zakresem!", ConsoleColor.Red);
            }
            finally
            {
                Thread.Sleep(1000);
                loop = ContinueLoop();
                ColorWrite("Dziękujemy za użycie programu!\nKontynuacja za 5 sekund.", ConsoleColor.Green);
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }

    static void Zadanie2()
    {
        // Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.
        // Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem.
        // Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException
        // i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException
        // i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q.
        // Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException
        // i wyświetlić odpowiedni komunikat.
        // Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.

        bool loop = true;
        while (loop)
        {
            bool innerLoop;
            int[] Tab = new int[5];
            for (int i = 0; i < Tab.Length; i++)
            {
                innerLoop = true;
                while (innerLoop)
                {
                    try
                    {
                        Console.Write($"Podaj {i + 1} liczbę: ");
                        Tab[i] = Convert.ToInt32(Console.ReadLine());
                        innerLoop = false;
                    }
                    catch (FormatException)
                    {
                        ColorWrite("To nie jest prawidłowa liczba!", ConsoleColor.Red);
                    }
                    catch (OverflowException)
                    {
                        ColorWrite("Liczba jest poza zakresem!", ConsoleColor.Red);
                    }
                }
            }

            ColorWrite("Dobrze!", ConsoleColor.Green);
            Console.WriteLine("To teraz podaj indeks z jakiego chcesz odczytać dane");
            innerLoop = true;
            while (innerLoop)
            {
                try
                {
                    Console.Write("Indeks: ");
                    int indeks = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Twoja liczba: {Tab[indeks]}");
                    innerLoop = false;
                }
                catch (FormatException)
                {
                    ColorWrite("To nie jest prawidłowa liczba!", ConsoleColor.Red);
                }
                catch (IndexOutOfRangeException)
                {
                    ColorWrite("Nie ma takiego indeksu!", ConsoleColor.Red);
                }
            }

            loop = ContinueLoop();
        }
    }

    static void ColorWrite(string? message, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static bool ContinueLoop()
    {
        Console.Write("Czy chcesz wyjść z programu? (q): ");
        string? wybor = Console.ReadLine();
        if (wybor == "q" || wybor == "Q") return false;
        return true;
    }
}