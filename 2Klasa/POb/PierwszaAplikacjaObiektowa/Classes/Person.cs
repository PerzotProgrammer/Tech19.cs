namespace PierwszaAplikacjaObiektowa.Classes;

public enum Gender
{
    male,
    female
}

public enum Premissions
{
    admin,
    teacher,
    student
}

public class Person
{
    private string? FirstName { get; set; }
    private string? LastName { get; set; }

    public Gender Gender { get; set; }

    public Adress Adress = new();

    public void SetFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        LastName = lastName;
    }

    public string GetData()
    {
        return $"FirstName: {FirstName}\n" +
               $"LastName: {LastName}\n" +
               $"Gender: {Gender}\n" +
               $"Adress:\n{Adress.GetAdress()}";
    }
}