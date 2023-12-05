namespace Listy;

class Program
{
    // // Zwykła deklaracja obiektu klasy List
    // List<int> list1 = new();
    //
    // // z inicjalizacją
    // List<int> list2 = new() { 10, 2, 52, 6, 34, 76 };
    //
    // // Dodawanie elementów
    // list1.Add(10);
    // list1.Add(5);
    // list1.Add(15);
    // list1.Add(10);
    //
    // // Usuwanie elementów
    // // usuwa pierwszy pasujący element
    // list1.Remove(10);
    //
    // foreach (int i in list1) Console.WriteLine(i);
    //
    // // Długość
    // int length = list1.Count;
    // Console.WriteLine($"długość listy: {length}");

    static void Main()
    {
        // Zadanie1();
        Zadanie2();
    }

    static void Zadanie1()
    {
        //*	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
        //*	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
        //*	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.

        List<int> list = new();
        Random random = new();

        for (int i = 0; i < 10; i++) list.Add(random.Next(1, 100));

        Console.WriteLine("Pierwotna lista:");
        foreach (int i in list) Console.Write($"{i}, ");

        Console.WriteLine();
        List<int> podzielne = ZwrocPodzielne(list);

        Console.WriteLine("Zwrócona lista:");
        foreach (int i in podzielne) Console.Write($"{i}, ");
    }

    static void Zadanie2()
    {
        // * Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi wartościami z zakresu od 1 do 100.
        // * Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
        // * Wyświetlić listę liczb podzielnych przez 3 lub 5
        // * Wyświetlić listę liczb nieparzystych
        // * Wyświetlić listę liczb posortowanych rosnąco
        // * Wyświetlić listę liczb posortowanych malejąco
        // * Wyjść z programu
        // * Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę liczb spełniających warunek danej opcji.
        // * Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a następnie wyświetla wynikową listę na konsoli.
        // * Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik nie wybierze opcji wyjścia z programu.

        List<int> list = new();
        Random random = new();

        for (int i = 0; i < 50; i++) list.Add(random.Next(1, 100));

        int wybor = 0;
        while (wybor != 5)
        {
            Console.WriteLine("Wybierz co chcesz zrobić");
            Console.WriteLine("1. Wyświetl liczby podzielne przez 3 i 5");
            Console.WriteLine("2. Wyświetl liczby nieparzyste");
            Console.WriteLine("3. Wyświetl liczby posortowane rosnąco");
            Console.WriteLine("4. Wyświetl liczby posortowane malejąco");
            Console.WriteLine("5. Zakończ program");

            Console.Write("Podaj wybór: ");
            wybor = Convert.ToInt32(Console.ReadLine());

            List<int> output = new();
            
            switch (wybor)
            {
                case 1:
                    output = ZwrocPodzielne(list);
                    
                    Console.WriteLine("Twoje liczby:");
                    foreach (int element in output) Console.Write($"{element}, ");
                    Console.WriteLine();
                    break;
                case 2:
                    output = ZwrocNieparzyste(list);
                    
                    Console.WriteLine("Twoje liczby:");
                    foreach (int element in output) Console.Write($"{element}, ");
                    Console.WriteLine();
                    break;
                case 3:
                    // Dokończyć
                    break;
                case 4:
                    
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Nie ma takiej akcji!");
                    break;
            }
        }
    }

    static List<int> ZwrocPodzielne(List<int> list)
    {
        List<int> returnList = new();

        foreach (int element in list)
        {
            if (element % 3 == 0 || element % 5 == 0)
            {
                returnList.Add(element);
            }
        }

        return returnList;
    }
    
    static List<int> ZwrocNieparzyste(List<int> list)
    {
        List<int> returnList = new();

        foreach (int element in list)
        {
            if (element % 2 != 0)
            {
                returnList.Add(element);
            }
        }

        return returnList;
    }
}