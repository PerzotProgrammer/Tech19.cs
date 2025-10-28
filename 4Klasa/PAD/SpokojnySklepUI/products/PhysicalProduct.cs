namespace SpokojnySklepUI.products;

public class PhysicalProduct : Product
{
    public PhysicalProduct(int price, string name) : base(price, name)
    {
    }

    public override bool TrySend()
    {
        throw new NotImplementedException();
    }
}