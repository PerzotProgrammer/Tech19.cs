namespace Dlugomierz;

public class DebtDataAdapter : IAdapter
{
    public int DataLimit { get; private set; }

    private IDao Dao;

    public DebtDataAdapter(int dataLimit, int initialDebt = 1_000_000)
    {
        DataLimit = dataLimit;
        Dao = new DebtData(initialDebt);
    }

    public void CheckPayment(string labelData)
    {
        if (!int.TryParse(labelData.Replace("_",""), out int data))
        {
            throw new ArgumentException();
        }

        if (data < 0 || data > DataLimit)
        {
            throw new ArgumentOutOfRangeException();
        }

        Dao.CalculateNewDebtValue(data);
    }

    public int GetDebtValue()
    {
        return Dao.DebtValue;
    }
}