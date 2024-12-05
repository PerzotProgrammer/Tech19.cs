namespace BazaSIMC;

public struct SimcDataStruct
{
    public string Name { get; private set; }
    public string SimcCode { get; private set; }

    public SimcDataStruct(string name, string simcCode)
    {
        Name = name;
        SimcCode = simcCode;
    }
}