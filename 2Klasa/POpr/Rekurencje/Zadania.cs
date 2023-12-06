namespace Rekurencje;

static class Zadania
{
    // ZADANKA
    // a. 1 3 4 8 15 27
    // b. 4 5 -3 2 14 22 48
    // c. 1 1 1 3 5 9
    // d. 2 3 4 -1 -8 -11 -2
    // e. 1 4 3 16 5 64 7 256

    // Wyznacz sumę cyfr wpisanej przez usera liczby

    public static int a(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 3;
        if (n == 3) return 4;
        return a(n - 1) + a(n - 2) + a(n - 3);
    }

    public static int e(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 4;
        if (n % 2 == 0) return e(n - 2) * 4;
        return e(n - 2) + 2;
    }

    public static int SumaCyfrIter(int n)
    {
        int outInt = 0;
        while (n > 0)
        {
            outInt += n % 10;
            n /= 10;
        }

        return outInt;
    }

    public static int SumaCyfrReku(int n)
    {
        if (n == 0) return 0;
        return SumaCyfrReku(n / 10) + n % 10;
    }

    public static string DecNaBinIter(int n)
    {
        string bin = "";
        while (n > 0)
        {
            bin = n % 2 + bin;
            n /= 2;
        }

        return bin;
    }

    public static void DecNaBinReku(int n)
    {
        if (n == 0) return;
        DecNaBinReku(n / 2);
        Console.Write(n % 2);
    }
}