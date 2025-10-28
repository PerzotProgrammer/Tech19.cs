using SpokojnySklepUI.products;

namespace SpokojnySklepUI.discounts;

public class PercentageDiscount : IDiscountStrategy
{
    private int _discount;

    public PercentageDiscount(int discount)
    {
        _discount = discount;
    }


    public int ApplyDiscount(List<Product> products)
    {
        double discountSum = 0;

        foreach (Product product in products)
        {
            double currentDiscount = (product.GetPrice() - (product.GetPrice() * ((double)_discount / 100)));
            discountSum += currentDiscount;
            product.SetPrice((int)currentDiscount);
        }

        return (int)discountSum;
    }
}