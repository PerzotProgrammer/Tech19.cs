namespace Slowniki;

class Program
{
    static void Main()
    {
        // Wstep();
        // Zadanie1();
        Zadanie2();
    }

    static void Wstep()
    {
        Dictionary<int, string> dictionary1 = new()
        {
            { 1, "Franek" },
            { 2, "Jolka" },
            { 3, "Krzyś" },
            { 4, "Marysia" }
        };

        foreach (KeyValuePair<int, string> item in dictionary1)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        Console.WriteLine();

        Dictionary<string, int> dictionary2 = new()
        {
            { "wydatki", 500 },
            { "przychody", 900 },
            { "roznica", 400 }
        };

        Console.WriteLine($"Wydatki to: {dictionary2["wydatki"]}");
        Console.WriteLine($"Przychody to: {dictionary2["przychody"]}");
        Console.WriteLine($"Różnica to: {dictionary2["roznica"]}");

        Console.WriteLine();

        Dictionary<string, string> dictionary3 = new()
        {
            { "+ 48 123 456 789", "Katarzyna" },
            { "+ 48 522 423 234", "Krzysztof" },
            { "+ 48 675 235 265", "Misza" },
            { "+ 48 453 324 786", "Radek" },
            { "+ 48 809 523 093", "Ścieki" }
        };

        foreach (KeyValuePair<string, string> item in dictionary3)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }

    static void Zadanie1()
    {
        Dictionary<int, string> dictionary = new();

        Console.Write("Ile elementów chcesz wprowadzić?: ");
        int index = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < index; i++)
        {
            Console.Write($"Podaj {i + 1} element: ");
            dictionary.Add(i, Console.ReadLine()!);
        }

        Console.WriteLine("\n\nTwój słownik:");

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }

    static void Zadanie2()
    {
        // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
        //     Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
        //     Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
        // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
        //     Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
        //     Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
        //     Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
        // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.

        List<int> array = new();

        int length = 5;

        for (int i = 0; i < length;)
        {
            Console.Write($"Podaj {i + 1} element słownika: ");
            string? element = Console.ReadLine();
            try
            {
                int elInt = Convert.ToInt32(element);
                array.Add(elInt);
                Console.WriteLine("OK!");
                i++;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Element '{element}' nie jest liczbą!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Liczba nie jest w poprawnym zakresie!");
            }
        }

        Dictionary<int, int> dictionary = ZwrocSlownik(array);

        Console.WriteLine("\n\nTwój słownik:");
        foreach (KeyValuePair<int, int> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }

    static Dictionary<int, int> ZwrocSlownik(List<int>? arr)
    {
        Dictionary<int, int> dictionary = new();

        for (int i = 0; i < arr!.Count; i++)
        {
            if (!dictionary.ContainsKey(arr[i]))
            {
                int timesInArray = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        timesInArray++;
                    }
                }

                dictionary.Add(arr[i], timesInArray);
            }
        }

        return dictionary;
    }
}