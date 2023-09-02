Console.WriteLine("ZADANIE 1");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

Console.Write("a: ");
Console.WriteLine((a+b+c+d)/4f);

Console.Write("b: ");
if (a >= d - 2 || a <= d + 2) Console.Write(true);
else Console.WriteLine(false);

Console.Write("c: ");
int spr = 0;
if (a < b) spr++;
if (b < c) spr++;
if (c < d) spr++;
Console.WriteLine(spr);

Console.WriteLine("ZADANIE 2");
int col;
int spr;
for(col = 10; col < 100; col++)
{
    int temp = col;
    for(spr = 1; spr <= 10; spr++)
    {
        if (temp % 2 == 0) temp /= 2;
        else temp = (temp * 3) + 1;
        if (temp == 1) break;
    }
    if (spr == 9 && temp == 1) Console.WriteLine($"liczba 1 jest na 9 miejscu w n = {col}");
}

Console.WriteLine("ZADANIE 3");
int x = 7;

for(int i = 1; i <= x; i++)
{
    for(int j = 1; j <= x; j++)
    {
        if(i-1 == x/2 || j-1 == x/2) Console.Write("*");
        else if(i == j || j == i || i + j == x+1 || j + i == x+1) Console.Write("#");
        else Console.Write(" ");
    }
    Console.WriteLine();
}