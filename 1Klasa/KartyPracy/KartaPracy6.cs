#pragma warning disable
float suma = 0;
int dzielnik = 0;
int liczba = 0;
int jed = 0;
int dz = 0;
int set = 0;
int ilosc = 0;
int licznik = 0;
int input1 = 0;
int input2 = 0;
int input3 = 0;
float ciag1 = 0;
float ciag2 = 0;
float temp1 = 0;
float temp2 = 0;
int pot = 0;


Console.WriteLine("ZADANIE 1");
input1 = Convert.ToInt32(Console.ReadLine());
input2 = Convert.ToInt32(Console.ReadLine());
input3 = Convert.ToInt32(Console.ReadLine());

Console.Write("ARYTMETYCZNY:");
if (input1 - input2 == input2 - input3) Console.WriteLine(true);
else Console.WriteLine(false);

Console.Write("GEOMETRYCZNY:");
if (input2 / input1 == input3 / input2) Console.WriteLine(true);
else Console.WriteLine(false);

Console.Write("ROSNĄCY:");
if (input1 < input2 && input2 < input3) Console.WriteLine(true);
else Console.WriteLine(false);

Console.Write("MALEJĄCY:");
if (input1 > input2 && input2 > input3) Console.WriteLine(true);
else Console.WriteLine(false);



Console.WriteLine("ZADANIE 2");
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
    {
        suma += i;
    }
}
Console.WriteLine($"Wynik to: {suma}");


Console.WriteLine("ZADANIE 3");
for (int i = 10; i < 100; i++)
{
    if (i % 7 == 0)
    {
        dzielnik = i;
    }
}
for (int i = 1000; i < 10000; i++)
{
    if (i % dzielnik == 0)
    {
        liczba += i;
    }
}
Console.WriteLine($"Wynik to: {liczba}");


Console.WriteLine("ZADANIE 4");

for (int i = 10; i < 100; i++)
{
    jed = i % 10;
    dz = i / 10;
    if (jed * 2 <= dz)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);


jed = 0;
dz = 0;
set = 0;

ilosc = 0;
suma = 0;

Console.WriteLine("ZADANIE 5");

for (int i = 100; i < 1000; i++)
{
    jed = i % 10;
    dz = (i % 100) / 10;
    set = (i % 1000) / 100;
    if (set > jed + dz)
    {
        ilosc++;
        suma += i;
    }
}
Console.WriteLine($"Ilość: {ilosc}\nSuma: {suma}");



Console.WriteLine("ZADANIE 6");
input1 = Convert.ToInt32(Console.ReadLine());
licznik = 0;
suma = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        licznik++;
        suma += i;
    }
    if (licznik == input1)
    {
        Console.WriteLine(suma);
        break;
    }
    if (i == 99)
    {
        Console.WriteLine("OUT OF RANGE!");
    }
}


Console.WriteLine("ZADANIE 7");
input1 = Convert.ToInt32(Console.ReadLine());
licznik = 0;
suma = 0;
for (int i = 999; i >= 100; i--)
{
    if (i % 37 == 0)
    {
        licznik++;
        suma += i;
    }
    if (licznik == input1)
    {
        Console.WriteLine(suma);
        break;
    }
    if (i == 100)
    {
        Console.WriteLine("OUT OF RANGE!");
    }
}

Console.WriteLine("ZADANIE 8");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 2;
suma = 0;
for (int i = 0; i < input1; i++)
{
    if (ciag1 % 2 == 0)
    {
        suma += ciag1;
        ciag1 += 3;
    }
    else
    {
        suma -= ciag1;
        ciag1 += 3;
    }
}
Console.WriteLine($"Wynik ciągu: {suma}");

Console.WriteLine("ZADANIE 9");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 1;
suma = 1;
pot = 0;
for (int i = 0; i < input1; i++)
{
    if (pot % 2 == 0) suma *= ciag1;
    else suma *= -ciag1;

    ciag1 *= 2;
    pot++;
}
Console.WriteLine($"Wynik ciągu: {suma}");


Console.WriteLine("ZADANIE 10");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 1;
suma = 0;
for (int i = 0; i < input1; i++)
{
    temp1 = ciag1;
    for (int j = 1; j < ciag1; j++)
    {
        temp1 *= j;
    }
    suma += temp1;
    ciag1++;
}
Console.WriteLine($"Wynik ciągu: {suma}");


Console.WriteLine("ZADANIE 11");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 1;
ciag2 = 1;
suma = 0;
temp1 = 1;
for (int i = 0; i < input1; i++)
{
    suma += ciag1 / ciag2;
    ciag1 += 2;
    temp1++;
    ciag2 = temp1 * temp1;
}
Console.WriteLine($"Wynik ciągu: {suma}");


Console.WriteLine("ZADANIE 12");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 0;
ciag2 = 0;
temp1 = 1;
temp2 = 1;
pot = 1;
for (int i = 0; i < input1; i++)
{
    ciag1 += temp1;
    ciag2 += temp2;
    temp1 += 2;
    pot++;
    temp2 = pot * pot;
}
suma = ciag1 / ciag2;
Console.WriteLine($"Wynik ciągu: {suma}");


Console.WriteLine("ZADANIE 13 i 14 (takie same)");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 0;
ciag2 = 0;
suma = 0;
for (int i = 1; i <= input1; i++)
{
    ciag1 += 2;
    ciag2 = Convert.ToInt32(Math.Pow(i, 3) + 2);
    temp1 = ciag1 / ciag2;
    suma += temp1;
}
Console.WriteLine($"Wynik ciągu: {suma}");


Console.WriteLine("ZADANIE 15");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 1;
ciag2 = 1;
temp1 = 3;
temp2 = 1;
suma = 1;
for (int i = 0; i < input1; i++)
{
    ciag1 = temp1;
    ciag2 = temp2;
    temp1++;
    temp2 *= 2 + 1;
    suma *= ciag1 / ciag2;
}
Console.WriteLine($"Wynik ciągu: {suma}");

// fib działa ale 1,1,2,3,5,8,13,...
Console.WriteLine("ZADANIE 16");
input1 = Convert.ToInt32(Console.ReadLine());
ciag1 = 1;
ciag2 = 1;
temp1 = 1;
temp2 = 1;
suma = 1;
pot = 0;
for (int i = 0; i < input1; i++)
{
    if (pot % 2 == 0)
    {
        ciag1 = temp1;
        temp1 += temp2;
    }
    else
    {
        ciag1 = temp2;
        temp2 += temp1;
    }
    pot++;
    suma *= ciag1 / ciag2;
    ciag2 *= 2;
}
Console.WriteLine($"Wynik ciągu: {suma}");
