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
        Zadanie1();
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
}