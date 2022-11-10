int x = 11;
string gw = "*", kr = "--", pi = "||";

//zad1
System.Console.WriteLine("ZADANIE 1");
for (int i = 0; i <= x; i++)
{
    System.Console.Write("*-|");
}
System.Console.WriteLine();

//zad2 pre1
System.Console.WriteLine("ZADANIE 2 PRE 1,2,3,4");
for (int i = 0; i <= x; i++)
{
    for (int j = 0; j <= i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre2

for (int i = 0; i <= x; i++)
{
    for (int j = 0; j <= x - i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre3

for (int i = 0; i <= x; i++)
{
    for (int j = 0; j <= i; j++)
    {
        System.Console.Write(" ");
    }
    for (int j = 0; j <= x - i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre4

for (int i = 0; i <= x; i++)
{
    for (int j = 0; j <= x - i; j++)
    {
        System.Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        System.Console.Write("*");
    }

    System.Console.WriteLine();
}


//zad2
System.Console.WriteLine("ZADANIE 2");

for (int i = 0; i <= x; i++)
{
    System.Console.Write(gw + kr + gw + "*" + pi);
    gw = gw + "**";
}
System.Console.WriteLine();

//zad5
Console.WriteLine("ZADANIE 5");
for(int i = 1; i <= x; i++)
{
    for(int j = 0; j <= x; j++)
    {
        if(j == x / 2)  Console.Write("*");
        else if(i == x / 2) Console.Write("-");
        else Console.Write(" ");
    }
    Console.WriteLine();
}

//zad7
Console.WriteLine("ZADANIE 7");
for(int i = 1; i <= x; i++)
{
    for(int j = 1; j <= x; j++)
    {
        if(i == 1 || j == 1 || j == x || i == x || (i == x/2 + 1 && j == x/2 + 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}