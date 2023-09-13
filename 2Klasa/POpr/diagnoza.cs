using System;

// zad1
Console.Write("Daj liczbe: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Daj liczbe: ");
int y = Convert.ToInt32(Console.ReadLine());


int NWD(int a, int b)
{
    while(a != b){
        if(a > b) a -= b;
        else b -= a;
    }
    return a;
}

int NWW(int a, int b) { return a * b / NWD(a, b); }

Console.WriteLine($"NWD: {NWD(x, y)}\nNWW: {NWW(x, y)}");

// zad 2

Console.Write("Daj ułamka: ");
string pier = Convert.ToString(Console.ReadLine());
Console.Write("Daj ułamka: ");
string drug = Convert.ToString(Console.ReadLine());

string[] P = pier.Split("/");
string[] D = drug.Split("/");

int a = Convert.ToInt32(P[0]);
int b = Convert.ToInt32(P[1]);
int c = Convert.ToInt32(D[0]);
int d = Convert.ToInt32(D[1]);

int mianownik = NWW(b, d);
int licz1 = mianownik * a / b;
int licz2 = mianownik * c / d;

if (licz1 + licz2 >= mianownik) Console.WriteLine("Jest to ułamek niewiłaściwy");
else Console.WriteLine("Nie jest to ułamek niewiłaściwy");


// zad 4
Console.Write("Daj słowo: ");
string slowo1 = Convert.ToString(Console.ReadLine());
int ileSamoglosek = 0;
string samogloski = "aeiouyąęó";
int dlugosc = slowo1.Length;

foreach(char i in samogloski) foreach(char j in slowo1) if (i == j) ileSamoglosek ++;

Console.WriteLine($"Tyle samogłosek: {ileSamoglosek}\nTyle spółgłosek {dlugosc - ileSamoglosek}");

if (ileSamoglosek == dlugosc - ileSamoglosek) Console.WriteLine("Jest tyle samo samogłosek jak spółgłosek");
else if (ileSamoglosek > dlugosc - ileSamoglosek) Console.WriteLine("Więcej jest samogłosek");
else Console.WriteLine("Więcej jest spółgłosek");

// zad 5

string literki = "abcdefghijklmnopqrstuvwxyząęłżźó";

Console.Write("Daj słowo: ");
string slowo2 = Convert.ToString(Console.ReadLine());
slowo2 = slowo2.ToLower();

foreach (char i in literki) 
{
    int ileLiterki = 0;
    foreach (char j in slowo2) if (i == j) ileLiterki ++;
    if (ileLiterki > 0) Console.WriteLine($"Literki {i} występuje w słowie {ileLiterki} razy");
}


// // zad 10
// // nie działa :<
// System.Console.Write("Daj ile osób: ");
// int lawka1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Daj ile osób: ");
// int lawka2 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Daj ile osób: ");
// int lawka3 = Convert.ToInt32(System.Console.ReadLine());


// System.Console.Write("Ile osób przybyło: ");
// int m = Convert.ToInt32(System.Console.ReadLine());

// int max = 0;
// if (lawka1 > lawka2 && lawka1 > lawka3) max = lawka1;
// if (lawka2 > lawka3 && lawka2 > lawka1) max = lawka2;
// if (lawka3 > lawka1 && lawka3 > lawka2) max = lawka3;

// int k = max + m;
// System.Console.WriteLine($"K = {k}");

// int min = (lawka1 + lawka2 + lawka3 + k) / 3;