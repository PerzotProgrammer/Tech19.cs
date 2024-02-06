namespace PerzBartosz.Classes;

public class Person
{
    private string FName { get; set; }
    private string SName { get; set; }
    private DateTime BirthDay = new DateTime();
    private List<string> ChildNames = new List<string>();

    public void SetInfo(string fName, string sName, DateTime bDay, List<string> cNames)
    {
        FName = fName;
        SName = sName;
        BirthDay = bDay;
        ChildNames = cNames;
    }

    public string GetInfo()
    {
        return $"FirstName: {FName}, SecondName: {SName}, BirthDay: {BirthDay.ToShortDateString()}";
    }

    public string GetChilds()
    {
        string stack = "Childs: ";
        foreach (string childName in ChildNames)
        {
            stack += $"{childName}, ";
        }

        return stack;
    }
}