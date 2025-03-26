namespace Dlugomierz;

public interface IAdapter
{
    string ValidateData(string labelData);
    int GetDebtValue();
}