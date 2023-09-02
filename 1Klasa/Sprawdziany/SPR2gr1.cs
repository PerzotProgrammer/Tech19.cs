using System;
using System.Collections;
// zad1
System.Console.WriteLine("ZADANIE 1");
int n = Convert.ToInt32(System.Console.ReadLine());
ArrayList Array = new ArrayList();
for (int i = 1; i <= n; i++){
    if(n % i == 0){
        Array.Add(i);
    }
}
System.Console.WriteLine("Twoja ArrayLista:");
foreach(int i in Array) System.Console.Write(i + ", ");
System.Console.WriteLine();
// zad2

bool CzyPierwsza(int x){
    for (int i = 2; i < x; i++){
        if (x % i == 0){
            return false;
        }
    }
    return true;
}

bool CzyPodzielnaLiczbamiZad2 (int x){
    if(x % 2 == 0 && x % 3 == 0 && x % 5 == 0 && x % 7 == 0) return true;
    else; return false;
}

System.Console.WriteLine("ZADANIE 2");
Random r = new Random();
ArrayList Randomy = new ArrayList();
int ile = 0;
while (ile < 20){
    int spr = r.Next(100,1000);
    if (!(CzyPierwsza(spr) && CzyPodzielnaLiczbamiZad2(spr))){
        Randomy.Add(spr);
        ile++;
    }
}
System.Console.WriteLine("Twoje Randomy:");
foreach (int i in Randomy) System.Console.Write(i + ", ");
System.Console.WriteLine();