namespace Sortowania;

public class Sort
{
    private int[] Arr;
    public Sort()
    {
        Arr = CreateArray();
    }
    
    private int[] CreateArray()
    {
        Console.Write("Podaj długość tablicy: ");
        int lenght = Convert.ToInt32(Console.ReadLine());
        return new int[lenght];
    }

    public void AutoFillArray(int min, int max)
    {
        Random random = new();
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = random.Next(min, max);
        }
    }
    public void ManualFillArray()
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write($"Podaj {i + 1} element tablicy:");
            Arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void PrintArray(string message)
    {
        Console.WriteLine(message);
        foreach (int element in Arr)
        {
            Console.Write($"{element}, ");
        }
        Console.WriteLine();
    }
    
    public void ReverseArray()
    {
        for (int i = 0; i < Arr.Length / 2; i++)
        {
            (Arr[Arr.Length - i - 1], Arr[i]) = (Arr[i], Arr[Arr.Length - i - 1]);
        }
    }
    
    public void SelectionSort()
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            int temp = i;

            for (int j = i + 1; j < Arr.Length; j++)
            {
                if (Arr[j] < Arr[temp]) temp = j;
            }

            (Arr[temp], Arr[i]) = (Arr[i], Arr[temp]);
        }
    }
}