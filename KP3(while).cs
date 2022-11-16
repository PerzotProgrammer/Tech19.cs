int i = 0;
int x = 10;
int temp = 0;
int suma = 0;
ulong a = 1;
ulong b = 1;

Console.WriteLine("ZADANIE 1");
while (i <= x)
{
    Console.WriteLine((i * i * i) + 3);
    i++;
}


Console.WriteLine("ZADANIE 2");
i = 100;
x = 1000;

while (i < x)
{
    if (i % 15 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}


Console.WriteLine("ZADANIE 3");
Console.Write("Daj liczbe: ");
x = int.Parse(Console.ReadLine());
i = 1;
while (i <= x)
{
    if (x % i == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}


Console.WriteLine("ZADANIE 4");
i = 10;
while (i < 100)
{
    temp += i;
    i++;
}
Console.WriteLine(temp);


Console.WriteLine("ZADANIE 5");
x = int.Parse(Console.ReadLine());
suma = x * (x + 1) / 2;
i = 1;
while (i < x)
{
    temp = int.Parse(Console.ReadLine());
    suma -= temp;
    i++;
}
Console.WriteLine($"Nie podałes {suma}");


Console.WriteLine("ZADANIE 6");
i = 0;
x = 50;
while (i <= x)
{
    Console.WriteLine(a);
    a += b;
    i++;
    if (i == x) break;
    Console.WriteLine(b);
    b += a;
    i++;
}

//BONUS
//Oblicz sumę cyfr liczby x
Console.WriteLine("BONUS");
Console.Write("Podaj liczbę: ");
x = int.Parse(Console.ReadLine());
temp = 0;
suma = 0;
while (x > 0)
{
    temp = x % 10;
    suma += temp;
    x /= 10;
}
Console.WriteLine($"Suma cyfr w liczbie to {suma}");