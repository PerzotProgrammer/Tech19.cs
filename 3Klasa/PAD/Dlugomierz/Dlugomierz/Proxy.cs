using System.Text;

namespace Dlugomierz;

public class Proxy
{
    private IAdapter Adapter;

    public Proxy()
    {
        Adapter = new DebtDataAdapter(1_000_000);
    }

    public string Calculate(string labelValue)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Do spłacenia pozostało: ");
        try
        {
            stringBuilder.Append(Adapter.ValidateData(labelValue));
        }
        catch (Exception)
        {
            return "Błędne dane";
        }

        return stringBuilder.ToString();
    }

    public int GetDebtValue()
    {
        return Adapter.GetDebtValue();
    }
}