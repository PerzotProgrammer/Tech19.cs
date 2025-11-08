using ZamowieniaRestauracja.Builders;
using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Factory;

[Serializable]
public class Order
{
    public List<Burger> Burgers { get; private set; }
    public List<Fries> Fries { get; private set; }
    public List<Drink> Drinks { get; private set; }

    public Order()
    {
        Burgers = new List<Burger>();
        Fries = new List<Fries>();
        Drinks = new List<Drink>();
    }

    public void Request(OrderRequest orderRequest)
    {
        switch (orderRequest)
        {
            case OrderRequest.Burger:
                BurgerFactory();
                break;
            case OrderRequest.Fries:
                FriesFactory();
                break;
            case OrderRequest.Drink:
                DrinkFactory();
                break;
        }
    }

    private void BurgerFactory()
    {
        Console.WriteLine("Select bun type");
        // Plain,
        // Sesame,
        // Brioche,
        // Potato,
        Console.WriteLine("1. Plain");
        Console.WriteLine("2. Sesame");
        Console.WriteLine("3. Brioche");
        Console.WriteLine("4. Potato");

        BunType bun;

        while (!Enum.TryParse(Console.ReadLine(), out bun))
        {
        }

        Console.WriteLine("Select Main Ingredient");
        // Beef,
        // Chicken,
        // Lamb,
        // Veggie,
        Console.WriteLine("1. Beef");
        Console.WriteLine("2. Chicken");
        Console.WriteLine("3. Lamb");
        Console.WriteLine("4. Veggie");

        MainBurgerIngredientType mainBurgerIngredientType;

        while (!Enum.TryParse(Console.ReadLine(), out mainBurgerIngredientType))
        {
        }

        bool addMore = true;
        List<string> optionals = new List<string>();

        do
        {
            Console.WriteLine("Add additional item");
            // Tomato,
            // Onion,
            // Ketchup,
            // Mustard,
            // Cucumber,
            // Jalapeno

            Console.WriteLine("1. Tomato");
            Console.WriteLine("2. Onion");
            Console.WriteLine("3. Ketchup");
            Console.WriteLine("4. Mustard");
            Console.WriteLine("5. Cucumber");
            Console.WriteLine("6. Jalapeno");

            Optional optional;

            while (!Enum.TryParse(Console.ReadLine(), out optional))
            {
            }

            optionals.Add(optional.ToString());

            Console.WriteLine("Do you want add more?");
            Console.WriteLine("(C to cancel)");

            if (Console.ReadLine()?.ToLower() == "c")
            {
                addMore = false;
            }
        } while (addMore);


        Burger burger = new Burger()
            .SetBun(bun)
            .SetMainBurgerIngredient(mainBurgerIngredientType)
            .AddOptionals(optionals);

        Burgers.Add(burger);

        Console.WriteLine("New burger added!");
    }

    private void FriesFactory()
    {
        Console.WriteLine("Select fries type");
        Console.WriteLine("1. Potato");
        Console.WriteLine("2. SweetPotato");

        FriesType friesType;
        while (!Enum.TryParse(Console.ReadLine(), out friesType))
        {
        }

        Console.WriteLine("Select size");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Big");

        Size size;
        while (!Enum.TryParse(Console.ReadLine(), out size))
        {
        }

        Fries fries = new Fries()
            .SetFriesType(friesType)
            .SetSize(size);

        Fries.Add(fries);
        Console.WriteLine("New fries added!");
    }

    private void DrinkFactory()
    {
        Console.WriteLine("Select drink type");
        Console.WriteLine("1. Coke");
        Console.WriteLine("2. Orangeade");
        Console.WriteLine("3. Lemonade");
        Console.WriteLine("4. Beer");
        Console.WriteLine("5. Wine");

        DrinkType drinkType;
        while (!Enum.TryParse(Console.ReadLine(), out drinkType))
        {
        }

        Console.WriteLine("Select size");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Big");

        Size size;
        while (!Enum.TryParse(Console.ReadLine(), out size))
        {
        }

        Drink drink = new Drink()
            .SetDrinkType(drinkType)
            .SetDrinkSize(size);

        Drinks.Add(drink);
        Console.WriteLine("New drink added!");
    }
}