namespace SpokojnySklepUI.products;

public abstract class Product
{
    protected int _price;
    protected string _name;

    protected Product(int price, string name)
    {
        _price = price;
        _name = name;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetPrice(int newPrice)
    {
        _price = newPrice;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract bool TrySend();
}