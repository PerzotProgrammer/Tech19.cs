namespace Fasady.Classes;

public class Delivery
{
    private Customer Customer;
    private Order Order;
    private Product Product;
    
    public void SetCustomer(Customer customer)
    {
        Customer = customer;
    }

    public void SetOrder(Order order)
    {
        Order = order;
    }

    public void SetProduct(Product product)
    {
        Product = product;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Product: {Product.GetName()}");
        Console.WriteLine($"OrderId: {Order.GetId()}");
        Console.WriteLine($"OrderAdress: {Order.GetAdress()} street");
        Console.WriteLine($"Customer: {Customer.GetName()} {Customer.GetSName()}");
    }
}