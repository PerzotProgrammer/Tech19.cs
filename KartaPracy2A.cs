namespace KartaPracy2A
{
    class program
    {
        static void Main()
        {
            int a,b,c,d;
            //zad1
            System.Console.WriteLine("ZADANIE 1");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            if ((a + b) % 2 == 0) System.Console.WriteLine("TAK, suma parzysta"); 
            else System.Console.WriteLine("NIE, suna nieparzysta");

            //zad2
            System.Console.WriteLine("ZADANIE 2");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            if ((a + b)/ 2 > Math.Sqrt(a * b)) System.Console.WriteLine("TAK śr ar > geo");
            else System.Console.WriteLine("NIE śr ar < geo");

            //zad3
            System.Console.WriteLine("ZADANIE 3");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            if (a == b || a == c || b == c){
                System.Console.WriteLine("TAK, są przynajmniej dwie liczby równe siebie");
                if (a == b && a == c && b == c) System.Console.WriteLine("Wszystkie liczby są równe");
                else if (a == b) System.Console.WriteLine("Są to 'Liczba1' i 'Liczba2'");
                else if (a == c) System.Console.WriteLine("Są to 'Liczba1' i 'Liczba3'");
                else if (b == c) System.Console.WriteLine("Są to 'Liczba2' i 'Liczba3'");
            }else System.Console.WriteLine("NIE, nie ma dwóch równych");

            //zad4
            System.Console.WriteLine("ZADANIE 4");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            d = int.Parse(System.Console.ReadLine());
            if (a < b && a < c && a < d) System.Console.WriteLine("Najmniejsza to " + a);
            else if (b < a && b < c && b < d) System.Console.WriteLine("Najmniejsza to " + b);
            else if (c < b && c < a && c < d) System.Console.WriteLine("Najmniejsza to " + c);
            else if (d < b && d < c && d < a) System.Console.WriteLine("Najmniejsza to " + d);
            else System.Console.WriteLine("Przynajmniej dwie najmniejsze są równe siebie");
            
            //zad5
            System.Console.WriteLine("ZADANIE 5");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            if (b - c < a && a < b + c || a - c < b && b < a + c || a - b < c && c < a + b)
            { 
                System.Console.WriteLine("TAK, spełnia nierówność");
            }
            else System.Console.WriteLine("NIE, nie spełnia nierówności");

            //zad6
            System.Console.WriteLine("ZADANIE 6");
            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                System.Console.WriteLine("Trójkąt powstanie");
                if (a**2 + b**2 == c**2 || b**2 + c**2 == a**2 || c**2 + a**2 || b**2)
                {
                    System.Console.WriteLine("Będzie to trójkąt prostokątny");
                }
                else if (a**2 + b**2 < c**2 || b**2 + c**2 < a**2 || c**2 + a**2 < b**2)
                {
                    System.Console.WriteLine("Będzie to trójkąt rozwartokątny");
                }
                else if (a**2 + b**2 > c**2 || b**2 + c**2 > a**2 || c**2 + a**2 > b**2)
                {
                    System.Console.WriteLine("Będzie to trójkąt ostrokątny");
                }
            }
            else System.Console.WriteLine("Trójkąt nie powstanie");

        }
    }
}