namespace UML.Classes;

public class WashingMachine
{
    private Washing Washing;
    private Rinsing Rinsing;
    private Spinning Spinning;

    public WashingMachine(Washing washing, Rinsing rinsing, Spinning spinning)
    {
        Washing = washing;
        Rinsing = rinsing;
        Spinning = spinning;
    }

    public void StartWashing()
    {
        Washing.Wash();
        Rinsing.Rinse();
        Spinning.Spin();
        Console.WriteLine("Done!");
        TakeOnMe();
    }

    public void TakeOnMe()
    {
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(293, 250);
        Console.Beep(246, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(415, 250);
        Console.Beep(415, 250);
        Console.Beep(440, 250);
        Console.Beep(493, 250);
        Console.Beep(440, 250);
        Console.Beep(440, 250);
        Console.Beep(440, 250);
        Console.Beep(329, 250);
        Console.Beep(293, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(369, 250);
        Console.Beep(329, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(293, 250);
        Console.Beep(246, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(415, 250);
        Console.Beep(415, 250);
        Console.Beep(440, 250);
        Console.Beep(493, 250);
        Console.Beep(440, 250);
        Console.Beep(440, 250);
        Console.Beep(440, 250);
        Console.Beep(329, 250);
        Console.Beep(293, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(369, 250);
        Console.Beep(329, 250);
        Console.Beep(329, 250);
        Console.Beep(369, 250);
        Console.Beep(329, 250);
    }
}

public class Washing
{
    public void Wash()
    {
        Console.WriteLine("Im washing!");
        Thread.Sleep(2000);
    }
}

public class Rinsing
{
    public void Rinse()
    {
        Console.WriteLine("Im rinsing!");
        Thread.Sleep(2000);
    }
}

public class Spinning
{
    public void Spin()
    {
        Console.WriteLine("Im spinning!");
        Thread.Sleep(2000);
    }
}