namespace PrzedSprawdzian;

public class Report : Document, IPrintable
{
    public Report(string title) : base(title)
    {
    }

    public Report(Report report) : base($"{report.getTitle()} copy")
    {
    }

    public void Print()
    {
        Console.WriteLine($"Printing report {getTitle()}");
    }
}