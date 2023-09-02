using System;

namespace KartaPracy
{
    class program
    {
        static void Main()
        {
            
            int a,b,c;
            float brutto;

            //zad1
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a*a + b*b);
            Console.WriteLine();
            //Console.ReadKey();
            
            //zad2
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine((a+b)*(a+b));
            Console.WriteLine();
            //Console.ReadKey();

            //zad3
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine((a+b)*(a+b));
            Console.WriteLine();
            //Console.ReadKey();

            //zad4
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(a*b*c);
            Console.WriteLine();
            //Console.ReadKey();

            //zad5
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(2*(a+b)/5);
            Console.WriteLine();
            //Console.ReadKey();

            //zad6
            brutto = float.Parse(Console.ReadLine());
            Console.WriteLine(brutto/1.23);
            Console.WriteLine();
            //Console.ReadKey();

            //zad7
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a%b);
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}