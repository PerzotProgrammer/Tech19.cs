// Potrzeba do ArrayList
using System.Collections;


// Deklaracja
int[] T1 = new int[10];

// Definicja
T1[0] = 10;
T1[5] = 5;

// I to i to
int[] T2 = new int[] {1,2,3,4};

// Przechodzenie po tablicy
System.Console.WriteLine("FOR");
for (int i = 0; i < T1.Length; i++) System.Console.WriteLine(T1[i]);
System.Console.WriteLine();

System.Console.WriteLine("FOREACH");
foreach (int i in T2) System.Console.WriteLine(i);
System.Console.WriteLine();

// 2 wymiary
int[,] T3 = new int[,] {{11,12,13},{21,22,23},{31,32,33}};

System.Console.WriteLine("Pierwszy sposob");
for (int i = 0 ; i < T3.Length; i++) 
{
    System.Console.WriteLine(T3[i/4,i%3]);
}
System.Console.WriteLine();


System.Console.WriteLine("Drugi sposob");
for (int i = 0; i < T3.GetLength(0); i++)
{
    for (int j = 0; j < T3.GetLength(1); j++)
    {
        System.Console.Write(T3[i,j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

// ArrayLista
System.Console.WriteLine("ArrayLista");
ArrayList A = new ArrayList();

for (int i = 0; i < 100; i++) A.Add(i);

foreach (int i in A) System.Console.WriteLine(i);
// W forze
// for (int i = 0; i < A.Count; i++) System.Console.WriteLine(A[i]);