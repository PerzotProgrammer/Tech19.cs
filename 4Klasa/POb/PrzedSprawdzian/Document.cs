namespace PrzedSprawdzian;

public class Document
{
    private string _title;

    protected Document(string title)
    {
        _title = title;
    }

    protected string getTitle()
    {
        return _title;
    }
}