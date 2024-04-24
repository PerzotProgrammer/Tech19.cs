namespace SprUML24._04.Classes.UMLek;

public class Rekin : IRobotny
{
    public string Robota { get; set; }
    private string Imie;
    private string Nazwisko;

    public Rekin(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }

    public void Planuj()
    {
        Console.WriteLine($"Rekin {Imie} {Nazwisko} planuje");
    }

    public void Dzialaj(Zadanie zadanie)
    {
        Console.WriteLine($"Rekin {Imie} {Nazwisko} wykonuje zadanie {zadanie.DajNazwe()}");
    }

    protected void DobierzNarzedzie(Narzedzie narzedzie)
    {
        Console.WriteLine($"Wybrałem narzędzie {narzedzie.DajNazwe()}");
    }
}