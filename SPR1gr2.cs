Console.WriteLine("ZADANIE 1");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.Write("a: ");
if (c == b - a || c * 2 == b - a || c * 3 == b - a || c * 4 == b - a || c * 5 == b - a) Console.WriteLine(true);
else Console.WriteLine(false);

Console.Write("b: ");
if (c >= b - a) Console.WriteLine(1);
else if (c * 2 >= b - a) Console.WriteLine(2);
else if (c * 3 >= b - a) Console.WriteLine(3);
else if (c * 4 >= b - a) Console.WriteLine(4);
else if (c * 5 >= b - a) Console.WriteLine(5);
else Console.WriteLine(false);

Console.Write("c: ");
if (c * 5 == b - a) {
    Console.Write(true);
    Console.Write((b - a)/5);
}
else {
    Console.Write(false);
    Console.Write((b - a)/5);
}

Console.WriteLine("ZADANIE 2");

for (int faj = 1000; faj < 10000; faj++)
{
    int jed = faj % 10;
    int dz = (faj % 100) / 10;
    int set = (faj % 1000) / 100;
    if (jed == dz * 2 && dz == set * 2) Console.WriteLine(faj);
}


Console.WriteLine("ZADANIE 3");
int x = 7;

for (int i = 1; i <= x; i++)
{
    for (int j = 1; j <= x; j++)
    {
        if (i == j || i + j == x + 1 || i - 1 == j || j - 1 == i || i + j == x + 2 || i + j == x) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}