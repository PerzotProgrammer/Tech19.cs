namespace WzorceProjektowe;

public class GameSession
{
    private static GameSession? _instance;
    public double Timer { get; private set; }
    public double PlayerHp { get; private set; }
    public int Points { get; private set; }

    private GameSession()
    {
        Timer = 100.0d;
        PlayerHp = 100.0d;
        Points = 0;
        Console.WriteLine("GAME SESSION CREATED!!!");
    }

    public static GameSession GetInstance()
    {
        _instance ??= new GameSession();
        Console.WriteLine("GOT GAME SESSION");
        return _instance;
    }

    public void GetAllData()
    {
        Console.WriteLine($"Session data: Timer {Timer}, PlayerHp {PlayerHp}, Points {Points}");
    }

    public void AddPoints(int points)
    {
        Points += points;
    }

    public void ApplyDamage(double damage)
    {
        PlayerHp -= damage;
    }

    public void ReduceTimer(double time)
    {
        Timer -= time;
    }
}