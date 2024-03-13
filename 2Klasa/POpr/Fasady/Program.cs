using Fasady.Classes;

namespace Fasady;

class Program
{
    static void Main()
    {
        Customer customer = new("Adam", "Kowalski", 45);
        Product product = new(1212, "Gacie");
        Order order = new(124, "Nowakowa 12/4");
        Delivery delivery = new();
        
        delivery.SetCustomer(customer);
        delivery.SetProduct(product);
        delivery.SetOrder(order);
        
        delivery.PrintInfo();
    }
}