namespace Dlugomierz;

public interface IDao
{
    string LabelData { get; protected set; }
    int LabelDataToInt();
}