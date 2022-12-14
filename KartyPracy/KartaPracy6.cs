int suma = 0;
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


Console.WriteLine("ZADANIE 1");
input1 = int.Parse(Console.ReadLine());
input2 = int.Parse(Console.ReadLine());
input3 = int.Parse(Console.ReadLine());

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
input1 = int.Parse(Console.ReadLine());
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
input1 = int.Parse(Console.ReadLine());
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