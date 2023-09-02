using System.IO;
using System;

// UWAGA!!!
// PLIK *.txt dajesz do tego samego folderu co Program.cs


#pragma warning disable
StreamReader lamaniec = new StreamReader(".txt/lamaniec.txt");
while (!lamaniec.EndOfStream) Console.WriteLine(lamaniec.ReadLine()+"\t");

Console.WriteLine("\n\n\n\n\n\n");

StreamWriter dodaj = new StreamWriter(".txt/liczby.txt");

for (int i = 0; i < 1000; i++) dodaj.WriteLine(i);

dodaj.Close();

StreamReader liczby = new StreamReader(".txt/liczby.txt");

int[] Czyt = new int[1000];
int linia = 0;
while (!liczby.EndOfStream)
{
    Czyt[linia] = int.Parse(liczby.ReadLine());
    Console.WriteLine(Czyt[linia] + "\t");
    linia++;
}
