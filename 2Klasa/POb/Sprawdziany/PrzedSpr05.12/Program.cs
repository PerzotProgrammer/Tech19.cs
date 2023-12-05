namespace PrzedSpr05._12;

class Program
{
    static void Main()
    {
        // Napisz program, który:
        //
        // Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
        //
        //     Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
        // P=a2
        //
        // Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
        // O=4a
        //
        //     W funkcji Main:
        // Deklaruje zmienną n i przypisuje jej wartość 5.
        //
        //     Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
        //
        //     Wyświetla na ekranie zawartość tablicy tablica.
        //
        //     Dla każdego elementu tablicy tablica:
        // Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
        //     Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
        //     Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
        //
        //     Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu
        //
        int n = 5;
        int[] Tab = UtworzTabliceLiczb(n);
        PrintujTablice(Tab);
        int[] debug = { 6, 7, 5, 6 };
        PrintujPoleIObwod(Tab);
    }

    static int ObliczPole(int a)
    {
        return a * a;
    }

    static int ObliczObwod(int a)
    {
        return a * 4;
    }

    static int[] UtworzTabliceLiczb(int n)
    {
        int[] retTab = new int[n];
        int index = 0;

        while (index < retTab.Length)
        {
            try
            {
                Console.Write($"Podaj {index + 1} element tablicy: ");
                retTab[index] = Convert.ToInt32(Console.ReadLine());
                index++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Niepoprawna liczba!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Za duży zakres liczby!");
            }
        }

        return retTab;
    }

    static void PrintujTablice(int[] Tab)
    {
        for (int i = 0; i < Tab.Length - 1; i++) Console.Write($"{Tab[i]}, ");
        Console.WriteLine(Tab[^1]);
    }

    static void PrintujPoleIObwod(int[] Tab)
    {
        while (true)
        {
            try
            {
                Console.Write("Podaj index elementu tablicy: ");
                int index = Convert.ToInt32(Console.ReadLine());
                int pole = ObliczPole(Tab[index]);
                int obwod = ObliczObwod(Tab[index]);
                Console.WriteLine($"Twoje pole to: {pole}");
                Console.WriteLine($"Twój obwód to: {obwod}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Niepoprawna liczba!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Za duży zakres liczby!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Nie ma takiego indeksu!");
            }
        }
    }
}