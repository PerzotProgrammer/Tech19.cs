namespace PierwszaAplikacjaObiektowa.Classes;

class Person
{
    private string? FirstName { get; set; }
    private string? LastName { get; set; }

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
        return $"FirstName: {FirstName}\nLastName: {LastName}";
    }
}