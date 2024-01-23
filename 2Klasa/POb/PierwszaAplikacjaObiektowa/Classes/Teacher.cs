namespace PierwszaAplikacjaObiektowa.Classes;

public class Teacher
{
    private List<string> Subjects = new();

    public void AddSubjects(string subject)
    {
        Subjects.Add(subject);
    }

    public void PrintSubjects()
    {
        foreach (string subject in Subjects) Console.Write($"{subject}, ");
    }
}