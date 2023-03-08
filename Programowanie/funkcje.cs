using System;

// void PrzywitajSie(){
//     System.Console.WriteLine("Jak masz na imie lolu?");
//     string imie = System.Console.ReadLine();
//     imie = imie.ToUpper();
//     System.Console.WriteLine($"CZEŚĆ {imie}!");
// }

// PrzywitajSie();

// int Dodaj(int x, int y){
//     return x + y;
// }

// System.Console.WriteLine(Dodaj(1,2));

// string Odwroc(string ciag){
//     char[] odwrotnosc = ciag.ToCharArray();
//     Array.Reverse(odwrotnosc);
//     return new string(odwrotnosc);
// }

// System.Console.WriteLine(Odwroc("fyrtel poznanski"));

// int DodajNieskonczonosc(params int[] args){
//     int suma = 0;
//     for (int i = 0; i < args.Length; i++){
//         suma += args[i];
//     }
//     return suma;
// }
// System.Console.WriteLine(DodajNieskonczonosc(1,2,5,7,5,1,7,47,34));


// Kod z kartki

int reku1(int n){
    int w;
    if (n == 1) return 1;
    w = reku1(n/2);
    if (n % 2 == 0) w = w * 2;
    else w = w * 3;
    return w;
}

System.Console.WriteLine(reku1(75));


int reku2(int n){
    int w;
    if (n == 1) return 1;
    w = reku2(n - 1);
    if (n % 2 == 1) w++;
    else w = w * 2;
    return w;
}

System.Console.WriteLine(reku2(11));
