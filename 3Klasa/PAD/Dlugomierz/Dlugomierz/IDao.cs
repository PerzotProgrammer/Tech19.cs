namespace Dlugomierz;

public interface IDao
{
    public int DebtValue { get; protected set; }
    public void CalculateNewDebtValue(int payment);
}