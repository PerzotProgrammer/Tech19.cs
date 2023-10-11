using System.Collections;

namespace SprPOpr11._10;
# pragma warning disable CS8602
class Program
{
    static void Main(string[] args)
    {

        
        Zadanie0();
        Zadanie1();
        Zadanie2();
        Zadanie3();

        /* Zadanie4();

            Kurcze no nie wiem jak zrobić zadanie 3 :(
            Myślałem, że jest proste ale jednak nie i spasuje.

            EDIT: Jednak wszystko bangla :D

            A przez pierwszy miesiąc nauki;
            - Zrobiłem kilkanaście zadań na stronie CTFlearn
            - Pouczyłem się programować obiektowo
            - Stworzyłem kilka testowych aplikacji w WPFie
            - Dostałem jedynkę z historii i niemieckiego
        */
    }

    static void Zadanie0()
    {
        System.Console.WriteLine("ZADANIE 0");
        for (int i = 20; i < 50; i++)
        {
            for (int j = 20; j < 50; j++) if (IbrahimPasza(i,j) && i != j) System.Console.WriteLine($"{i},{j}");
        }
    }
    static void Zadanie1()
    {
        System.Console.WriteLine("ZADANIE 1");
        Random Rand = new();
        int len = 20;
        int[,] T = new int[len + 1,len + 1];


        for (int i = 0; i < len; i++) 
        {
            for (int j = 0; j < len; j++)
            {
                int rand = Rand.Next(0,10);
                if (rand <= 4) 
                {
                    T[i,j] = 0;
                } 
                else if (rand <= 6)
                {
                    T[i,j] = 1;
                }
                else if (rand <= 8)
                {
                    T[i,j] = 2;
                }
                else 
                {
                    rand = Rand.Next(3,5);
                    T[i,j] = rand;
                }
            }
        }

        System.Console.WriteLine("Twoja macierz:");
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++) System.Console.Write($"{T[i,j]},");
            System.Console.WriteLine();
        }

        // Clue programu czyli Kołej
        int kolej = 0;
        for (int i = 1; i < len; i++)
        {
            for (int j = 1; j < len; j++)
            {
                int sasiedziGora = T[i - 1,j - 1] + T[i - 1,j] + T[i - 1, j + 1];
                int sasiedziObok = T[i, j - 1] + T[i, j + 1];
                int sasiedziPod = T[i + 1,j - 1] + T[i + 1,j] + T[i + 1, j + 1];
                int sasiedziRazem = sasiedziGora + sasiedziObok + sasiedziPod;

                if (sasiedziRazem == T[i,j]) kolej ++;
            }
        }
        System.Console.WriteLine($"Jest {kolej} komórek Kołejowskich");
    }

    static void Zadanie2()
    {
        System.Console.WriteLine("ZADANIE 2");
        System.Console.Write("Podaj kod Buraku: ");
        string? burak = System.Console.ReadLine();
        if (burak.Length < 20) 
        {
        System.Console.WriteLine("Za krótki ten kod :/");
        return;
        }
        int[] Liczby = {0,0,0,0,0,0,0,0,0,0};
        for (int i = 0; i < 20; i++)
        {
            switch (burak[i])
            {
                case '0':
                Liczby[0]++;
                break;
                case '1':
                Liczby[1]++;
                break;
                case '2':
                Liczby[2]++;
                break;
                case '3':
                Liczby[3]++;
                break;
                case '4':
                Liczby[4]++;
                break;
                case '5':
                Liczby[5]++;
                break;
                case '6':
                Liczby[6]++;
                break;
                case '7':
                Liczby[7]++;
                break;
                case '8':
                Liczby[8]++;
                break;
                case '9':
                Liczby[9]++;
                break;
            }
        }

        int ind1 = -1;
        int ind2 = -1;
        int max = 0;
        
        for (int i = 0; i < Liczby.Length; i++)
        {
            if (max < Liczby[i])
            {
                max = Liczby[i];
                ind1 = i;
                
            }
            else if (max == Liczby[i])
            {
                ind2 = i;
            }
        }
        if (ind1 >= 0 && ind2 >= 0) System.Console.WriteLine($"Dominandy {ind1}, {ind2}");
        else System.Console.WriteLine("Nie ma dwóch dominand");
    }

    static void Zadanie3()
    {
        System.Console.WriteLine("ZADANIE 3");
        System.Console.Write("Podaj Fennanę: ");
        int fennana = Convert.ToInt32(System.Console.ReadLine());
        bool flaga = false;
        for (int i = 1; i < fennana; i++)
        {
            ArrayList Stack = new();
            int suma = 0;
            for (int j = i; j < fennana; j++)
            {
                Stack.Add(j);
                suma += j;
                if (suma == fennana)
                {
                    System.Console.Write("Zestawik: ");
                    foreach (var el in Stack) System.Console.Write($"{el},");
                    System.Console.WriteLine();
                    suma = 0;
                    flaga = true;
                    Stack.Clear();
                    break;
                }
            }
        }
        if (!flaga) System.Console.WriteLine("Nie ma Fennany");
    }

    static bool CzyPierwsza(int lp)
    {
        for (int i = 2; i < lp; i++) if (lp % i == 0) return false;
        return true;
    }

    static int NWD(int a, int b)
    {
        while (a != b) if (a > b) a -= b; else b -= a;
        return a;
    }

    static bool IbrahimPasza(int a, int b)
    {
        if (!CzyPierwsza(NWD(a,b))) return true;
        else return false;
    }
}
