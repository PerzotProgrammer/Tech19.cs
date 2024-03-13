namespace Fasady.Classes;

public class Product
{
    private int Id;
    private string Name;

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetName()
    {
        return Name;
    }
}