using ZamowieniaRestauracja.Enums;

namespace ZamowieniaRestauracja.Builders;

public class Burger
{
    public string Bun { get; set; } = "";
    public string MainBurgerIngredient { get; set; } = "";
    public List<string> Optionals { get; set; } = new();


    public Burger SetBun(BunType bunType)
    {
        Bun = bunType.ToString();
        return this;
    }

    public Burger SetMainBurgerIngredient(MainBurgerIngredientType mainBurgerIngredientType)
    {
        MainBurgerIngredient = mainBurgerIngredientType.ToString();
        return this;
    }

    public Burger AddOptionals(IEnumerable<string> optionals)
    {
        Optionals.AddRange(optionals);
        return this;
    }

    public void Describe()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("BURGER");
        Console.WriteLine($"Bun: {Bun}");
        Console.WriteLine($"Main Burger Ingredient: {MainBurgerIngredient}");
        Console.WriteLine("Optionals:");
        foreach (string optional in Optionals)
        {
            Console.WriteLine($" - {optional}");
        }

        Console.WriteLine("------------------");
    }
}