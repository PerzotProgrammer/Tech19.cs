using System.Collections;
using System.IO;
using System;


StreamReader czytaj = new StreamReader("przyklad.txt");
ArrayList ciag = new ArrayList();

while(!czytaj.EndOfStream) ciag.Add(czytaj.ReadLine());

int[] L = new int[ciag.Count];
string[] N = new string[ciag.Count];

int k = 0;
foreach (string item in ciag){
    string[] linia = item.Split(" ");
    L[k] = Convert.ToInt32(linia[0]);
    N[k] = linia[1];
    k++;
}

bool CzyPierwsza(int x){
    for(int i = 2; i < x; i++){
        if(x % i == 0) return false;
    }
    return true;
}

for (int i = 0; i < L.Length; i++){
    if (L[i] > 4 && L[i] % 2 == 0){
        for (int j = 3; j < L[i]; j++){
            if (CzyPierwsza(j) && CzyPierwsza(L[i] - j)){
                System.Console.WriteLine($"{L[i]} {j} {L[i] - j}");
                break;
            }
        }
    }
} 