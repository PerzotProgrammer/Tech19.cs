namespace Dlugomierz;

public class DebtData : IDao
{
    public int DebtValue { get; set; }

    public DebtData(int debtValue)
    {
        DebtValue = debtValue;
    }

    public void CalculateNewDebtValue(int payment)
    {
        DebtValue -= payment;
        if (DebtValue < 0) DebtValue = 0;
    }
}