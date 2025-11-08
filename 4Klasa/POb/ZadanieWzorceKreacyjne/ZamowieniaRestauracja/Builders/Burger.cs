using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

[Serializable]
public class Burger
{
    public BunType Bun { get; private set; } = BunType.Undefined;
    public MainBurgerIngredientType MainBurgerIngredient { get; private set; } = MainBurgerIngredientType.Undefined;
    public List<Optional> Optionals { get; private set; } = new();


    public Burger SetBun(BunType bunType)
    {
        Bun = bunType;
        return this;
    }

    public Burger SetMainBurgerIngredient(MainBurgerIngredientType mainBurgerIngredientType)
    {
        MainBurgerIngredient = mainBurgerIngredientType;
        return this;
    }

    public Burger AddOptionals(IEnumerable<Optional> optionals)
    {
        Optionals.AddRange(optionals);
        return this;
    }

    public Burger Reset()
    {
        Bun = BunType.Undefined;
        MainBurgerIngredient = MainBurgerIngredientType.Undefined;
        Optionals = new List<Optional>();
        return this;
    }

    public void Describe()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("BURGER");
        Console.WriteLine($"Bun: {Bun.ToString()}");
        Console.WriteLine($"Main Burger Ingredient: {MainBurgerIngredient.ToString()}");
        Console.WriteLine("Optionals:");
        foreach (Optional optional in Optionals)
        {
            Console.WriteLine($" - {optional.ToString()}");
        }

        Console.WriteLine("------------------");
    }
}