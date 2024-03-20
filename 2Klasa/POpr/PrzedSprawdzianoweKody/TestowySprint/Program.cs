namespace TestowySprint;

class Program
{
    static void Main()
    {
        Zad1();
        Console.WriteLine();
        Zad2();
        Console.WriteLine();
        Zad3();
        Console.WriteLine();
        Zad4();
        Console.WriteLine();
        Zad5();
    }

    static void Zad1()
    {
        // 1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych.
        // Stwórz tablicę W liczb parzystych znajdujących się między 
        // minimalną i maksymalną wartością z tablicy T.

        int[] T = new int[5];
        Random random = new();

        for (int i = 0; i < T.Length; i++) T[i] = random.Next(10, 99);

        int min = T.Min();
        int max = T.Max();

        int chk = min % 2 != 0 && max % 2 != 0 ? 0 : 1;

        int[] TRet = new int[(max - min) / 2 + chk];
        int index = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                TRet[index] = i;
                index++;
            }
        }

        Console.WriteLine($"Min: {min}\nMax: {max}");
        PrintArray(TRet);
    }

    static void Zad2()
    {
        // 2. Utwórz ArrayListę A zawierającą 10 losowych słów 3-literowych.
        // Wypisz słowo o najwiekszej sumie kodów ASCII jego liter

        List<string> words = new();
        for (int i = 0; i < 10; i++) words.Add(RandomStringGenerator(3));
        PrintArray(words);

        List<int> ASCIIvals = new();
        foreach (string word in words)
        {
            int ASCIIval = 0;
            foreach (char c in word) ASCIIval += c;
            ASCIIvals.Add(ASCIIval);
        }

        PrintArray(ASCIIvals);

        string output = words[ASCIIvals.IndexOf(ASCIIvals.Max())];
        Console.WriteLine(output);
    }

    static void Zad3()
    {
        // 3. Stwórz listę L składającą się z 10 list 10 losowych cyfr. Oblicz sumę największych cyfr w listach listy L oraz 
        // sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.

        List<List<int>> listOfLists = new();
        Random random = new();
        for (int i = 0; i < 10; i++)
        {
            listOfLists.Add(new());
            for (int j = 0; j < 10; j++) listOfLists[i].Add(random.Next(1, 10));
        }

        foreach (List<int> list in listOfLists) PrintArray(list);

        for (int i = 0; i < listOfLists.Count; i++)
        {
            Dictionary<int, int> freq = new();
            for (int j = 0; j < listOfLists[i].Count; j++)
            {
                if (!freq.TryAdd(listOfLists[i][j], 1)) freq[listOfLists[i][j]]++;
                if (freq[listOfLists[i][j]] == 3)
                    Console.WriteLine($"Liczba {listOfLists[i][j]} występuje przynajmniej 3 razy w liście {i},{j}!");
            }
        }
    }

    static void Zad4()
    {
        // 4. Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami 
        // w postaci listy maksmalnie (i-1)-cyfrowych dzielników liczby 10 do potęgi i dla każdego z kluczy.

        int n = 5; // ja podaje >:)
        Dictionary<int, List<int>> dict = new();
        List<int> list = new();

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < Math.Pow(10, i - 1); j++)
            {
                if (Math.Pow(10, i) % j == 0) list.Add(j);
            }

            dict.Add(i, new(list));
            list.Clear();
        }

        foreach (KeyValuePair<int, List<int>> pair in dict)
        {
            Console.Write($"{pair.Key}: ");
            PrintArray(pair.Value);
        }
    }

    static void Zad5()
    {
        // 5. Korzystając ze słownika utwórz graf G zbudowany z n wierzchołków i k krawędzi.
        // Policz wierzchołki nie mające żadnych sąsiadów.

        Dictionary<int, List<int>> graph = new();
        for (int i = 0; i < 5; i++) graph.Add(i, new());
        AddJointInGraph(graph, 0, 2);
        AddJointInGraph(graph, 4, 2);
        AddJointInGraph(graph, 3, 4);

        int aloneNodes = 0;
        
        foreach (KeyValuePair<int,List<int>> pair in graph)
        {
            Console.Write($"{pair.Key} :");
            PrintArray(pair.Value);
            if (pair.Value.Count == 0) aloneNodes++;
        }

        Console.WriteLine($"Są {aloneNodes} samotne wierzchołki");
    }
    
    static void PrintArray<T>(IEnumerable<T> arr)
    {
        foreach (T i in arr) Console.Write($"{i}, ");
        Console.WriteLine();
    }

    static string RandomStringGenerator(int lengthOfString)
    {
        Random random = new();
        string valids = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        string output = "";
        for (int i = 0; i < lengthOfString; i++) output += valids[random.Next(0, valids.Length)];
        return output;
    }

    static void AddJointInGraph(Dictionary<int, List<int>> graph, int firstIndex, int secondIndex)
    {
        graph[firstIndex].Add(secondIndex);
        graph[secondIndex].Add(firstIndex);
    }
}