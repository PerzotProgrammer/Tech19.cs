// CS-Script to coś przepięknego
using System;
using System.Collections;

// zad 1
int[] T1 = new int[15];
Random rand = new Random();
for (int i = 0; i < 15;)
{
    int temp = rand.Next(10,100);
    if (temp % 2 != 0)
    {
        T1[i] += temp;
        i++;
    }
}

System.Console.WriteLine("Tablica T1 posiada liczby:");
for (int i = 0; i < 15; i++){
    System.Console.Write(T1[i]+", ");
}
System.Console.WriteLine();



// zad 2
int[] T2 = new int[20];
for (int i = 0; i < 20;i++)
{
    int temp = rand.Next(10,100);
    int jedn = temp % 10;
    temp -= jedn;
    T2[i] += temp;
}

System.Console.WriteLine("Tablica T2 posiada liczby:");
for (int i = 0; i < 20; i++)
{
    System.Console.Write(T2[i]+", ");
}
System.Console.WriteLine();


// zad 3
ArrayList L = new ArrayList();

for(int i = 0; i < 12;){
    int temp = rand.Next(10,100);
    if (temp % 7 == 0)
    {
        L.Add(temp);
        i++;
    }
}
System.Console.WriteLine("Lista L posiada liczby:");
for (int i = 0; i < L.Count; i++) System.Console.Write(L[i]+", ");
