namespace PrzedSpr11._10;
# pragma warning disable CS8602
class Program
{
    static void Main(string[] args)
    {
        Zadanie1();
        Zadanie2();
        Zadanie3();
        // Zadanie4(); // nie rozumiem
    }

    static void Zadanie1()
    {
        // ZADANIE 1
        System.Console.WriteLine("ZADANIE 1");
        System.Console.WriteLine();

        // Funkcja, która sprawdza czy liczba jest pierwsza
        bool CzyPierwsza(int lp){
            for (int i = 2; i < lp; i++) if (lp % i == 0) return false;
            return true;
        }

        for (int i = 2; i < 200; i++){
            if (CzyPierwsza(i) && CzyPierwsza(i * 2 + 1)) System.Console.WriteLine($"Liczbą Ibrahima (kto to jest???) jest: {i}");
        }

    }
    static void Zadanie2()
    {
        // ZADANIE 2

        System.Console.WriteLine("ZADANIE 2");
        System.Console.WriteLine();
        int len = 20;

        // Macierz o jeden więkrza
        int[,] T = new int[len + 1,len + 1];

        // Random
        Random Rand = new();
        for (int i = 0; i < len; i++) for (int j = 0; j < len; j++) T[i,j] = Rand.Next(1,10);

        // Dodanie zer do końca indeksów
        for (int i = 0; i < len; i++) T[i, len] = 0;
        for (int j = 0; j < len; j++) T[len, j] = 0;

        // Wypisanie macierzy
        for (int i = 0; i < len; i++) {
            for (int j = 0; j < len; j++) {
                System.Console.Write(T[i,j] + ",");
            }
            System.Console.WriteLine();
        }

        // Zliczenie sąsiadów
        int ileSasiadow = 0;
        for (int i = 0; i < len; i++) {
            for (int j = 0; j < len; j++) {
                if (T[i + 1,j] + T[i,j + 1] == T[i,j]) ileSasiadow ++;
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Sąsiadów w macierzy jest: {ileSasiadow}");
    }

    static void Zadanie3()
    {
        System.Console.WriteLine("ZADANIE 3");
        System.Console.WriteLine();

        System.Console.Write("Podaj cyfre ciołku: ");
        string? liczba = System.Console.ReadLine();

        // Not so MONKE
        int[] Ile = {0,0,0,0,0,0,0,0,0,0};
        foreach (char cyfra in liczba) {
            switch (cyfra){
                case '0':
                Ile[0] ++;
                break;

                case '1':
                Ile[1] ++;
                break;

                case '2':
                Ile[2] ++;
                break;

                case '3':
                Ile[3] ++;
                break;

                case '4':
                Ile[4] ++;
                break;

                case '5':
                Ile[5] ++;
                break;

                case '6':
                Ile[6] ++;
                break;

                case '7':
                Ile[7] ++;
                break;

                case '8':
                Ile[8] ++;
                break;

                case '9':
                Ile[9] ++;
                break;
            }
        }

        int min = int.MaxValue;
        int indeks = 0;

        // Rozjebaned
        for (int i = 0; i < Ile.Length; i++) {
            if (min > Ile[i] && Ile[i] > 0) {
                min = Ile[i];
                indeks = i;
            }
        }
        System.Console.WriteLine($"W twojej liczbie najmniej jest cyfry {indeks}, występuje ona {min} razy");
    }

}

