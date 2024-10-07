namespace Biblioteka.Classes;

public class Book
{
    public string Title { get; private set; }
    public Author Author { get; private set; }
    public int ReleaseYear { get; private set; }

    public Book(string title, Author author, int releaseYear)
    {
        Title = title;
        Author = author;
        ReleaseYear = releaseYear;
    }

    public void Describe()
    {
        Console.WriteLine($"Tytuł: {Title}");
        Console.WriteLine($"Autor: {Author.FName} {Author.SName}");
        Console.WriteLine($"Rok wydania: {ReleaseYear}");
    }
}