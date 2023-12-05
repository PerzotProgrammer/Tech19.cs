// grupa 2
// Napisz program, który:
//
// Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
//     Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
// P=a2
//
// Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
// O=4a
//
//     W funkcji Main:
// Deklaruje zmienną n i przypisuje jej wartość 5.
//     Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
//     Wyświetla na ekranie zawartość tablicy tablica.
//
//     Dla każdego elementu tablicy tablica:
// Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
//     Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
//
//     Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
//     Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu
//
// DO NAZWY ZMIENNEJ DODAĆ 2


namespace Sprawdzian05._12;

class Program
{
    static void Main()
    {
        KolorowyPrint2("Program obliczający pole i obwód kwadratu o danym boku", ConsoleColor.Cyan);
        int n2 = 5;
        int[] Tablica2 = UtworzTabliceLiczb2(n2);
        Console.WriteLine("Twoja tablica:");
        PrintujTablice2(Tablica2);

        int[] Pola2 = new int[Tablica2.Length];
        int[] Obwody2 = new int[Tablica2.Length];

        for (int i = 0; i < Tablica2.Length; i++)
        {
            Pola2[i] = ObliczPole2(Tablica2[i]);
            Obwody2[i] = ObliczObwod2(Tablica2[i]);
        }

        int index2 = DajIndex2(n2);

        PrintujDanyIndex2(index2, Pola2, Obwody2);
    }

    static int[] UtworzTabliceLiczb2(int n2)
    {
        int[] returnTab2 = new int[n2];
        int index2 = 0;
        while (index2 < n2)
        {
            try
            {
                Console.Write($"Podaj {index2 + 1} element tablicy: ");
                returnTab2[index2] = Convert.ToInt32(Console.ReadLine());
                if (returnTab2[index2] <= 0) throw new ArgumentException();
                index2++;
            }
            catch (OverflowException)
            {
                KolorowyPrint2("Liczba jest za duża!", ConsoleColor.Red);
            }
            catch (FormatException)
            {
                KolorowyPrint2("Nie można przekonwertować na liczbę całkowitą!", ConsoleColor.Red);
            }
            catch (ArgumentException)
            {
                KolorowyPrint2("Bok kwadratu nie może być liczbą ujemną, bądź równy 0!", ConsoleColor.Red);
            }
        }

        return returnTab2;
    }

    static int ObliczPole2(int a2)
    {
        return a2 * a2;
    }

    static int ObliczObwod2(int a2)
    {
        return a2 * 4;
    }

    static void PrintujTablice2(int[] Tab2)
    {
        foreach (int element2 in Tab2) Console.Write($"{element2}, ");
        Console.WriteLine();
    }

    static int DajIndex2(int maxIndex2)
    {
        int index2 = int.MaxValue;
        bool flag2 = true;
        KolorowyPrint2("Pamiętaj, że index = element - 1", ConsoleColor.Cyan);
        while (flag2)
        {
            try
            {
                Console.WriteLine("Podaj indeks, który chcesz sprawdzić: ");
                index2 = Convert.ToInt32(Console.ReadLine());
                if (index2 > maxIndex2 - 1 || index2 < 0) throw new ArgumentException();

                flag2 = false;
            }
            catch (OverflowException)
            {
                KolorowyPrint2("Liczba jest za duża lub za mała!", ConsoleColor.Red);
            }
            catch (FormatException)
            {
                KolorowyPrint2("Nie można przekonwertować na liczbę całkowitą!", ConsoleColor.Red);
            }
            catch (ArgumentException)
            {
                KolorowyPrint2("Indeks nie jest w granicach tablicy!", ConsoleColor.Red);
            }
        }

        return index2;
    }

    static void PrintujDanyIndex2(int index2, int[] Pola2, int[] Obwody2)
    {
        Console.WriteLine($"Pole dla indexu {index2} to: {Pola2[index2]}");
        Console.WriteLine($"Obwód dla indexu {index2} to: {Obwody2[index2]}");
    }

    static void KolorowyPrint2(string wiadomosc2, ConsoleColor kolor2)
    {
        Console.ForegroundColor = kolor2;
        Console.WriteLine(wiadomosc2);
        Console.ResetColor();
    }
}