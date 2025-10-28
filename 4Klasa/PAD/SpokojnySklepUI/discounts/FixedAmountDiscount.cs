using SpokojnySklepUI.products;

namespace SpokojnySklepUI.discounts;

public class FixedAmountDiscount : IDiscountStrategy
{
    private int _discount;

    public FixedAmountDiscount(int discount)
    {
        _discount = discount;
    }

    public int ApplyDiscount(List<Product> products)
    {
        double discountSum = 0;

        foreach (Product product in products)
        {
            double currentDiscount = (product.GetPrice() - _discount);
            discountSum += currentDiscount;
            product.SetPrice((int)currentDiscount);
        }

        return (int)discountSum;
    }
}