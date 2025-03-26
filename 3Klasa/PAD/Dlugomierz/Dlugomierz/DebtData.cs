namespace Dlugomierz;

public class DebtData : IDao
{
    public string LabelData { get; set; }

    public DebtData(string labelData)
    {
        LabelData = labelData;
    }

    public int LabelDataToInt()
    {
        return int.Parse(LabelData);
    }
}