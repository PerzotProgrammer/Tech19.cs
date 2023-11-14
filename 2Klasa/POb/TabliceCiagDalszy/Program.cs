namespace TabliceCiagDalszy;

class Program
{
    static void Main()
    {
        Zadanie1();
    }

    static void Zadanie1()
    {
        int[] Arr = CreateArray(100);
        SetArray(Arr);
        DisplayArray(Arr, 100);
    }

    // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()
    static int[] CreateArray(int lenght)
    {
        return new int[lenght];
    }

    // funkcja statyczna, która ustawia elementy tablicy SetArray()
    static void SetArray(int[] Arr)
    {
        Random random = new();
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = random.Next(0, 10);
        }
    }

    // funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
    static void DisplayArray(int[] Arr, int timeout = 0)
    {
        foreach (int i in Arr)
        {
            Console.Write($"{i}, ");
            if (timeout > 0) Thread.Sleep(timeout);
        }
    }
}