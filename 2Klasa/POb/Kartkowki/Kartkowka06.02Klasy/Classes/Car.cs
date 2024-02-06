namespace PerzBartosz.Classes;

public enum Color
{
    Black,
    White,
    Red,
    Blue,
    Green,
}

public class Car
{
    private string Brand { get; set; }
    private string Model { get; set; }
    private Color Color { get; set; }
    private ushort Year { get; set; }
    private float Price { get; set; }
    private Person Owner { get; set; }

    public string GetInfo()
    {
        string ret = $"Marka: {Brand}, Model: {Model}, Kolor: {Color}, Rok: {Year}, Cena: {Price} PLN\nOWNER ";
        ret += Owner.GetInfo();
        return ret;
    }

    public void SetInfo(string brand, string model, Color color, ushort year, float price, Person owner)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        Price = price;
        Owner = owner;
    }
}