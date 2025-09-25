namespace PrzedSprawdzian;

class Program
{
    static void Main(string[] args)
    {
        List<IPrintable> list = new List<IPrintable>()
        {
            new Report("Report1"),
            new Book("Book1"),
            new Book("Book2"),
            new Book("book3")
        };

        if (list[0] is Report r1) list.Add(new Report(r1));
        
        if (list[2] is Book b2) list.Add(new Book(b2));

        foreach (IPrintable printable in list) printable.Print();
    }
}