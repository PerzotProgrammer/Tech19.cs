namespace Biblioteka.Classes;

public class Reader : Person
{
    private List<Book> BorrowedBooks;

    public Reader(string fName, string sName) : base(fName, sName)
    {
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
    }

    public List<Book> GetBorrowedBooks()
    {
        return BorrowedBooks;
    }
}