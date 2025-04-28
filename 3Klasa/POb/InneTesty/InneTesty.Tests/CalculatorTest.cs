namespace InneTesty.Tests;

public class CalculatorTest
{
    private readonly Calculator Calculator;

    public CalculatorTest()
    {
        Calculator = new Calculator();
    }

    [Fact]
    public void Add_ShouldPassWithPositiveNums()
    {
        float a = 1.5f;
        float b = 2.5f;

        float result = Calculator.Add(a, b);

        Assert.Equal(4.0f, result);
    }

    [Fact]
    public void Subtract_ShouldPassWithPositiveNums()
    {
        float a = 5.5f;
        float b = 3.5f;

        float result = Calculator.Subtract(a, b);

        Assert.Equal(2.0f, result);
    }

    [Fact]
    public void Multiply_ShouldPassWithPositiveNums()
    {
        float a = 4.5f;
        float b = 2.5f;

        float result = Calculator.Multiply(a, b);

        Assert.Equal(11.25f, result);
    }

    [Fact]
    public void Divide_ShouldPassWithPositiveNums()
    {
        float a = 8.5f;
        float b = 2.5f;

        float result = Calculator.Divide(a, b);

        Assert.Equal(3.4f, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        float a = 8.5f;
        float b = 0;

        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }

    [Fact]
    public void Add_ShouldPassWithNegativeNumbers()
    {
        float a = -1.5f;
        float b = -2.5f;

        float result = Calculator.Add(a, b);

        Assert.Equal(-4.0f, result);
    }

    [Fact]
    public void Subtract_ShouldPassWithNegativeNumbers()
    {
        float a = -5.5f;
        float b = -3.5f;

        float result = Calculator.Subtract(a, b);

        Assert.Equal(-2.0f, result);
    }

    [Fact]
    public void Multiply_ShouldPassWithNegativeNumbers()
    {
        float a = -4.5f;
        float b = -2.5f;

        float result = Calculator.Multiply(a, b);

        Assert.Equal(11.25f, result);
    }

    [Fact]
    public void Divide_ShouldPassWithNegativeNumbers()
    {
        float a = -8.5f;
        float b = -2.5f;

        float result = Calculator.Divide(a, b);

        Assert.Equal(3.4f, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowExceptionWithNegativeNumbers()
    {
        float a = -8.5f;
        float b = 0;

        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
}