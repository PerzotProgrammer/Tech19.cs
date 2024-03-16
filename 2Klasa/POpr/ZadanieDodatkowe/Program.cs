using ZadanieDodatkowe.Classes;

namespace ZadanieDodatkowe;

class Program
{
    static void Main()
    {
        Zad1();
        Zad2();
        Zad3();
        Zad4();
        Zad5();
        Zad6();
        Zad7();
        Zad8();
    }

    static void Zad1()
    {
        // 1. Wpisz do tablicy n liczb podanych przez usera w sposób 
        // rosnący i wypisz te z nich, które są "portugalskie".
        // Przez liczby portugalskie rozumiemy liczby samotne czyli takie które nie 
        // mają sąsiada w otoczeniu 2.
        // WE: 5
        // 3 7 9 13 19
        // WY:
        // 3 13 19

        Console.Write("Podaj ile liczb lolu: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.Write($"Podaj {i + 1} liczbę: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            catch (Exception)
            {
                ColorWriteLine("TO NIE JEST PRAWIDŁOWA LICZBA LOLU!", ConsoleColor.Red);
                i--;
            }
        }

        Array.Sort(arr); // na wszelki
        int[] temp = new int[n];
        int removes = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] + 2 >= arr[i + 1])
            {
                temp[removes] = arr[i];
                removes++;
                i++;
                temp[removes] = arr[i];
                removes++;
            }
        }

        int[] output = new int[n - removes];
        int index = 0;
        foreach (int i in arr)
        {
            if (!temp.Contains(i))
            {
                output[index] = i;
                index++;
            }
        }

        Console.Write("Twoje portugale lolu: ");
        PrintArray(output);
    }

    static void Zad2()
    {
        // 2. User podaje dowolny werset z Pana Tadeusza. Sprawdź czy w tym wersecie jakaś
        // literka występuje co najmniej 3 razy. Użyj tablic (toCharArray())

        Console.Write("Podaj stringa lolu: ");
        string part = Console.ReadLine()!;

        char[] partChr = part.ToLower().ToCharArray(); //Po co? można na stringu jechać

        Dictionary<char, int> freq = new();

        foreach (char c in partChr)
        {
            if (!freq.TryAdd(c, 1)) freq[c]++;
            if (freq[c] > 2)
            {
                Console.WriteLine($"Jest tutaj literka {c} co jest 3 razy (dalej nie sprawdzam)");
                return;
            }
        }

        Console.WriteLine("Nie masz takiej literki co 3 razy jest :(");
    }

    static void Zad3()
    {
        // 3. User podaje dwie liczby brytyjskie. Przez liczby brytyjskie rozumiemy dwie 
        // dowolne liczby dwucyfrowe różniące się przynajmniej o 50.
        // Zapisz do listy wszystkie liczby pierwsze znajdujące się 
        // między powyższymi liczbami.

        Console.WriteLine("Podaj dwie liczby lolu: ");
        Console.Write("Pierwsza: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Druga: ");
        int b = int.Parse(Console.ReadLine()!);

        if (a > b + 50 && b > a + 50)
        {
            ColorWriteLine("Miały być o 50 różne!", ConsoleColor.Red);
            return;
        }

        List<int> primes = new();

        for (int i = Math.Min(a, b); i < Math.Max(a, b); i++)
        {
            if (IsPrime(i)) primes.Add(i);
        }

        Console.Write("Twoje brytole lolu: ");
        PrintArray(primes);
    }

    static void Zad4()
    {
        // 4. Utwórz strukturę losowych osób z losowymi danymi. Zasady:
        // - wiek między 20 a 50 lat
        // - imię 4 literowe zaczynająca się na A.
        // - Nazwisko to odwrócenie imienia.
        // Wylosuj takie 4 osoby i dodaj je do listy Osób. User nic tu nie wprowadza.

        Person[] persons = { new(), new(), new(), new() };

        Console.WriteLine("Twoi ludzie lolu:");
        foreach (Person person in persons)
        {
            Console.WriteLine(person.GetInfo());
        }
    }

    static void Zad5()
    {
        // 5. Utwórz kolejkę liczb doskonałych 
        //         (liczby które równają się sumie swoich dzielników właściwych). 
        //     Umieść w niej 4 najmniejszych liczb doskonałych.
        //     Wyświtl kolejkę, usuń z niej 2 liczby i znów wyświtl to co zostało.

        Queue<int> queue = new();
        int num = 1;
        while (queue.Count < 4) // brute force
        {
            if (IsPerfect(num)) queue.Enqueue(num);
            num++;
        }

        Console.WriteLine("Twoja kolejka lolu:");
        PrintArray(queue);
        Console.WriteLine("A tu po usunięciu:");
        queue.Dequeue();
        queue.Dequeue();
        PrintArray(queue);
    }

    static void Zad6()
    {
        // 6. Stwórz stos nieparzystych dwucyfrowych wieloktorności liczby 13.
        //     Usuń z tego stosu 2 liczby i wyświetl znów ten stos 
        // dziwiąc się temu co na nim zostało.

        Stack<int> stack = new();

        for (int i = 13; i < 100; i += 13)
        {
            if (i % 2 != 0) stack.Push(i);
        }

        Console.WriteLine("Twój stos lolu:");
        PrintArray(stack);
        Console.WriteLine("A tu po usunięciu:");
        stack.Pop();
        stack.Pop();
        PrintArray(stack);
    }

    static void Zad7()
    {
        // 7. Kod Hufmanna to zamiana ciągu w stylu AAAAABBBBBBBCCC na 5A7B3C.
        //     Niech user poda wam n ciągów które zapiszecie to zwykłej tablicy.
        //     Potem przenieście te dane do słowinika, gdzie kluczem będzie kod ciągu
        //     a wartością ten ciąg.

        Dictionary<char, int> freq = new();
        Console.Write("Daj coś dla Hufmanna: ");

        string preHufmann = Console.ReadLine()!.ToUpper();
        foreach (char c in preHufmann)
        {
            if (!freq.TryAdd(c, 1)) freq[c]++;
        }

        string postHufmann = "";
        foreach (KeyValuePair<char, int> pair in freq)
        {
            postHufmann += pair.Value.ToString() + pair.Key;
        }

        Console.WriteLine($"Twój Hufmann: {postHufmann}");
    }

    static void Zad8()
    {
        // 8. Stwórz graf składający się z 6 wierzchołków i 7 krawędzi. 
        //     Wypisz najwyższy stopień wierzchołka. Jeśli kilka wierzchołków ma ten sam stopień
        //     to wypisz dowolny z nich.

        Graph graph = new();

        Node n1 = new(1);
        Node n2 = new(2);
        Node n3 = new(3);
        Node n4 = new(4);
        Node n5 = new(5);
        Node n6 = new(6);
        
        graph.AddToGraph(n1);
        graph.AddToGraph(n2);
        graph.AddToGraph(n3);
        graph.AddToGraph(n4);
        graph.AddToGraph(n5);
        graph.AddToGraph(n6);
        
        n1.MakeJoints(n5);
        n1.MakeJoints(n2);
        n2.MakeJoints(n5);
        n2.MakeJoints(n3);
        n3.MakeJoints(n4);
        n4.MakeJoints(n5);
        n4.MakeJoints(n6);

        graph.PrintJoints();
        Console.Write("Najwyższy lolu: ");
        Console.WriteLine(graph.FindHighestDegree());

    }

    static bool IsPrime(int integer)
    {
        for (int i = 2; i < integer; i++)
        {
            if (integer % i == 0) return false;
        }

        return true;
    }

    static bool IsPerfect(int integer)
    {
        int sumOfDivs = 0;
        for (int i = 1; i < integer; i++)
        {
            if (integer % i == 0) sumOfDivs += i;
        }

        if (integer == sumOfDivs) return true;
        return false;
    }

    static void PrintArray<T>(IEnumerable<T> arr)
    {
        foreach (T i in arr)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine();
    }

    static void ColorWriteLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
