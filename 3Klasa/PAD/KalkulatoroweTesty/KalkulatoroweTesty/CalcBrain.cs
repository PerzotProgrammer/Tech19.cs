using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace KalkulatoroweTesty;

public class CalcBrain
{
    private static CalcBrain? Instance;
    private StringBuilder ExprBuilder;

    private CalcBrain()
    {
        ExprBuilder = new StringBuilder();
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static CalcBrain GetInstance()
    {
        return Instance ??= new CalcBrain();
    }

    public void AddToStack(string chars)
    {
        ExprBuilder.Append(chars);
    }

    public void RemoveLastCharacterFromStack()
    {
        ExprBuilder.Remove(ExprBuilder.Length - 1, 1);
    }

    public void ClearStack()
    {
        ExprBuilder.Clear();
    }

    public string GetExpressionAsString()
    {
        return ExprBuilder.ToString();
    }

    public double EvaluateExpression()
    {
        // Trzeba tu dodać ONP
        DataTable table = new DataTable();
        return Convert.ToDouble(table.Compute(GetExpressionAsString(), string.Empty));
    }
}