//Tablice - Przypisywanie

int[] T1 = new int[5];
T1[0] = 3;
T1[1] = 5;
T1[2] = 6;
T1[3] = 9;
T1[4] = 13;

Console.WriteLine(T1);
for (int i = 0; i < T1.Length; i++) Console.WriteLine(T1[i]);



//Tablice - Przypisywanie Listą

int[] T2 = { 3, 5, 6, 9, 13 };

Console.WriteLine(T2);
for (int i = 0; i < T2.Length; i++) Console.WriteLine(T2[i]);





//znajdź maks w tablicy
int[] T3 = { 4, 5, 8, 9, 7, 6 };
int maks = T3[0];
for (int i = 0; i < T3.Length; i++) if (T3[i] > maks) maks = T3[i];
Console.WriteLine($"Największa wartość to: {maks}");

//znajdź mini w tablicy
int[] T4 = { 6, 2, 1, 4, 9, 5 };
int mini = T4[0];
for (int i = 0; i < T4.Length; i++) if (T4[i] < mini) mini = T4[i];
Console.WriteLine($"Najmniejsza wartość to: {mini}");

