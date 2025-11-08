using System.Text.Json;
using ZamowieniaRestauracja.Builders;
using ZamowieniaRestauracja.Enums;
using ZamowieniaRestauracja.Factory;

namespace ZamowieniaRestauracja.Singleton;

public class OrderManager
{
    private static OrderManager? Instance;

    private List<Order> Orders;

    private OrderManager()
    {
        Orders = new List<Order>();
    }

    public static OrderManager GetInstance()
    {
        Instance ??= new OrderManager();

        return Instance;
    }

    public void CreateNewOrder()
    {
        Order order = new Order();
        bool addMore = true;
        do
        {
            Console.WriteLine("Select item to add");
            Console.WriteLine("1. Burger");
            Console.WriteLine("2. Fries");
            Console.WriteLine("3. Drink");
            Console.WriteLine("4. Confirm order");

            OrderRequest orderRequest;
            while (!Enum.TryParse(Console.ReadLine(), out orderRequest))
            {
            }

            if (orderRequest == OrderRequest.ExitRequest)
                addMore = false;
            else
                order.Request(orderRequest);
        } while (addMore);

        Orders.Add(order);

        Console.WriteLine("Order summary:");
        foreach (Burger burger in order.Burgers)
        {
            burger.Describe();
        }
        
        foreach (Fries fires in order.Fries)
        {
            fires.Describe();
        }
        
        foreach (Drink drink in order.Drinks)
        {
            drink.Describe();
        }

        Console.WriteLine("Order saved!");
    }

    public string SerializeOrders()
    {
        return JsonSerializer.Serialize(Orders);
    }
}