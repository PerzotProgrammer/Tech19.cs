namespace KartaPracy3
{
    class program
    {
        static void Main()
        {
            int i,a;

            //zad1
            System.Console.WriteLine("ZADANIE 1");
            System.Console.WriteLine("Ile iteracji?:");
            a = int.Parse(Console.ReadLine());
            for (i = 0; i < a ; i++) System.Console.WriteLine((i*i*i)+3);

            //zad2
            System.Console.WriteLine("ZADANIE 2");
            for (i = 105; i == 990; i += 15) System.Console.WriteLine(i);   

            //zad3
            System.Console.WriteLine("ZADANIE 3");
            a = int.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++) {
                if (a % i == 0) System.Console.WriteLine(i);}

            //zad4
            a = 0;
            System.Console.WriteLine("ZADANIE 4");
            for (i = 10; i < 100; i++) a += i;
            System.Console.WriteLine(a);

            //zad5
            //TODO

            // //zad6 nie wiem jak to działa
            ulong x = 1 , y = 1;
            System.Console.WriteLine("ZADANIE 6");
            System.Console.WriteLine("Ile chcesz liczb ciągu?: ");

            int liczb = int.Parse(Console.ReadLine());
            for (i = 0;i < liczb;)
            {
                System.Console.WriteLine(x);
                x += y;
                i++;
                if (i == liczb) break;
                System.Console.WriteLine(y);
                y += x;
                i++;
            }
        }
    }
}