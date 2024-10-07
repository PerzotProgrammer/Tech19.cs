namespace Biblioteka.Classes;

public class Author : Person
{
    private List<Book> BookList;

    public Author(string fName, string sName) : base(fName, sName)
    {
        BookList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BookList.Add(book);
    }

    public List<Book> GetBooks()
    {
        return BookList;
    }
}