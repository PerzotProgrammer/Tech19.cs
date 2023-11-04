using System.Collections;

namespace ToDoCMD;

internal class Program
{
    private static void Main(string[] args)
    {
        bool loop = true;

        Console.WriteLine("Menadżer Zadań");
        Console.WriteLine();

        while (loop)
        {
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("w - wyświetl zadania");
            Console.WriteLine("d - dodaj zadania");
            Console.WriteLine("e - edytuj zadania");
            Console.WriteLine("q - wyjdź");
            Console.WriteLine();
            Console.Write("Twoja opcja: ");

            char option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case 'q':
                    Console.Clear();
                    Exit();
                    break;

                case 'w':
                    Wczytaj();
                    break;

                case 'd':
                    Dodaj(); 
                    break;

                case 'e':
                    Edytuj();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("Zły argument!");
                    Console.WriteLine();
                    break;
            }
        }


        bool Exit() { return loop = false; }

        void Wczytaj()
        {
            StreamReader sr = new StreamReader("./data.txt");

            Console.Clear();
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine();
        }

        void Dodaj()
        {
            StreamReader sr = new StreamReader("./data.txt");
            int numOfLines = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numOfLines++;
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("./data.txt", true);

            Console.Clear();
            
            Console.WriteLine("Podaj zadanie do dodania:");
            string msg = Convert.ToString($"{numOfLines} - {Console.ReadLine()}");
            sw.WriteLine(msg);
            sw.Close();
            Console.Clear();
        }

        void Edytuj()
        {
            Console.Clear();
            Console.WriteLine("Czy chcesz nadpisać wszystkie dane: t/n");
            char option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (option)
            {
                case 't':
                    StreamWriter sw1 = new StreamWriter("./data.txt");

                    sw1.WriteLine();
                    sw1.Close();
                    break;

                case 'n':
                    Console.WriteLine("Wybierz linię:");
                    int line = Convert.ToInt32(Console.ReadLine());
                    StreamReader sr = new StreamReader("./data.txt");
                    ArrayList dataLine = new ArrayList();
                    while (!sr.EndOfStream)
                    {
                        dataLine.Add(sr.ReadLine());
                    }

                    sr.Close();
                    Console.WriteLine("Podaj zadanie do dodania:");
                    string wiadomosc = Convert.ToString($"{line} - {Console.ReadLine()}");
                    StreamWriter sw2 = new StreamWriter("./data.txt");

                    for (int i = 0; i < dataLine.Count; i++)
                    {
                        if (i == line)
                        {
                            sw2.WriteLine(wiadomosc);
                        }
                        else
                        {
                            sw2.WriteLine(dataLine[i]);
                        }
                    }
                    sw2.Close();
                    Console.Clear();
                    break;

                default:
                    Console.Clear() ;
                    Console.WriteLine("Zły argument!");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }
        }
    }
}