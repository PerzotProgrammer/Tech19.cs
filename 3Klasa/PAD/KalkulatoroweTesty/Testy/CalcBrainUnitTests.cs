using KalkulatoroweTesty;

namespace Testy;

public class CalcBrainUnitTests
{
    private readonly CalcBrain CalcBrain = CalcBrain.GetInstance();

    [SetUp]
    public void ClearStack()
    {
        CalcBrain.ClearStack();
    }

    [Test]
    public void CalcBrain_GetExpr_ShouldBeEqual()
    {
        CalcBrain.AddToStack('1');
        CalcBrain.AddToStack('+');
        CalcBrain.AddToStack('1');

        string expr = CalcBrain.GetExpressionAsString();

        Assert.That(expr, Is.EqualTo("1+1"));
    }

    [Test]
    public void CalcBrain_Evaluate_ShouldBeEqual()
    {
        CalcBrain.AddToStack('1');
        CalcBrain.AddToStack('+');
        CalcBrain.AddToStack('1');

        double output = CalcBrain.EvaluateExpression();

        Assert.That(output, Is.EqualTo(2));
    }
}