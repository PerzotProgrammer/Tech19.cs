namespace ZamowieniaAPI;

[Serializable]
public class Order
{
    public int? Id { get; set; }
    public ICollection<Burger> Burgers { get; set; } = new List<Burger>();
    public ICollection<Fries> Fries { get; set; } = new List<Fries>();
    public ICollection<Drink> Drinks { get; set; } = new List<Drink>();
}

[Serializable]
public class Drink
{
    public int? Id { get; set; }
    public string DrinkType { get; set; }
    public string Size { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
}

[Serializable]
public class Fries
{
    public int? Id { get; set; }
    public string FriesType { get; set; }
    public string Size { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
}

[Serializable]
public class Burger
{
    public int? Id { get; set; }
    public string Bun { get; set; }
    public string MainBurgerIngredient { get; set; }
    public ICollection<string> Optionals { get; set; } = new List<string>();
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
}