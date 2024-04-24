namespace SprUML24._04.Classes.UMLek;

public class Leszcz : IRobotny
{
    public string Robota { get; set; }
    private string Imie;
    private string Odmiana;

    public Leszcz(string imie, string odmiana)
    {
        Imie = imie;
        Odmiana = odmiana;
    }

    protected void WymyslajWymowki()
    {
        Console.WriteLine("Wymyślam wymówki");
    }

    private void Czekaj()
    {
        Console.WriteLine("No czekam");
    }

    public void Udawaj()
    {
        Console.WriteLine($"Leszcz {Imie} {Odmiana} coś udaje");
    }

    public void Planuj()
    {
        Console.WriteLine($"Leszcz {Imie} {Odmiana} planuje");
    }

    public void Dzialaj(Zadanie zadanie)
    {
        Console.WriteLine($"Leszcz {Imie} {Odmiana} wykonuje zadanie {zadanie.DajNazwe()}");
    }
}