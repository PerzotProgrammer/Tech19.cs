namespace SprKolekcje17._04;

class Program
{
    static void Main()
    {
        Zad0();
        Zad1();
        Zad2(); // Teraz działa :P
        Zad3();
    }

    static void Zad0()
    {
        Console.Write("Podaj 7 liczb: ");
        string[] input = Console.ReadLine()!.Split("-");
        int[] tab = new int[7];
        for (int i = 0; i < 7; i++) tab[i] = int.Parse(input[i]);

        int[] malomiasteczkowa = { 1, 1, 1, 1, 1, 1, 1 }; // Każda co składa się z tej samej liczby

        if (IsArrayEqual(tab)) Console.WriteLine("Tablica jest małomiasteczkowa");
        else if (IsArrayAsc(tab)) Console.WriteLine("Tablica jest wielkomiejska");
        else Console.WriteLine("Tablica jest małorolna");
    }

    static void Zad1()
    {
        Random random = new();
        int[] tab = new int[10];
        for (int i = 0; i < tab.Length; i++) tab[i] = random.Next(-9, 9);

        Console.WriteLine("Twój array:");
        PrintArray(tab);

        List<int> best = new();
        int bestSum = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            List<int> curr = new();
            int currSum = 0;
            for (int j = i; j < tab.Length; j++)
            {
                currSum += tab[j];
                curr.Add(tab[j]);
                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    best = new(curr);
                }
            }
        }

        Console.Write("Najlepszy podciąg:");
        PrintArray(best);
        Console.WriteLine($"Początek: {best[0]}");
        Console.WriteLine($"Koniec: {best[^1]}");
        Console.WriteLine($"Suma elementów: {best.Sum()}");
    }

    static void Zad2()
    {
        List<List<List<int>>> cube = new();
        Random random = new();

        int size = 7;
        for (int i = 0; i < size; i++)
        {
            List<List<int>> dim1 = new();
            for (int j = 0; j < size; j++)
            {
                List<int> dim2 = new();
                for (int k = 0; k < size; k++)
                {
                    int dim3 = random.Next(0, 10);
                    dim2.Add(dim3);
                }

                dim1.Add(dim2);
            }

            cube.Add(dim1);
        }

        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            List<List<int>> dim1 = cube[i];
            for (int j = 0; j < size; j++)
            {
                List<int> dim2 = dim1[j];
                for (int k = 0; k < size; k++)
                {
                    if ((k == 0 || k == size - 1) && (j == 0 || j == size - 1) && (i == 0 || i == size - 1) ||
                        (j - i == 0 && j == k || j + i == size - 1 && j == k) || (j + k == size - 1 && i == j) ||
                        (j + i == size - 1 && i == k))
                    {
                        sum += dim2[k];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{dim2[k]}, ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{dim2[k]}, ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        Console.WriteLine(sum);
    }

    static void Zad3()
    {
        Console.Write("Podaj ilość wierzchołków: ");
        int n = int.Parse(Console.ReadLine()!);

        Dictionary<int, bool[]> graph = new();

        for (int i = 1; i <= n; i++)
        {
            bool[] holder = new bool[n + 1];
            for (int j = 0; j <= n; j++) holder[i] = false;

            graph.Add(i, holder);
        }

        MakeJoints(graph, 2, 4);
        MakeJoints(graph, 4, 3);
        PrintGraph(graph);
        Dfs(graph, 1, 3);
        Dfs(graph, 1, 4);
    }

    static bool IsArrayAsc(int[] arr) // Do zad0
    {
        int buff = arr[0];
        foreach (int i in arr)
        {
            if (i < buff) return false;
            buff = i;
        }

        return true;
    }

    static bool IsArrayEqual(int[] arr) // Do zad0
    {
        int buff = arr[0];
        foreach (int i in arr)
        {
            if (i != buff) return false;
        }

        return true;
    }

    static void MakeJoints(Dictionary<int, bool[]> graph, int node1, int node2) // Do zad3
    {
        graph[node1][node2] = true;
        graph[node2][node1] = true;
    }

    static void Dfs(Dictionary<int, bool[]> graph, int start, int target) // Do zad3
    {
        Stack<int> stack = new();
        Stack<int> nthNode = new();
        List<int> visited = new();
        int curr = start;
        int nth = 0;
        stack.Push(curr);
        nthNode.Push(nth);
        while (stack.Count > 0)
        {
            curr = stack.Pop();
            nth = nthNode.Pop();
            if (curr == target)
            {
                Console.WriteLine("Znaleziono połączenie z wierzchołkiem!");
                if (nth != 2) Console.WriteLine("Nie ma przejścia przez jednego sąsiada");
                return;
            }

            visited.Add(curr);
            bool[] joints = graph[curr];
            for (int i = 0; i < joints.Length; i++)
            {
                if (joints[i] && !visited.Contains(i))
                {
                    stack.Push(i);
                    nthNode.Push(nth + 1);
                }
            }
        }

        Console.WriteLine("Nie znaleziono połączenia");
    }


    // Śmieszne printy, aby nie było powtórek kodu
    static void PrintArray<T>(IEnumerable<T> arr)
    {
        foreach (T el in arr) Console.Write($"{el}, ");
        Console.WriteLine();
    }


    static void PrintGraph(Dictionary<int, bool[]> graph)
    {
        foreach (KeyValuePair<int, bool[]> pair in graph)
        {
            Console.Write($"{pair.Key}: ");
            for (int i = 1; i < pair.Value.Length; i++)
            {
                Console.Write($"{pair.Value[i]}, ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}