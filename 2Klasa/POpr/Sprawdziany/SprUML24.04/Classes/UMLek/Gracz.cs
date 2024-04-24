namespace SprUML24._04.Classes.UMLek;

public class Gracz : IRobotny
{
    public string Robota { get; set; }
    private string Imie;
    private int Poziom;

    public Gracz(string imie, int poziom)
    {
        Imie = imie;
        Poziom = poziom;
    }

    protected void IdeGrac()
    {
        Console.WriteLine($"Gracz {Imie} o poziomie {Poziom} idzie grać");
    }

    private void Jem()
    {
        Console.WriteLine("No jem");
    }

    private bool Wydalam()
    {
        Console.WriteLine("Ale mi się kupę zachciało");
        return true;
    }

    protected char ZnowIdeGrac()
    {
        Console.WriteLine("To se idź");
        return 'a';
    }

    public void Planuj()
    {
        Console.WriteLine($"Gracz {Imie} o poziomie {Poziom} planuje coś");
    }

    public void Dzialaj(Zadanie zadanie)
    {
        Console.WriteLine($"Gracz {Imie} o poziomie {Poziom} robi zadanie {zadanie.DajNazwe()}");
    }
}