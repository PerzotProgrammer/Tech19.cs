using System.Diagnostics;

namespace Sortowania;

class Program
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        int[] array = new int[1];
        bool loopFlag = true;
        while (loopFlag)
        {
            Console.WriteLine("\nWybierz opcje:");
            Console.WriteLine("1: generuj tablice");
            Console.WriteLine("2: wypełnij tablice");
            Console.WriteLine("3: SelectionSort");
            Console.WriteLine("4: BubbleSort");
            Console.WriteLine("5: InsertionSort");
            Console.WriteLine("6: MergeSort");
            Console.WriteLine("7: QuickSort");
            Console.WriteLine("8: zamyka program");
            Console.WriteLine();
            Console.Write("Twój wybór: ");
            string chk = Console.ReadLine()!;
            Console.WriteLine();
            Stopwatch stopwatch;
            switch (chk)
            {
                case "1":
                    array = Sort.CreateArray();
                    break;
                case "2":
                    Sort.AutoFillArray(array);
                    break;
                case "3":
                    Sort.PrintArray(array, "Przed sortowaniem");
                    Sort.SelectionSort(array);
                    stopwatch = Stopwatch.StartNew();
                    stopwatch.Stop();
                    Sort.PrintArray(array, "Po SelectionSort");
                    Console.WriteLine($"Czas wykonania (tylko sortowanie): {stopwatch.Elapsed} milisekund");
                    break;
                case "4":
                    Sort.PrintArray(array, "Przed sortowaniem");
                    Sort.BubbleSort(array);
                    stopwatch = Stopwatch.StartNew();
                    stopwatch.Stop();
                    Sort.PrintArray(array, "Po BubbleSort");
                    Console.WriteLine($"Czas wykonania (tylko sortowanie): {stopwatch.Elapsed} milisekund");
                    break;
                case "5":
                    Sort.PrintArray(array, "Przed sortowaniem");
                    Sort.InsertionSort(array);
                    stopwatch = Stopwatch.StartNew();
                    stopwatch.Stop();
                    Sort.PrintArray(array, "Po InsertionSort");
                    Console.WriteLine($"Czas wykonania (tylko sortowanie): {stopwatch.Elapsed} milisekund");
                    break;
                case "6":
                    Sort.PrintArray(array, "Przed sortowaniem");
                    Sort.MergeSort(array);
                    stopwatch = Stopwatch.StartNew();
                    stopwatch.Stop();
                    Sort.PrintArray(array, "Po MergeSort");
                    Console.WriteLine($"Czas wykonania (tylko sortowanie): {stopwatch.Elapsed} milisekund");

                    break;
                case "7":
                    Sort.PrintArray(array, "Przed sortowaniem");
                    Sort.QuickSort(array);
                    stopwatch = Stopwatch.StartNew();
                    stopwatch.Stop();
                    Sort.PrintArray(array, "Po QuickSort");
                    Console.WriteLine($"Czas wykonania (tylko sortowanie): {stopwatch.Elapsed} milisekund");
                    break;
                case "8":
                    loopFlag = false;
                    break;
                default:
                    Console.WriteLine("Niepoprawna operacja");
                    break;
            }
        }
    }
}