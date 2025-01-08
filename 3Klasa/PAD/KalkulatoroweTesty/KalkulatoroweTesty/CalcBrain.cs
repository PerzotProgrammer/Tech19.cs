using System.Data;
using System.Text;

namespace KalkulatoroweTesty;

public class CalcBrain
{
    private static CalcBrain? Instance;
    private List<char> ExprBuilder;

    private CalcBrain()
    {
        ExprBuilder = new List<char>();
    }

    public static CalcBrain GetInstance()
    {
        if (Instance == null) Instance = new CalcBrain();

        return Instance;
    }

    public void AddToStack(char character)
    {
        ExprBuilder.Add(character);
    }

    public void RemoveLastCharacterFromStack()
    {
        ExprBuilder.RemoveAt(ExprBuilder.Count - 1);
    }

    public void ClearStack()
    {
        ExprBuilder.Clear();
    }

    public string GetExpressionAsString()
    {
        return new string(ExprBuilder.ToArray());
    }

    public double EvaluateExpression()
    {
        DataTable table = new DataTable();
        return Convert.ToDouble(table.Compute(GetExpressionAsString(), String.Empty));
    }
}