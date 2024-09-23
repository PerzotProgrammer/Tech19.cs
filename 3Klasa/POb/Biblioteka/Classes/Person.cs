namespace Biblioteka.Classes;

public abstract class Person
{
    public string FName { get; private set; }
    public string SName { get; private set; }

    protected Person(string fName, string sName)
    {
        FName = fName;
        SName = sName;
    }
}