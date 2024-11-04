namespace Biblioteka.Classes;

public class Book : IComparable<Book>
{
    public string Title { get; private set; }
    public Author Author { get; private set; }
    public int ReleaseYear { get; private set; }
    public float Price { get; private set; }

    public Book(string title, Author author, int releaseYear, float price)
    {
        Title = title;
        Author = author;
        ReleaseYear = releaseYear;
        Price = price;
    }

    public void Describe()
    {
        Console.WriteLine($"Tytuł: {Title}");
        Console.WriteLine($"Autor: {Author.FName} {Author.SName}");
        Console.WriteLine($"Rok wydania: {ReleaseYear}");
        Console.WriteLine($"Cena: {Price}");
    }

    public int CompareTo(Book? other)
    {
        if (other != null) return Price.CompareTo(other.Price);
        throw new NullReferenceException();
    }

    public override string ToString()
    {
        return $"{Title}, {Author.FName} {Author.SName}, {ReleaseYear}, {Price}";
    }
}