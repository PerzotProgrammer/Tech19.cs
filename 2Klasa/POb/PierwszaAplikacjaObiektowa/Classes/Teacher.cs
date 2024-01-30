namespace PierwszaAplikacjaObiektowa.Classes;

class Teacher : Person
{
    private List<string> Subjects = new();

    public Premissions Premissions = Premissions.teacher;

    public void AddSubjects(string subject)
    {
        Subjects.Add(subject);
    }

    public void PrintSubjects()
    {
        Console.WriteLine("Subjects:");
        foreach (string subject in Subjects) Console.Write($"{subject}, ");
        Console.WriteLine();
    }
    
    public string GetPremsType()
    {
        return $"Premissions: {Premissions.ToString()}";
    }
}