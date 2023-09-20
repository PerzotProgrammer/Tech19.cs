using System;

System.Console.WriteLine("zadanie 1");
System.Console.WriteLine();

System.Console.Write("Podaj dwielkość tablicy: ");
int len = Convert.ToInt32(System.Console.ReadLine());

int[,] A = new int[len,len];
int[,] B = new int[len,len];
int[,] C = new int[len,len];

Random rand = new();

for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        A[i,j] = rand.Next(1, 10);
    }
}

for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        B[i,j] = rand.Next(1, 10);
    }
}

for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        C[i,j] = A[i,j] * B[i,j];
    }
}

System.Console.WriteLine("Pierwsza tablica");
for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        System.Console.Write(A[i,j] + ", ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine();

System.Console.WriteLine("Druga tablica");
for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        System.Console.Write(B[i,j] + ", ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine();

System.Console.WriteLine("Trzecia tablica");
for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        System.Console.Write(C[i,j] + ", ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

System.Console.WriteLine("zadanie 2");
System.Console.WriteLine();

int[,] D = new int[len,len];

for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        D[i,j] = rand.Next(1, 10);
    }
}

int ilePierwszych = 0;

bool CzyPierwsza(int x){
    if (x == 1) return false;
    for (int i = 2; i < x; i++){
        if (x % i == 0) return false;
    }
    return true;
}

for (int i = 0; i < len - 1; i++){
    for (int j = 0; j < len - 1; j++){
        if (D[i,j] == D[i + 1,j]){
            if (CzyPierwsza(D[i,j])) ilePierwszych ++;
        }
        if (D[i,j] == D[i,j + 1]){
            if (CzyPierwsza(D[i,j])) ilePierwszych ++;
        }
    }
}

for (int i = 0; i < len - 1; i++){
    if (D[i,len - 1] == D[i + 1,len - 1]){
            if (CzyPierwsza(D[i,len - 1])) ilePierwszych ++;
        }
}

for (int j = 0; j < len - 1; j++){
    if (D[len - 1,j] == D[len - 1,j + 1]){
            if (CzyPierwsza(D[len - 1, j])) ilePierwszych ++;
        }
}

System.Console.WriteLine("Tablica pierwsze");
for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        System.Console.Write(D[i,j] + ", ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine($"W macierzy jest {ilePierwszych} liczb pierwszych obok siebie");


System.Console.WriteLine();

System.Console.WriteLine("zadanie 3");
System.Console.WriteLine();

System.Console.Write("Daj stringa: ");
string an1 = Convert.ToString(System.Console.ReadLine());

System.Console.Write("Daj stringa: ");
string an2 = Convert.ToString(System.Console.ReadLine());

char[] anC1 = an1.ToLower().ToCharArray();
char[] anC2 = an2.ToLower().ToCharArray();

Array.Sort(anC1);
Array.Sort(anC2);

string check1 = new(anC1);
string check2 = new(anC2);

if(check1 == check2) System.Console.WriteLine("Są to anagramy");
else System.Console.WriteLine("Nie są to anagramy");
