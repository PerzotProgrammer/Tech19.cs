namespace SprUML24._04.Classes.UMLek;

public class Teknikum : Szkola
{
    private string Nazwa;

    public string PodajNazwe()
    {
        return Nazwa;
    }

    private protected Teknikum(string nazwa, string kraj) : base(kraj)
    {
        Nazwa = nazwa;
    }
}