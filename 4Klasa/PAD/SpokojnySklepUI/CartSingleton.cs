using SpokojnySklepUI.products;

namespace SpokojnySklepUI;

public class CartSingleton
{
    private static CartSingleton? _instance;
    private List<Product> _cart;


    private CartSingleton()
    {
        _cart = new List<Product>();
    }

    public static CartSingleton GetInstance()
    {
        _instance ??= new CartSingleton();
        return _instance;
    }

    public void AddToCart(Product product)
    {
        _cart.Add(product);
    }

    public void RemoveFromCart(Product product)
    {
        _cart.Remove(product);
    }

    public Product GetElementAtIndexInCart(int index)
    {
        return _cart.ElementAt(index);
    }

    public Product GetLastElementInCart()
    {
        return _cart.Last();
    }
}