#pragma warning disable

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




/////////////////////////////////////////////////////////////////////////////////////////////
// Druga część diagnozy

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

int[,] E = new int[len,len];

for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        E[i,j] = rand.Next(1, 10);
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
        if (E[i,j] == E[i + 1,j]){
            if (CzyPierwsza(E[i,j])) ilePierwszych ++;
        }
        if (E[i,j] == E[i,j + 1]){
            if (CzyPierwsza(E[i,j])) ilePierwszych ++;
        }
    }
}

for (int i = 0; i < len - 1; i++){
    if (E[i,len - 1] == E[i + 1,len - 1]){
            if (CzyPierwsza(E[i,len - 1])) ilePierwszych ++;
        }
}

for (int j = 0; j < len - 1; j++){
    if (E[len - 1,j] == E[len - 1,j + 1]){
            if (CzyPierwsza(E[len - 1, j])) ilePierwszych ++;
        }
}

System.Console.WriteLine("Tablica pierwsze");
for (int i = 0; i < len; i++){
    for (int j = 0; j < len; j++){
        System.Console.Write(E[i,j] + ", ");
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