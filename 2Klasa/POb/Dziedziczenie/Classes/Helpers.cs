namespace Dziedziczenie.Classes;

public enum FuelType
{
    Unknown,
    Petrol,
    Diesel,
    Electrical,
    Hybrid,
    JetFuel
}

public static class FuelingAnimator
{
    public static void Animate(float fuelAmount, FuelType fuelType, int delay)
    {
        string unit = "unknown";
        if (fuelType == FuelType.Petrol || fuelType == FuelType.Diesel || fuelType == FuelType.JetFuel ||
            fuelType == FuelType.Hybrid) unit = "dm^3";

        if (fuelType == FuelType.Electrical) unit = "kWh";

        Console.Write($"Tankowanie (20{unit}/s): 0{unit} [");
        for (int i = 0; i < Math.Floor(fuelAmount) / 2; i++)
        {
            if (i < Math.Floor(fuelAmount) / 6) ColorWrite("-", ConsoleColor.Red);
            else if (i < Math.Floor(fuelAmount) / 3) ColorWrite("-", ConsoleColor.Yellow);
            else ColorWrite("-", ConsoleColor.Green);
            Thread.Sleep(delay);
        }

        Console.WriteLine($"] {fuelAmount}{unit}");
        Console.WriteLine($"KONIEC! zatankowano {fuelAmount} {unit} {fuelType.ToString()}!");
    }

    private static void ColorWrite(string message, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.Write(message);
        Console.ResetColor();
    }
}