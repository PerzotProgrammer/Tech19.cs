namespace ListaLudowa;

public class Person
{
    public string Name { get; private set; }
    public string Gender { get; private set; }
    public string About { get; private set; }

    public Person(string name, string gender, string about)
    {
        Name = name;
        Gender = gender;
        About = about;
    }
}