// generator losowej tablicy
Console.WriteLine("GENERATOR LOSOWEJ TABLICY");
Console.Write("Podaj długość tablicy:");
int n = int.Parse(Console.ReadLine());

Console.Write("Podaj minimalną wartość losowania: ");
int pocz = int.Parse(Console.ReadLine());

Console.Write("Podaj maksymalną wartość losowania: ");
int kon = int.Parse(Console.ReadLine());

Console.WriteLine();

int[] T = new int[n];
Random x = new Random();
Console.Write("TABLICA T POSIADA LICZBY: ");
for (int i = 0; i < n; i++)
{
    T[i] = x.Next(pocz, kon + 1);
    Console.Write(T[i] + ", ");
}
Console.WriteLine();
Console.WriteLine();

// zadanie 1
int max = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        max = T[i];
    }
}
Console.WriteLine("Maksymalną liczbą jest: " + max);

// zadanie 2
int min = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.WriteLine("Minimalną liczbą jest: " + min);

// zadanie 3
int ileMax = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] == max)
    {
        ileMax++;
    }
}
Console.WriteLine("Ilość Maksymalnych wartości to: " + ileMax);

// zadanie 4
int ileMin = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] == min)
    {
        ileMin++;
    }
}
Console.WriteLine("Ilość Minimalnych wartości to: " + ileMin);

// zadanie 5
Console.WriteLine("Rozpiętość tablicy to: " + (max - min));

// zadanie 6
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine("Suma wartości w tablicy to: " + suma);

// zadanie 7
float srednia = (float)suma / n;
Console.WriteLine("Średnia wartości w tablicy to: " + srednia);

// zadanie 8
int iloscParzystych = 0, iloscNieparzystych = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] % 2 == 0)
    {
        iloscParzystych++;
    }
    else
    {
        iloscNieparzystych++;
    }
}
if (iloscParzystych > iloscNieparzystych)
{
    Console.WriteLine("Więcej jest liczb Parzystych, " + iloscParzystych);
}
else if (iloscParzystych < iloscNieparzystych)
{
    Console.WriteLine("Więcej jest liczb Nieparzystych, " + iloscNieparzystych);
}
else
{
    Console.WriteLine("Parzystych i Nieparzystych jest tyle samo, " + iloscParzystych);
}

// zadanie 9
int iloscPierwszych = 0;
for (int i = 0; i < n; i++)
{
    int temp = T[i];
    int spr = 0;
    for (int j = 1; j <= temp + 1; j++)
    {
        if (temp % j == 0)
        {
            spr++;
        }
    }
    if (spr == 2)
    {
        iloscPierwszych++;
    }
}
Console.WriteLine("Ilość liczb pierwszych to: " + iloscPierwszych);

// zadanie 10
int viceMax = T[0];
int viceMin = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] > viceMax && T[i] < max)
    {
        viceMax = T[i];
    }
    if (T[i] < viceMin && T[i] > min)
    {
        viceMin = T[i];
    }
}
Console.WriteLine("ViceMax = " + viceMax);
Console.WriteLine("ViceMin = " + viceMin);
