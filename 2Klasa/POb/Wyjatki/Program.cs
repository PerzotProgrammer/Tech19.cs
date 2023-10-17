namespace Wyjatki;

class Program 
{
    // PRZYKŁAD DZIAŁANIA TRYPARSE
    // double a;
    // if (double.TryParse(System.Console.ReadLine(), out a))
    // {
    //     System.Console.WriteLine(a);
    // }
    // else
    // {
    //     System.Console.WriteLine("Błędne dane!");
    // }
    // Jeżeli da się przekonwertować na double, wtedy wypisz, inaczej zwróć błąd
    static void Main()
    {
        bool loop = true;
        while (loop)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Podaj boki trójkąta.");

            System.Console.Write("Podaj bok x: ");
            double x = PositiveDoubleParseLoop();

            System.Console.Write("Podaj bok y: ");
            double y = PositiveDoubleParseLoop();

            System.Console.Write("Podaj bok z: ");
            double z = PositiveDoubleParseLoop();

            if (IsTriangle(x, y, z)) 
            {
                System.Console.WriteLine($"Trójkąt powstanie, pole z wzoru Herona wynosi: {Heron(x, y, z):F4} j\u00b2.");
                loop = ContinueLoop(loop);
            }
            else 
            {
                System.Console.WriteLine("Trójkąt nie powstanie!");
                loop = ContinueLoop(loop);
            }
        }
    }
    static double PositiveDoubleParseLoop()
    {
        double x;
        while (!double.TryParse(System.Console.ReadLine(), out x) || x <= 0) System.Console.Write("Podaj prawidłowe dane!: ");
        return x;
    }
    static bool IsTriangle(double x, double y, double z) {return x + y > z && y + z > x && z + x > y;}
    static double Heron(double x, double y, double z)
    {
        double p = (x + y + z)/2;
        return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
    }
    static bool ContinueLoop(bool loop)
    {
        System.Console.WriteLine("Czy chcesz kontynuować? tak/nie");
        while (true) 
        {
            string? wybor = System.Console.ReadLine();
            if (wybor == "tak" || wybor == "t")
            {
                System.Console.Clear();
                return true;
            } 
            else if (wybor == "nie" || wybor == "n")
            {
                System.Console.Clear();
                return false;
            }
            System.Console.WriteLine("Podaj prawidłowe dane!");
        }
    }
}