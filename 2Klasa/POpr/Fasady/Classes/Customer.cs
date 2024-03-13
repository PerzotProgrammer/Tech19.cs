namespace Fasady.Classes;

public class Customer
{
    private string Name;
    private string SName;
    private int Age;

    public Customer(string name, string sName, int age)
    {
        Name = name;
        SName = sName;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {GetName()}");
        Console.WriteLine($"SName: {GetSName()}");
        Console.WriteLine($"Age: {GetAge()}");
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public string GetSName()
    {
        return SName;
    }

    public int GetAge()
    {
        return Age;
    }
}