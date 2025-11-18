using Newtonsoft.Json;

namespace ZamowieniaAPI;

public class Order
{
    [JsonIgnore] public int? Id { get; set; }
    public ICollection<Burger> Burgers { get; set; } = new List<Burger>();
    public ICollection<Fries> Fries { get; set; } = new List<Fries>();
    public ICollection<Drink> Drinks { get; set; } = new List<Drink>();
}

public class Drink
{
    [JsonIgnore] public int? Id { get; set; }
    public string DrinkType { get; set; }
    public string Size { get; set; }

    [JsonIgnore] public int? OrderId { get; set; }
    [JsonIgnore] public Order? Order { get; set; }
}

public class Fries
{
    [JsonIgnore] public int? Id { get; set; }
    public string FriesType { get; set; }
    public string Size { get; set; }
    [JsonIgnore] public int? OrderId { get; set; }
    [JsonIgnore] public Order? Order { get; set; }
}

public class Burger
{
    [JsonIgnore] public int? Id { get; set; }
    public string Bun { get; set; }
    public string MainBurgerIngredient { get; set; }
    public ICollection<string> Optionals { get; set; } = new List<string>();

    [JsonIgnore] public int? OrderId { get; set; }
    [JsonIgnore] public Order? Order { get; set; }
}