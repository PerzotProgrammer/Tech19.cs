namespace InneTesty;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(1, 2));
        Console.WriteLine(calc.Subtract(5, 3));
        Console.WriteLine(calc.Multiply(4, 2));
        Console.WriteLine(calc.Divide(8, 2));

        try
        {
            Console.WriteLine(calc.Divide(8, 0));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.WriteLine(calc.Add(1.5f, 2.5f));
        Console.WriteLine(calc.Subtract(5.5f, 3.5f));
        Console.WriteLine(calc.Multiply(4.5f, 2.5f));
        Console.WriteLine(calc.Divide(8.5f, 2.5f));

        try
        {
            Console.WriteLine(calc.Divide(8.5f, 0));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}