namespace Program
{
    class MainProcess
    {
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj podstawę: ");
            int pod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wynik konwersji: {KonwertujNaSystem(liczba, pod)}");
            Console.WriteLine();

            Console.Write("Podaj liczbę dziesiętną: ");
            int liczbaDec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wynik konwersji: {KonwertujNaBin(liczbaDec)}");
            Console.WriteLine();

            Console.Write("Podaj liczbę binarną: ");
            int liczbaBin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wynik konwersji: {KonwertujNaDec(liczbaBin)}");
        }

        static int KonwertujNaSystem(int liczba = 1010, int pod = 2)
        {
            string liczStr = liczba.ToString();
            int wynik = liczStr[0] - 48;

            for (int i = 1; i < liczStr.Length; i++)
            {
                wynik = pod * wynik + (liczStr[i] - 48);
            }

            return wynik;
        }

        static int KonwertujNaBin(int liczba = 10)
        {
            string wynik = "";

            while (liczba > 0)
            {
                int znak = liczba % 2;
                liczba /= 2;
                wynik += znak.ToString();
            }

            char[] obrot = wynik.ToCharArray();
            Array.Reverse(obrot);
            string bin = new(obrot);

            int ret = Convert.ToInt32(bin);
            return ret;
        }

        static int KonwertujNaDec(int liczba = 1010)
        {
            char[] obrot = liczba.ToString().ToCharArray();
            Array.Reverse(obrot);
            string strLiczba = new(obrot);

            int wynik = 0;

            for (int i = 0; i < strLiczba.Length; i++)
            {
                if (strLiczba[i] == '1')
                {
                    wynik += (int) Math.Pow(2,i);
                }
            }
            
            return wynik;
        }
    }
}