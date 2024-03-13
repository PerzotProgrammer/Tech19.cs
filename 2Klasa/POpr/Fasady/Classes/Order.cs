namespace Fasady.Classes;

public class Order
{
    private int Id;
    private string Adress;

    public Order(int id, string adress)
    {
        Id = id;
        Adress = adress;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetAdress()
    {
        return Adress;
    }
}