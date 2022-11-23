int a;
int b;


//TODO zad1

//zad2
int Dodaj(int x,int y)
{
    return x+y;
}

//zad3
int Silnia(int x)
{
	if (x == 0) return 1;
	else return x * Silnia(x - 1);

}

//zad4
int Fib(int x)
{
	if (x == 1 || x == 2) return 1;
	else return Fib(x - 1) + Fib(x - 2);
}

//TODO zad5 nadal nie umiem w rekurencji
// + problem z typami danych :P

//zad6
int Pow(int x, int y)
{
	if (y == 0) return 1;
	else if (y == 1) return x;
	else return x * Pow(x, y - 1);
}

//TODO zad7

//ROZWIĄZANIA
Console.WriteLine("ZADANIE 2");
Console.Write("Podaj 1 Liczbę: ");
a = int.Parse(Console.ReadLine());
Console.Write("Podaj 2 Liczbę: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine(Dodaj(a, b));

Console.WriteLine("ZADANIE 3");
Console.Write("Podaj Liczbę: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine(Silnia(a));

Console.WriteLine("ZADANIE 4");
Console.Write("Podaj Liczbę: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine(Fib(a));

Console.WriteLine("ZADANIE 6");
Console.Write("Podaj 1 Liczbę: ");
a = int.Parse(Console.ReadLine());
Console.Write("Podaj 2 Liczbę: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(a, b));