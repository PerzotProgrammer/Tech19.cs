//// ROZGRZEWKA
//// Generator losowej tablicy
//int[] T = new int[100];
//Random x = new Random();
//Console.Write("TABLICA T POSIADA LICZBY: ");
//for (int i = 0; i < T.Length; i++)
//{
//    T[i] = x.Next(10, 100);
//    Console.Write(T[i] + ", ");
//}
//Console.WriteLine();
//Console.WriteLine();

////Ile parzystych
//int parzyste = 0;
//int nieparzyste = 0;
//int sumaP = 0;
//int sumaN = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    if (T[i] % 2 == 0)
//    {
//        parzyste++;
//        sumaP += T[i];
//    }
//    else
//    {
//        nieparzyste++;
//        sumaN += T[i];
//    }
//}

//Console.WriteLine($"Parzystych jest {parzyste}, nieparzystych jest {nieparzyste}");
//Console.WriteLine($"Suma parzystych to {sumaP}, nieparzystych {sumaN}");


///////////////////////////////////////////////////////////////////////////////////////////


// TABLICE 2-Wymiarowe
//DEKLARACJA
Console.WriteLine("ZADANIE 1");

int[,] M1 = new int[5,5];

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.Write(M1[i,j]+"\t");
    }
    Console.WriteLine();
}

// Stwórz macież a'la sudoku
Console.WriteLine();
Console.WriteLine("ZADANIE 2");
Console.WriteLine();

int[,] M2 = new int[,] { { 1,2,3 },{ 4,5,6 },{ 7,8,9 } };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(M2[i, j] + "\t");
    }
    Console.WriteLine();
}

// Stwórz macież 4x4
Console.WriteLine();
Console.WriteLine("ZADANIE 3");
Console.WriteLine();

int[,] M3 = new int[4, 4];
int ink = 1;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        M3[i, j] = ink;
        ink++;
        Console.Write(M3[i,j]+"\t");
    }
    Console.WriteLine();
}

// Wypełnij 3x5 liczbami dwucyfrowymi za pomocą GetLenght();
Console.WriteLine();
Console.WriteLine("ZADANIE 4");
Console.WriteLine();

int[,] M4 = new int[3, 5];
ink = 11; //Zzzzz

for(int i = 0; i < M4.GetLength(0); i++)
{
    for(int j = 0; j < M4.GetLength(1); j++)
    {
        M4[i, j] = ink;
        ink++;
        Console.Write(M4[i, j]+"\t");
    }
    Console.WriteLine();
}