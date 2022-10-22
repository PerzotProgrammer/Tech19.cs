int przesun = 1;
int ileLiczb;
//zad1
System.Console.WriteLine("ZADANIE 1");
System.Console.WriteLine("\t\tLISTOPAD 2022");
System.Console.Write("\t");
for(int i = 1; i<= 30;i++)
{
    System.Console.Write(i+"\t");
    przesun ++;
    if(przesun % 7 == 0)
    {
        System.Console.WriteLine();
        przesun = 0;
    }
}
System.Console.WriteLine();

//zad2
System.Console.WriteLine("ZADANIE 2");
System.Console.Write("Podaj zakres: ");
ileLiczb = int.Parse(System.Console.ReadLine());
for(int i = 1; i <= ileLiczb;i++) 
    if(i % 2 != 0) System.Console.WriteLine($"{i}^2={i*i}");

//zad3
System.Console.WriteLine("ZADANIE 3");
for(int i = 1000; i <= 10000;i++)
    if(i %379 == 0)System.Console.WriteLine(i);

//zad4
System.Console.WriteLine("ZADANIE 4");
for(int i = 100; i <= 1000;i++)
    if(i % 5 == 0 ||i % 6 == 0 ||i % 11 == 0)System.Console.WriteLine(i);