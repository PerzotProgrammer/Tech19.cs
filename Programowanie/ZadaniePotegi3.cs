// UWAGA!!!
// PLIK *.txt dajesz do tego samego folderu co Program.cs


#pragma warning disable
int ilosc = 1000000;
StreamWriter dodaj = new StreamWriter("../../../liczby.txt");
for (int i = 1; i < ilosc + 1; i++) dodaj.WriteLine(i);
dodaj.Close();

StreamReader liczby = new StreamReader("../../../liczby.txt");
int[] T = new int[ilosc];
int linia = 0;
int[] POW = new int[20];
int licznik = 0;
int pot = 0;

for(int i = 0; i < POW.Length; i++) POW[i] = (int)Math.Pow(3, i);



while (!liczby.EndOfStream)
{
    T[linia] = int.Parse(liczby.ReadLine());
    for (int i = pot; i < POW.Length; i++)
        if (POW[i] == T[linia])
        {
            licznik++;
            pot++;
            break;
        }
    linia++;
}
Console.WriteLine(licznik);
