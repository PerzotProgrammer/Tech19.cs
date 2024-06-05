namespace Delegaty;

class Program
{
    static void Main()
    {
        int output;
        Operations handle = Add;
        output = handle(10, 5);
        Console.WriteLine(output);

        handle = Sub;
        output = handle(10, 5);
        Console.WriteLine(output);

        DoubleOperations power = (a, b) => Math.Pow(a + b, 2);
        Console.WriteLine(power(2.5, 10.5));
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Sub(int x, int y)
    {
        return x - y;
    }

    public delegate int Operations(int x, int y);

    public delegate double DoubleOperations(double x, double y);
}