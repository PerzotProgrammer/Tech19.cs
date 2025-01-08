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
        CalcBrain.AddToStack("1+1");

        string output = CalcBrain.GetExpressionAsString();
        string expected = "1+1";

        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void CalcBrain_Evaluate_ShouldBeEqual()
    {
        CalcBrain.AddToStack("1+1");

        double output = CalcBrain.EvaluateExpression();
        double expected = 2;

        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void CalcBrain_DeleteAndEvaluate_ShouldBeEqual()
    {
        CalcBrain.AddToStack("1+1");
        CalcBrain.RemoveLastCharacterFromStack();
        CalcBrain.RemoveLastCharacterFromStack();

        double output = CalcBrain.EvaluateExpression();
        double expected = 1;

        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void CalcBrain_CheckIfSingleton()
    {
        CalcBrain calcBrain2 = CalcBrain.GetInstance();
        Assert.That(calcBrain2, Is.EqualTo(CalcBrain));
    }
}