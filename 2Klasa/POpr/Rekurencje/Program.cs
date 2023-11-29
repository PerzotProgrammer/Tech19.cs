namespace Rekurencje;

class Program
{
    static void Main()
    {
        StackWrite(10);
        Console.WriteLine($"\nTwój Fibonaczi: {FibElement(10)}");
        Console.WriteLine(CoTrzyElementy(3));
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
