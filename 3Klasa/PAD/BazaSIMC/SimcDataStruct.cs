namespace BazaSIMC;

public struct SimcDataStruct
{
    public string Name { get; private set; }
    public string SimcCode { get; private set; }
    public string Province { get; private set; }
    public string District { get; private set; }
    public string Commune { get; private set; }
    public string CommuneType { get; private set; }

    public SimcDataStruct(string name, string simcCode, string province, string district, string commune, string communeType)
    {
        Name = name;
        SimcCode = simcCode;
        Province = province;
        District = district;
        Commune = commune;
        CommuneType = communeType;
    }
}