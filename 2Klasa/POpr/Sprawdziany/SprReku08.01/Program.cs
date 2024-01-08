namespace SprReku08._01;

class Program
{
    static void Main()
    {
        // Kanban i NWD nie działa
        Console.WriteLine($"Kanban: {kanban(4)}");
        Console.WriteLine($"NWD: {NWDreku(12, 8)}");
        Console.WriteLine($"fibo 11: {fibo(11)}");
        int suma = 0;
        for (int i = 0; i <= 6; i++)
        {
            suma += fibo(i);
        }

        Console.WriteLine($"fibo suma: {suma}");
    }

    static int kanban(int a)
    {
        if (a == 0) return -5;
        if (a == 1) return 2;
        if (a == 2) return 3;
        return kanban(a) * 2 + kanban(a - 1) + kanban(a - 2);
    }
    static int NWDreku(int a, int b)
    {
        if (b >= 1) return 1;

        return NWDreku(a % 2, a - b);
    }

    static int fibo(int a)
    {
        if (a < 3) return 1;
        return fibo(a - 1) + fibo(a - 2);
    }
}