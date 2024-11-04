using Biblioteka.Classes;

namespace Biblioteka;

class Program
{
    static void Main(string[] args)
    {
        Author author1 = new Author("Adam", "Mickiewicz");
        Book book1 = new Book("Pan Tadeusz", author1, 1830, 29.99f);
        Book book2 = new Book("Dziady", author1, 1840, 25.99f);

        Author author2 = new Author("Henryk", "Sienkiewicz");
        Book book3 = new Book("Potop", author2, 1886, 59.99f);
        Book book4 = new Book("Quo Vadis", author2, 1896, 29.99f);

        Author author3 = new Author("Juliusz", "Słowacki");
        Book book5 = new Book("Balladyna", author3, 1839, 19.99f); // Nie dodany do biblioteki


        author1.AddBook(book1);
        author1.AddBook(book2);

        author2.AddBook(book3);
        author2.AddBook(book4);

        Library library = new Library();

        library.AddAuthor(author1);
        library.AddAuthor(author2);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        Reader reader1 = new Reader("Jan", "Kowalski");
        Reader reader2 = new Reader("Anna", "Nowak");
        
        library.AddReader(reader1);
        library.AddReader(reader2);
        
        library.BorrowBook(reader1, book2);
        library.BorrowBook(reader2, book3);
        library.BorrowBook(reader2, book5);
        library.BorrowBook(reader1, book4);
        library.DisplayBorrowedBooks();
        
        library.DisplayBookAuthors();


        library.DisplayAvailableBooks();
        library.OrderBooksBy(SortType.Price, true);
        library.DisplayAvailableBooks();
    }
}