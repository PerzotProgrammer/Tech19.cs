int x = 10;
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
for(int i = 0; i <= x; i++)
{
    for( int j = 0; j <= i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre2

for(int i = 0; i <= x; i++)
{
    for( int j = 0; j <= x - i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre3

for(int i = 0; i <= x; i++)
{
    for(int j = 0; j <= i; j++)
    {
        System.Console.Write(" ");
    }
    for( int j = 0; j <= x - i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

//zad2 pre4

for(int i = 0; i <= x; i++)
{
    for( int j = 0; j <= x - i; j++)
    {
        System.Console.Write(" ");
    }
    for(int j = 0; j <= i; j++)
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


