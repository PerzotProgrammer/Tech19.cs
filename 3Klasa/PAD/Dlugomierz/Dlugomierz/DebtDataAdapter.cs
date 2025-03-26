namespace Dlugomierz;

public class DebtDataAdapter : IAdapter
{
    public int DataLimit { get; private set; }

    public DebtDataAdapter(int dataLimit)
    {
        DataLimit = dataLimit;
    }

    public string ValidateData(string labelData)
    {
        IDao dao = new DebtData(labelData);
        if (DataLimit >= dao.LabelDataToInt())
        {
            throw new ArgumentException();
        }

        return dao.LabelData;
    }

    public int GetDebtValue()
    {
        return 1_000_000;
    }
}