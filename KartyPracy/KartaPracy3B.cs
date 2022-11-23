int przesun = 1;
int ileLiczb = 0;
int liczba = 0;
int iterator = 0;
double suma = 0;
double kapPocz = 0;
double kapKon = 0;
double lataInw = 0;

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
for(int i = 1; i <= ileLiczb; i++) 
    if(i % 2 != 0) System.Console.WriteLine($"{i}^2={i*i}");

//zad3
System.Console.WriteLine("ZADANIE 3");
for(int i = 1000; i <= 10000; i++)
    if(i % 379 == 0)System.Console.WriteLine(i);

//zad4
System.Console.WriteLine("ZADANIE 4");
for(int i = 100; i <= 1000;i++)
    if(i % 5 == 0 || i % 6 == 0 || i % 11 == 0)System.Console.WriteLine(i);

//zad5
System.Console.WriteLine("ZADANIE 5");
System.Console.Write("Ile liczb chcesz dodać?: ");
ileLiczb = int.Parse(System.Console.ReadLine());
for(int i = 0; i < ileLiczb; i++)
{
    System.Console.Write($"Podaj {i+1} Liczbę: ");
    liczba = int.Parse(System.Console.ReadLine());
    suma += liczba;
}
System.Console.WriteLine($"Suma liczb to: {suma}");

//zad6
System.Console.WriteLine("ZADANIE 5");
System.Console.Write("Podaj liczby: ");
ileLiczb = int.Parse(System.Console.ReadLine());
suma = 0;
for(int i = 2; i <= (ileLiczb * 2);i += 2)
{
    suma += i;
}
System.Console.WriteLine($"suma to: {suma}");

//zad7
System.Console.WriteLine("ZADANIE 7");
System.Console.Write("Podaj liczby: ");
ileLiczb = int.Parse(System.Console.ReadLine());
suma = 0;
for(int i = 11; i <= (ileLiczb * 2) + 11; i += 2)
{
    suma += i;
}
System.Console.WriteLine($"suma to: {suma}");

//zad8
System.Console.WriteLine("ZADANIE 8");
System.Console.Write("Podaj początkowy kapitał: ");
kapPocz = int.Parse(System.Console.ReadLine());
System.Console.Write("Podaj lata inwestycji: ");
lataInw = int.Parse(System.Console.ReadLine());
suma = kapPocz;
for(int i = 0; i < lataInw * 12; i++)
{
    kapKon = suma * 0.06 * 1/12f;
    suma = suma + kapKon;
}
System.Console.WriteLine($"Końcowy kapitał wynosi: {Math.Round(suma,2)} zł");

//zad9
System.Console.WriteLine("ZADANIE 9");
System.Console.Write("Podaj ilość liczb: ");
ileLiczb = int.Parse(System.Console.ReadLine());
iterator = 21;
suma = 0;
for(int i = 0; i <= ileLiczb; i++)
{
    for(int a = 0; a < i; a += iterator)
    {
        System.Console.WriteLine(iterator);
        suma += iterator;
        iterator += 100;
    }
}
System.Console.WriteLine($"Suma to: {suma}");

//zad10
System.Console.WriteLine("ZADANIE 10");
for(double i = 1; i <= 1000; i++)
{
    if(i % 10 == Math.Sqrt(i))
    {
        System.Console.WriteLine(i);
    }
    else if(i % 100 == Math.Sqrt(i))
    {
        System.Console.WriteLine(i);
    }
}
