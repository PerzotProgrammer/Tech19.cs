using System.Collections;
using System;


// // zad1
// System.Console.WriteLine("Zadanie 1");
// int x = Convert.ToInt32(System.Console.ReadLine());

// int SumaCyfr(int n){
//     int suma = 0;
//     while (n > 0){
//         suma += n % 10;
//         n = n / 10;
//     }
//     return suma;
// }

// System.Console.WriteLine(SumaCyfr(x));


// // zad2
// string Odwracacz(string napis){
// char[] Odwr = napis.ToCharArray();
// Array.Reverse(Odwr);
// return new string(Odwr);
// }
// System.Console.WriteLine("Zadanie 2");
// string napis = System.Console.ReadLine();
// System.Console.WriteLine(Odwracacz(napis));


// // zad3
// System.Console.WriteLine("Zadanie 3");

// string Polowki(int x){
//     string wynik = Convert.ToString(x);
//     while (x > 1){
//         x /= 2;
//         wynik += "-" + Convert.ToString(x);
//     }
//     return wynik;
// }

// System.Console.WriteLine(Polowki(1000000));

// zad4
int Reku(int n){
    if (n == 1) return 1;
    if (n == 2) return 2;
    if (n == 3) return 3;
    return 3*Reku(n-3) - Reku(n-1);
}

System.Console.WriteLine(Reku(5));