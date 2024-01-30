namespace PierwszaAplikacjaObiektowa.Classes;

class Teacher : Person
{
    private List<string> Subjects = new();
    
    public void AddSubjects(string subject)
    {
        Subjects.Add(subject);
    }

    public void PrintSubjects()
    {
        foreach (string subject in Subjects) Console.Write($"{subject}, ");
        Console.WriteLine();
    }
}