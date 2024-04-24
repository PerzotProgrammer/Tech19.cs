namespace SprUML24._04.Classes.UMLek;

public interface IRobotny
{
    string Robota { get; set; }
    void Planuj();
    void Dzialaj(Zadanie zadanie);
}

public class Zadanie
{
    private string NazwaZadania;

    public Zadanie(string nazwaZadania)
    {
        NazwaZadania = nazwaZadania;
    }

    public string DajNazwe()
    {
        return NazwaZadania;
    }
}

public class Narzedzie
{
    private string NazwaNarzedzia;

    public Narzedzie(string nazwaNarzedzia)
    {
        NazwaNarzedzia = nazwaNarzedzia;
    }

    public string DajNazwe()
    {
        return NazwaNarzedzia;
    }
}