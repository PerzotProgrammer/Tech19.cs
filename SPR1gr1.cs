Console.WriteLine("ZADANIE 1");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

Console.Write("a: ");
Console.WriteLine((a+b+c+d)/2f);

Console.Write("b: ");
if (a - 2 == d || d - 2 == a) Console.Write(true);
else Console.WriteLine(false);

Console.Write("c: ");
int spr = 0;
if (a < b) spr++;
if (b < c) spr++;
if (c < d) spr++;
Console.WriteLine(spr);

Console.WriteLine("ZADANIE 2 NIE DZIAŁA!");
int i = 0; 
int col = 0;

for (col = 10; col < 100; col++) 
{
    int temp = col;
    i = 0;
    for(temp = i; temp > 1; i++)
    {
        if(temp % 2 == 0)
        {
            temp /= 2;
        }
        else
        {
            temp = (temp * 3) + 1;
        }
    }
    if (i == 9 && temp == 1)
    {
        Console.WriteLine($"1 na 9 miejscu jest kiedy n = {col}");
        break;
    }
}

int x = 7;
Console.WriteLine("ZADANIE 3");

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