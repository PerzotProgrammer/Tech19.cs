namespace KonstruktoryCiagDalszy.Classes;

public class Person
{
    public string Name;
    public string Surname;
    public int? Age;
    public float? Height;


    static Person()
    {
        Console.WriteLine("Pozdro Sherlocku z statica");
    }

    public Person()
    {
        Name = "undefined";
        Surname = "undefined";
        Age = null;
        Height = null;
    }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public Person(string name, string surname, int age) : this(name, surname)
    {
        Age = age;
    }

    public Person(string name, string surname, int age, float height) : this(name, surname, age)
    {
        Height = height;
    }

    public string GetData()
    {
        return $"{Name} {Surname} {Age} {Height}";
    }
}