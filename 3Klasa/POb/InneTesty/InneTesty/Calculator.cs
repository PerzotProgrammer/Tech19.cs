namespace InneTesty;

public class Calculator
{
    
    public float Add(float a, float b)
    {
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        return a * b;
    }

    public float Divide(float a, float b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }
}