using System;

Random r = new Random();
int n = 100;
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(1, 100);
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");


void scalaj(int lewy, int prawy)  //0-3
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++) pom[a] = T[a]; 
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy;  // indeks tabeli
    i_lewy = lewy;
    i_prawy = srodek + 1;

    while (i_lewy <= srodek && i_prawy <= prawy)
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else
        {
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
        while (i_prawy <= prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    else
        while (i_lewy <= srodek)
        {
            T[i] = pom[i_lewy];
            i_lewy++;
            i++;
        }
}

void sortuj(int lewy, int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < srodek)
    {
        sortuj(lewy, srodek);
    }
    if (srodek + 1 < prawy)
    {
        sortuj(srodek + 1, prawy);
    }
    scalaj(lewy, prawy);
}

sortuj(0, n-1);

for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
System.Console.WriteLine();