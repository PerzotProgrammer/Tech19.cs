namespace Biblioteka.Classes;

public class Library
{
    public List<Book> Books { get; private set; }
    public List<Author> Authors { get; private set; }
    public List<Reader> Readers { get; private set; }

    public Library()
    {
        Books = new List<Book>();
        Authors = new List<Author>();
        Readers = new List<Reader>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }

    public void AddReader(Reader reader)
    {
        Readers.Add(reader);
    }

    public void BorrowBook(Reader reader, Book book)
    {
        Console.WriteLine("--------------------");
        if (Books.Contains(book))
        {
            reader.BorrowBook(book);
            Books.Remove(book);
            Console.WriteLine($"Czytelnik {reader.FName} {reader.SName} wypożyczył książkę");
            book.Describe();
        }
        else
        {
            Console.WriteLine($"Książka {book.Title} nie znajduje się w bibliotece");
        }
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Dostępne książki:");
        Console.WriteLine("--------------------");
        foreach (Book book in Books)
        {
            book.Describe();
            Console.WriteLine("--------------------");
        }
    }

    public void DisplayBookAuthors()
    {
        Console.WriteLine("Autorzy książek w bibliotece:");
        foreach (Author author in Authors)
        {
            Console.WriteLine($"{author.FName} {author.SName}");
        }
    }

    public void DisplayBorrowedBooks()
    {
        foreach (Reader reader in Readers)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Książki wypożyczone przez {reader.FName} {reader.SName}:");
            foreach (Book book in reader.GetBorrowedBooks())
            {
                book.Describe();
                Console.WriteLine("------------");
            }
        }
    }
}