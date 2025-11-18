using System.Net;
using ZamowieniaRestauracja.Factory;
using ZamowieniaRestauracja.Http;
using ZamowieniaRestauracja.Singleton;
using System.Linq;
using ZamowieniaRestauracja.Builders;

namespace ZamowieniaRestauracja;

class Program
{
    static void Main(string[] args)
    {
        RunAsync().GetAwaiter().GetResult();
    }

    static async Task RunAsync()
    {
        OrderManager orderManager = OrderManager.GetInstance();

        bool running = true;

        Console.WriteLine("Welcome to order managment program!");
        do
        {
            Console.WriteLine("What you want to do:");
            Console.WriteLine("1. Place new order");
            Console.WriteLine("2. Read orders from database");
            Console.WriteLine("3. Quit");

            int opt;

            while (!int.TryParse(Console.ReadLine(), out opt) && opt is > 0 and < 4)
            {
            }

            switch (opt)
            {
                case 1:
                    Order order = orderManager.CreateNewOrder();
                    Console.WriteLine("Do you want to send this order?");
                    Console.WriteLine("(C to cancel)");

                    if (Console.ReadLine()?.ToLower() != "c")
                    {
                        HttpStatusCode status = await OrderHttpClient.GetInstance().PostOrderAsync(order);
                        Console.WriteLine(status == HttpStatusCode.OK
                            ? "ORDER SENT TO THE DATABASE!!!"
                            : "SOMETHING WENT WRONG!!!");
                    }

                    break;
                case 2:
                    List<Order>? orders = await OrderHttpClient.GetInstance().GetAllOrdersAsync();

                    if (orders != null)
                    {
                        foreach (Order ord in orders)
                        {
                            Console.WriteLine("ORDER");
                            foreach (Burger burger in ord.Burgers) burger.Describe();
                            foreach (Fries fries in ord.Fries) fries.Describe();
                            foreach (Drink drink in ord.Drinks) drink.Describe();
                        }
                    }

                    break;
                case 3:
                    running = false;
                    break;
                case 4:
                    Console.WriteLine("DEBUG");
                    Console.WriteLine("-------------");
                    Console.WriteLine(orderManager.SerializeOrders());
                    Console.WriteLine("-------------");
                    break;
            }
        } while (running);
    }
}