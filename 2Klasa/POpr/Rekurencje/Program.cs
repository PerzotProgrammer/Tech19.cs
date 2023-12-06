namespace Rekurencje;

class Program
{
    static void Main()
    {
        StackWrite(10);
        Console.WriteLine($"\nTwój Fibonaczi: {FibElement(10)}");
        Console.WriteLine($"Jakieś zadanko idk: {CoTrzyElementy(3)}");

        // DO ZADANEK
        Console.WriteLine("\n\nKolejne zadanka");
        Console.WriteLine($"zad a: {Zadania.a(5)}");
        Console.WriteLine($"zad e: {Zadania.e(5)}");
        Console.WriteLine();
        Console.WriteLine($"Suma cyfr: {Zadania.SumaCyfrIter(54545)}");
        Console.WriteLine($"To samo tylko rekurencja: {Zadania.SumaCyfrReku(54545)}");
        Console.WriteLine($"Decymalny na binarke: {Zadania.DecNaBinIter(10)}");
        Console.Write("Rekurencja: ");
        Zadania.DecNaBinReku(10);
    }

    static void StackWrite(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("\nTutaj kończy się rekurencja");
            return;
        }
        Console.Write($"{n} ");
        StackWrite(n - 1);
        Console.Write($"{n} ");
    }
    
    static int FibElement(int n)
    {
        if (n < 3) return 1;
        return FibElement(n - 2) + FibElement(n - 1);
    }

    static int CoTrzyElementy(int n)
    {
        if (n == 1) return 3;
        return CoTrzyElementy(n - 1) + 3 * n;
    }
}
