using System;

int euklidesOdejmowanie(int a, int b){
    while (a != b){
        if (a > b) a -= b;
        else b -= a;
    }
    return a;
}

int euklidesModulo(int a, int b){
    while(b > 0){
        int pom = b;
        b = a % b;
        a = pom;
    }
    return a;
}

System.Console.WriteLine("Daj liczbe:");
int x = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Daj liczbe:");
int y = Convert.ToInt32(System.Console.ReadLine());


System.Console.WriteLine($"euklides odejmowanie: {euklidesOdejmowanie(x,y)}");
System.Console.WriteLine($"euklides modulo: {euklidesModulo(x,y)}");

