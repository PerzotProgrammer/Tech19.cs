using System;
using System.Collections;
using System.Text.RegularExpressions;

Random Rand = new Random();
ArrayList Array = new ArrayList();

// zad1
System.Console.WriteLine("ZAD1");

int liczba = Convert.ToInt32(System.Console.ReadLine());

int dzies = liczba / 10;
int jed = liczba % 10;

int suma = dzies + jed;

System.Console.WriteLine();

int wyj = 0;
while(true){
    
    wyj += suma;
    if(wyj > 100) break;
    Array.Add(wyj);
}

foreach(int i in Array) System.Console.WriteLine(i);

System.Console.WriteLine();

// zad 2
System.Console.WriteLine("ZAD2");

int[] Tab = new int[20];

for(int i = 0; i < Tab.Length; i++){
    Tab[i] = Rand.Next(10,100);
}

for(int i = 0; i < Tab.Length; i++){
    Tab[i] = Tab[i] - (Tab[i] % 10);
}

foreach(int i in Tab) System.Console.WriteLine(i);

System.Console.WriteLine();

// zad 3
System.Console.WriteLine("ZAD3");

int[] Tab2 = new int[90];
for(int i = 0; i < Tab2.Length; i++){
    Tab2[i] = Rand.Next(10,100);
}

// PRINT KONTROLNY
foreach(int i in Tab2) System.Console.Write(i + " ");
System.Console.WriteLine();

int ileNieMa = 0;
for(int j = 10; j < 100; j++){
    bool czyJest = false;
    for(int i = 0; i < Tab2.Length; i++){
        if(Tab2[i] == j){
            czyJest = true;
            break;
        }
    }
    if(czyJest == false){
        ileNieMa++;
    }
}

System.Console.WriteLine($"Nie ma {ileNieMa} liczb");
System.Console.WriteLine();

// zad 4
System.Console.WriteLine("ZAD4");

// Funkcja bo tak mi się widzi
bool CzyPierwsza(int x){
    for(int i = 2; i < x; i++){
        if(x % i == 0) return false;
    }
    return true;
}


int[,] Macierz = new int[16,16];

for(int i = 0; i < Macierz.GetLength(0); i++){
    for(int j = 0; j < Macierz.GetLength(1); j++){
        Macierz[i,j] = Rand.Next(100,1000);
    }
}

suma = 0;

for(int i = 0; i < Macierz.GetLength(0); i++){
    for(int j = 0; j < Macierz.GetLength(1); j++){
        if(CzyPierwsza(Macierz[i,j])){
            suma += Macierz[i,j];
        }
    }
}

// PRINT KONTROLNY
for(int i = 0; i < Macierz.GetLength(0); i++){
    for(int j = 0; j < Macierz.GetLength(1); j++){
        System.Console.Write(Macierz[i,j] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine($"Suma LP w Macierzy: {suma}");