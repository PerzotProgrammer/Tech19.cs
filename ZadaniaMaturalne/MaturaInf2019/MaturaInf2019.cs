using System.IO;
using System;

// zad 4

StreamReader liczby = new StreamReader("liczby.txt");
StreamWriter wpiszLiczby = new StreamWriter("wyniki4_1.txt");


bool CzyPierwsza(int x){
    for (int i = 2; i < x; i++){
        if (x % i == 0){
            return false;
        }
    }
    return true;
}


while(!liczby.EndOfStream){
    int spr = Convert.ToInt32(liczby.ReadLine());
    if (CzyPierwsza(spr) && spr <= 5000 && spr >= 100) wpiszLiczby.WriteLine(spr);
}

wpiszLiczby.Close();