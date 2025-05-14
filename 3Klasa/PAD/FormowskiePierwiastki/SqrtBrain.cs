namespace FormowskiePierwiastki;

public class SqrtBrain
{
    private static SqrtBrain? Instance;


    private SqrtBrain()
    {
    }

    public static SqrtBrain GetInstance()
    {
        return Instance ??= new SqrtBrain();
    }

    public double CalculateSqrtMathLib(double number)
    {
        return Math.Sqrt(number);
    }

    public double CalculateSqrtAlgo(double number, int iterations)
    {
        if (number < 0)
        {
            throw new ArgumentException("Liczba musi być nieujemna.");
        }

        double approximation = number / 2.0;
        for (int i = 0; i < iterations; i++)
        {
            approximation = (approximation + number / approximation) / 2.0;
        }

        return approximation;
    }
}