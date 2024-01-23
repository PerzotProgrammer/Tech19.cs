namespace PierwszaAplikacjaObiektowa.Classes;

public class Adress
{
    private string? Street { get; set; }
    private string? Town { get; set; }

    public void SetAdress(string street, string town)
    {
        Street = street;
        Town = town;
    }

    public string GetAdress()
    {
        return $"Street: {Street}\nTown: {Town}";
    }
}