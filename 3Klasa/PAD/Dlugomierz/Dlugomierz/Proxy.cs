using System.Text;

namespace Dlugomierz;

public class Proxy
{
    private IAdapter Adapter;

    public Proxy()
    {
        Adapter = new DebtDataAdapter(1_000_000);
    }

    public string TryCalculate(string labelData)
    {
        try
        {
            if (Adapter.GetDebtValue() <= 0)
            {
                return "Dług spłacony";
            }
            Adapter.CheckPayment(labelData);
            return $"Zapłacono: {labelData} zł";
        }
        catch (Exception)
        {
            return "Błędne dane";
        }


    }

    public int GetDebtValue()
    {
        return Adapter.GetDebtValue();
    }
}