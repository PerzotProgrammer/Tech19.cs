using System.Collections;

namespace SprintKolekcji;

class Program
{
    static void Main()
    {
        Zad0();
        Zad1();
        Zad2();
        Zad3();
        Zad4();
    }

    static void Zad0()
    {
        int[] tab = new int[11];
        // int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Ta tutaj jest małomiasteczkowa, bo avg = 6 wiec 5 poniżej i 5 powyżej
        // Console.WriteLine(TypeOfArrCheck(tab));
        try
        {
            Console.Write("Podaj 11 liczb: ");
            string[] input = Console.ReadLine()!.Split(" ");
            for (int i = 0; i < tab.Length; i++) tab[i] = int.Parse(input[i]);
        }
        catch (Exception) // Jeżeli user poda mniej niż 11 liczb lub się kopnie w zapisie
        {
            Console.WriteLine("Lolu, zepsułeś input :(");
            return;
        }

        Console.WriteLine($"Ów tablica jest {TypeOfArrCheck(tab)}");
    }

    static void Zad1()
    {
        Random random = new();
        int[] tab = new int[30];
        for (int i = 0; i < tab.Length; i++) tab[i] = random.Next(100, 1000);

        Console.WriteLine("Twój array:");
        PrintArray(tab);

        Console.WriteLine("Najdłuższy podciąg to:");
        int[] ascSub = LongestAscSubArr(tab);
        PrintArray(ascSub);

        Console.WriteLine($"Pierwszy i ostatni w podciągu to: {ascSub[0]} i {ascSub[^1]}");
        Console.WriteLine($"Suma elementów to: {ascSub.Sum()}");
    }

    static void Zad2()
    {
        List<int> lista1 = new();
        List<int> lista2 = new();
        List<int> lista3 = new();
        Dictionary<int, int> freq = new();
        Random random = new();

        for (int i = 0; i < 6;)
        {
            int rand = random.Next(0, 9);
            if (!lista1.Contains(rand))
            {
                lista1.Add(rand);
                i++;
            }
        }

        for (int i = 0; i < 6; i++) lista2.Add(lista1[random.Next(0, 6)]); // Pan Nowak mówił, abym to przemyślał.
        // Niby może się zdarzyć brak powtórek, ale szansa na to jest praktycznie znikoma.
        // Random musiałby, 6 razy z rzędu wylosować różne liczby z zakresu 0-5 więc chyba będzie ok.
        // Potem pomyślę.

        foreach (int i in lista1) freq.Add(i, 1);
        foreach (int i in lista2) freq[i]++;

        foreach (KeyValuePair<int, int> pair in freq)
        {
            if (pair.Value > 1)
            {
                for (int i = 0; i < pair.Value; i++) lista3.Add(pair.Key);
            }
        }

        Console.WriteLine("Listy wynikowe:");
        PrintArray(lista1);
        PrintArray(lista2);
        PrintArray(lista3);
    }

    static void Zad3()
    {
        string allowed = "ABCD";
        ArrayList anagrams = new();
        Random random = new();

        for (int i = 0; i < 30; i++)
        {
            string builder = "";
            for (int j = 0; j < 3; j++) builder += allowed[random.Next(0, allowed.Length)];
            if (!anagrams.Contains(builder)) anagrams.Add(builder);
        }

        ArrayList pairs = new();

        foreach (object anagram1 in anagrams)
        {
            string check1 = anagram1.ToString()!;

            foreach (object anagram2 in anagrams)
            {
                string check2 = anagram2.ToString()!;
                if (AreAnagrams(check1, check2) && check1 != check2) pairs.Add($"{check1} - {check2}");
            }
        }

        foreach (object pair in pairs) Console.WriteLine(pair.ToString());
    }

    static void Zad4()
    {
        // Zrobione częściowo bez backtrackingu drogi.
        // Moja wersja sprawdza jedynie, czy z a przejdziesz do b.
        // Chyba nie jestem tym szóstkowiczem :(
        Dictionary<int, bool[]> matrix = new();
        for (int i = 1; i <= 5; i++) matrix.Add(i, [false, false, false, false, false, false]);

        MakeJoints(matrix, 1, 2);
        MakeJoints(matrix, 2, 3);
        MakeJoints(matrix, 2, 5);
        PrintDict(matrix);
        UpoDfs(matrix, 1, 3);
    }

    // Metoda helper do zad 0
    static string TypeOfArrCheck(int[] arr)
    {
        int aboveAvgCount = 0;
        int belowAvgCount = 0;
        foreach (int i in arr)
        {
            if (arr.Average() < i) aboveAvgCount++;
            if (arr.Average() > i) belowAvgCount++;
        }

        if (aboveAvgCount > belowAvgCount) return "wielkomiejska";
        if (aboveAvgCount < belowAvgCount) return "małorolna";
        return "małomiasteczkowa";
    }
    
    // Metoda helper do zad 1
    static int[] LongestAscSubArr(int[] arr)
    {
        List<int> best = new();
        List<int> check = new();
        check.Add(arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                if (check.Count >= best.Count) best = new(check); // Musi być new, bo inaczej będzie to referencja
                check.Clear();
            }

            check.Add(arr[i]);
        }

        return best.ToArray();
    }
    
    // Metoda helper do zad 3
    static bool AreAnagrams(string s1, string s2)
    {
        char[] s1C = s1.ToCharArray();
        char[] s2C = s2.ToCharArray();
        Array.Sort(s1C);
        Array.Sort(s2C);

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1C[i] != s2C[i]) return false;
        }

        return true;
    }
    
    // Metoda helper do zad 4

    static void MakeJoints(Dictionary<int, bool[]> matrix, int node1, int node2)
    {
        matrix[node1][node2] = true;
        matrix[node2][node1] = true;
    }

    static void UpoDfs(Dictionary<int, bool[]> matrix, int start, int target)
    {
        Stack<int> stack = new();
        List<int> visited = new();
        stack.Push(start);
        while (stack.Count > 0)
        {
            int index = stack.Pop();
            visited.Add(index);
            if (index == target)
            {
                Console.WriteLine("Znaleziono cel!");
                return;
            }

            bool[] joints = matrix[index];
            for (int i = 0; i < joints.Length; i++)
            {
                if (joints[i] && !visited.Contains(i)) stack.Push(i);
            }
        }

        Console.WriteLine("Nie znaleziono celu!");
    }

    // Printy arrayów dla czystości kodu
    static void PrintArray<T>(IEnumerable<T> arr)
    {
        foreach (T element in arr) Console.Write($"{element}, ");
        Console.WriteLine();
    }

    static void PrintDict(Dictionary<int, bool[]> matrix)
    {
        foreach (KeyValuePair<int, bool[]> pair in matrix)
        {
            Console.Write($"{pair.Key}: ");
            foreach (bool b in pair.Value) Console.Write($"{b}, ");
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}