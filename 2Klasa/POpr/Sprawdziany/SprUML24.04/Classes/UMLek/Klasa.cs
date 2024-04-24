namespace SprUML24._04.Classes.UMLek;

public class Klasa
{
    public string numerKlasy { get; set; }
    protected List<IRobotny> ListaRobotnych = new();

    public void DodajDoListy(IRobotny robotny)
    {
        Console.WriteLine("Dodałem do listy!");
        ListaRobotnych.Add(robotny);
    }
}