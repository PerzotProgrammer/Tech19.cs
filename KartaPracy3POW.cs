
//zad 1 suma x-fibów

int suma = 0;
int a = 1;
int b = 1;
Console.WriteLine("ZADANIE 1");
Console.Write("suma x-fibów: ");
int x = int.Parse(Console.ReadLine());
int n = 0;
while(n < x)
{
    Console.WriteLine(a);
    n++;
    suma += a;
    a += b;
    if(n == x) break;
    Console.WriteLine(b);
    n++;
    suma += b;
    b += a;
}
Console.WriteLine($"suma to {suma}");
Console.WriteLine();


// zad 2 suma x liczb trzycyfrowych

Console.WriteLine("ZADANIE 2");
Console.Write("suma x liczb trzycyfrowych: ");
x = int.Parse(Console.ReadLine());
suma = 0;
for(int i = 100; i < x + 100; i++)
{
    Console.WriteLine(i);
    suma += i;
}
Console.WriteLine($"suma to {suma}");
Console.WriteLine();


// zad 3 sprawdź czy liczba jest doskonała
Console.WriteLine("ZADANIE 3");
Console.Write("Podaj liczbę DOSKONAŁĄ: ");
x = int.Parse(Console.ReadLine());
suma = 0;
for(int i = 1; i < x; i++) if (x % i == 0) suma += i;
if (suma == x) Console.WriteLine("DOSKONAŁA :D");
else Console.WriteLine(":(");