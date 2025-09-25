namespace PrzedSprawdzian;

public class Book : Document, IPrintable
{
    public Book(string title) : base(title)
    {
    }

    public Book(Book book) : base($"{book.getTitle()} copy")
    {
    }

    public void Print()
    {
        Console.WriteLine($"Printing book {getTitle()}");
    }
}