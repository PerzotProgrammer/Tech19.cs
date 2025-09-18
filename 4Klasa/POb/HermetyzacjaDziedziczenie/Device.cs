namespace HermetyzacjaDziedziczenie;

public class Device
{
    protected Device()
    {
        Console.WriteLine($"Powstał nowy obiekt klasy {GetType().Name}");
    }
    
    protected void Report(string msg)
    {
        Console.WriteLine($"Urządzenie {GetType().Name} raportuje: {msg}");
    }

    public virtual void GetStatus()
    {
        Console.WriteLine($"Urządzenie w nieznanym stanie");
    }
}