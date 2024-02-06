namespace Konstruktory.Classes;

public class Person
{
    private string FirstName;
    private string LastName;

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Console.WriteLine($"{FirstName} {LastName} się urodził");
    }

    public void SayHello()
    {
        Console.WriteLine($"Cześć, jestem {FirstName} {LastName}");
    }
}