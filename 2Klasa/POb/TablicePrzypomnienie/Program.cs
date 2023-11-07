namespace TablicePrzypomnienie;

class Program
{
    static void Main()
    {
        Zadanie1();
        Console.WriteLine("----------------------------------");
        Zadanie2();
    }

    static void Zadanie1()
    {
        // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program wyświetla sumę wszystkich elementów tablicy.
        //
        // W celu zabezpieczenia programu przed niepoprawnymi danymi wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest liczbą całkowitą. Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.

        int[] Tab = new int[5];

        for (int i = 0; i < Tab.Length; i++)
        {
            Console.Write($"Podaj {i + 1} liczbę: ");
            int add;
            while (!int.TryParse(Console.ReadLine(), out add))
            {
                ColorWrite("Podaj liczbę!", ConsoleColor.Red);
                Console.Write($"Podaj {i + 1} liczbę: ");
            }

            Tab[i] = add;
        }

        Console.WriteLine($"Suma liczb w tablicy: {Tab.Sum()}");
    }

    static void Zadanie2()
    {
        // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy.
        //     Użyj języka programowania C# i środowiska Visual Studio.
        //     Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers.
        //     Użyj pętli for, aby pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers.
        //     Wyświetl na ekranie komunikat, który prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i zweryfikować.
        //     Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
        //     Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą całkowitą i przypisać ją do zmiennej input.
        //     Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
        //     Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers i zwrócić sumę.
        //     Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum.
        //     Wyświetl na ekranie komunikat, który pokazuje sumę podanych liczb.

        int[] Numbers = new int[5];

        for (int i = 0; i < Numbers.Length; i++) Numbers[i] = GetIntFromUser(i);
        Console.WriteLine($"Suma liczb w tablicy: {CalculateSumFromArray(Numbers)}");
    }

    static int GetIntFromUser(int index)
    {
        int numb;
        Console.Write($"Podaj {index + 1} liczbę: ");
        while (!int.TryParse(Console.ReadLine(), out numb))
        {
            ColorWrite("Podaj liczbę!", ConsoleColor.Red);
            Console.Write($"Podaj {index + 1} liczbę: ");
        }

        return numb;
    }

    static int CalculateSumFromArray(int[] Array)
    {
        int sum = 0;
        foreach (int number in Array) sum += number;
        return sum;
    }

    static void ColorWrite(string? message, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}