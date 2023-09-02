using System;
// Karta mocno po terminie ale who cares?
// Niby funkcyjna ale funkcje moje

// Pre

int[] Tab = new int[40];
Random Rand = new Random();

for (int i = 0; i < Tab.Length; i++) Tab[i] = Rand.Next(10,100);

System.Console.WriteLine("Twoja tablica T zawiera elementy:");
foreach (int i in Tab) System.Console.Write(i + " ");
System.Console.WriteLine();


System.Console.WriteLine("Zadanie 1");

int Max(int[] T){
    int Max = T[0];
    for (int i = 0; i < T.Length; i++) if(Max < T[i]) Max = T[i];
    return Max;
}

int max = Max(Tab);
System.Console.WriteLine(max);


System.Console.WriteLine("Zadanie 2");

int Min(int[] T){
    int Min = T[0];
    for (int i = 0; i < T.Length; i++) if(Min > T[i]) Min = T[i];
    return Min;
}

int min = Min(Tab);
System.Console.WriteLine(min);


System.Console.WriteLine("Zadanie 3"); // Co to jest?
System.Console.WriteLine(Tab.Length);


System.Console.WriteLine("Zadanie 4");

int ViceMax(int[] T){
    int viceMax = T[0];
    int max = Max(T);
    for (int i = 0; i < T.Length; i++){
        if (viceMax < T[i]){
            int temp = T[i];
            if (temp < max){
                viceMax = temp;
            }
        }
    }
    return viceMax;
}

int viceMax = ViceMax(Tab);
System.Console.WriteLine(viceMax);


System.Console.WriteLine("Zadanie 5");

int ViceMin(int[] T){
    int viceMin = T[0];
    int min = Min(T);
    for (int i = 0; i < T.Length; i++){
        if (viceMin > T[i]){
            int temp = T[i];
            if (temp > min){
                viceMin = temp;
            }
        }
    }
    return viceMin;
}

int viceMin = ViceMin(Tab);
System.Console.WriteLine(viceMin);


System.Console.WriteLine("Zadanie 6");

int ileMax = 0;
foreach (int i in Tab){
    if(i == max){
        ileMax ++;
    }
}

System.Console.WriteLine(ileMax);


System.Console.WriteLine("Zadanie 7");

int ileMin = 0;
foreach (int i in Tab){
    if(i == min){
        ileMin ++;
    }
}

System.Console.WriteLine(ileMin);


System.Console.WriteLine("Zadanie 8");
System.Console.Write("Co chcesz wyszukać?:");
int szukaj = Convert.ToInt32(System.Console.ReadLine());

int ileJest = 0;
foreach (int i in Tab){
    if(i == szukaj){
        ileJest ++;
    }
}
System.Console.WriteLine($"Twój element występuje {ileJest} razy");