namespace Delegaty.Classes;

public interface INotifier
{
    void Send(string message, string recipient);
}