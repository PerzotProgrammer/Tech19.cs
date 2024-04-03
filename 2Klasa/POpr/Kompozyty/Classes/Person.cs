namespace Kompozyty.Classes;

public abstract class Person
{
    private string Fname;
    private string Sname;
    private string Position;

    protected Person(string fname, string sname, string position)
    {
        Fname = fname;
        Sname = sname;
        Position = position;
    }

    public string GetInfo()
    {
        return $"Fname: {Fname}\nSname: {Sname}\nPosition: {Position}";
    }
}

public class Chief : Person
{
    private List<Person> Persons;

    public Chief(string fname, string sname, string position) : base(fname, sname, position)
    {
        Persons = new();
    }

    public void AddPersons(params Person[] persons)
    {
        foreach (Person person in persons) Persons.Add(person);
    }
}

public class Worker : Person
{
    public Worker(string fname, string sname, string position) : base(fname, sname, position)
    {
    }
}