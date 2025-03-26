namespace Dlugomierz;

public interface IAdapter
{
    void CheckPayment(string labelData);
    int GetDebtValue();
}