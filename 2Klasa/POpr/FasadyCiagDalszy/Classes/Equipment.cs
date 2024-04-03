namespace FasadyCiagDalszy.Classes;

public class Equipment
{
    private string Name;

    public Equipment(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}