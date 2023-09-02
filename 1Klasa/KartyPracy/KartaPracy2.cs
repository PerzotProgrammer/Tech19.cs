using System;

namespace KartaPracy2
{
    class Program
    {
        static void Main(){
            int a,b,c;

            //zad1
            Console.WriteLine("ZADANIE 1");
            a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("Dzieli się przez 3");
            }
            else 
            {
                Console.WriteLine("Nie dzieli się przez 3");
            }
            Console.WriteLine();

            //zad2
            Console.WriteLine("ZADANIE 2");
            a = int.Parse(Console.ReadLine());
            if (a % 17 == 0 && 99 < a && a < 1000)
            {
                Console.WriteLine("Spelnia warunki");
            }
            else
            {
                Console.WriteLine("Nie spelnia warunkow");
            }
            Console.WriteLine();

            //zad3
            Console.WriteLine("ZADANIE 3");
            a = int.Parse(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Pełnoletni");
            }
            else
            {
                Console.WriteLine("Niepełnoletni");
            }
            Console.WriteLine();

            //zad4
            Console.WriteLine("ZADANIE 4");
            const int waga = 20;
            a = int.Parse(Console.ReadLine());
            if (a <= 20)
            {
                Console.WriteLine("Można wjechać");
            }
            else
            {
                Console.WriteLine("Nie można wjechać");
            }
            Console.WriteLine();

            //zad5
            Console.WriteLine("ZADANIE 5");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a < c && c < b || a > c && c > b)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }

            //zad6
            Console.WriteLine("ZADANIE 6");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if ((Math.Pow(a,b) - a) % b == 0)
            {
                Console.WriteLine("TAK spełnia MTF");
            }
            else
            {
                Console.WriteLine("NIE niespełnia MTF");
            }

            //zad7
            Console.WriteLine("ZADANIE 7");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (c * 3 >= b - a)
            {
                Console.WriteLine("TAK żabka doskoczy");
            }
            else
            {
                Console.WriteLine("NIE żabka niedoskoczy");
            }
        }
    }
}