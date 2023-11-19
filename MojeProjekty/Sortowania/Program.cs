namespace Sortowania;

class Program
{
    static void Main()
    {
        Sort sort = new();
        sort.AutoFillArray(0, 100);
        sort.PrintArray("Przed sortowaniem");
        sort.SelectionSort();
        sort.ReverseArray();
        sort.PrintArray("Po SelectionSort");
    }
}