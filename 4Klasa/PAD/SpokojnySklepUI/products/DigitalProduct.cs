namespace SpokojnySklepUI.products;

public class DigitalProduct : Product
{
    public DigitalProduct(int price, string name) : base(price, name)
    {
    }

    public override bool TrySend()
    {
        throw new NotImplementedException();
    }
}