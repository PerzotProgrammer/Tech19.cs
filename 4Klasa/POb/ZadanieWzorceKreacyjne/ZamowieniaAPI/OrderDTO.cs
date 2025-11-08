namespace ZamowieniaAPI;

public class OrderDTO
{
    public int? Id { get; init; }
    public ICollection<BurgerDTO> Burgers { get; init; }
    public ICollection<FriesDTO> Fries { get; init; }
    public ICollection<DrinkDTO> Drinks { get; init; }
}

public class DrinkDTO
{
    public int? Id { get; init; }
    public int OrderId { get; init; }
    public string DrinkType { get; init; }
    public string Size { get; init; }
}

public class FriesDTO
{
    public int? Id { get; init; }
    public int OrderId { get; init; }
    public string FriesType { get; init; }
    public string Size { get; init; }
}

public class BurgerDTO
{
    public int? Id { get; init; }
    public int OrderId { get; init; }
    public string Bun { get; init; }
    public string MainBurgerIngredient { get; init; }
    public ICollection<string> Optionals { get; init; }
}