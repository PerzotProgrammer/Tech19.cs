using System;

Random Rand = new Random();
int[] T = new int[1000];

for(int i = 0; i < T.Length; i++) T[i] = Rand.Next(1000);


void QuickSortHoare(int[] T,int lewy, int prawy){
    int i = lewy;
    int j = prawy;
    int pivot = T[(lewy + prawy) / 2];
    while(i <= j)
    {
        while(T[i] < pivot) i++;
        while(T[j] > pivot) j--;
        if(i <= j)
        {
            int temp = T[i];
            T[i] = T[j];
            T[j] = temp;
            i++;
            j--;
        }
        if(lewy < j)
        {
            QuickSortHoare(T, lewy, j);
        }
        if(prawy > i)
        {
            QuickSortHoare(T, i ,prawy);
        }
    }
}

QuickSortHoare(T, 0, (T.Length) - 1);
foreach(int i in T) System.Console.Write(i + ", ");
System.Console.WriteLine();