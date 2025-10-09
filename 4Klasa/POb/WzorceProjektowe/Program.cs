namespace WzorceProjektowe;

class Program
{
    static void Main(string[] args)
    {
        GameSession gs1 = GameSession.GetInstance();
        GameSession gs2 = GameSession.GetInstance();

        gs1.GetAllData();

        gs2.ApplyDamage(25);
        gs2.AddPoints(50);
        gs2.ReduceTimer(25);

        gs1.GetAllData();
    }
}