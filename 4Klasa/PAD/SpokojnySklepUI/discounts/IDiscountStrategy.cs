using SpokojnySklepUI.products;

namespace SpokojnySklepUI.discounts;

public interface IDiscountStrategy {
    int ApplyDiscount(List<Product> products);
}
