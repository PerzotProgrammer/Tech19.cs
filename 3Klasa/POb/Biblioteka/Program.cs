using Biblioteka.Classes;

namespace Biblioteka;

class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("Adam", "Mickiewicz");
        Book book1 = new Book("Pan Tadeusz", author, 1830);
        Book book2 = new Book("Dziady", author, 1840);

        author.AddBook(book1);
        author.AddBook(book2);

        Reader reader = new Reader("Pani", "Kasia");

        reader.BorrowBook(book1);


        foreach (string title in author.GetBooksTitles())
        {
            Console.WriteLine(title);
        }

        foreach (string title in reader.GetBorrowedBooksTitles())
        {
            Console.WriteLine(title);
        }
    }
}