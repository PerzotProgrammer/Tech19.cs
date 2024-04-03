namespace FasadyCiagDalszy.Classes;

public class Building
{
    private string Adress;
    private string PhoneNumber;
    private int RentRate;

    public Building(string adress, string phoneNumber, int rentRate)
    {
        Adress = adress;
        PhoneNumber = phoneNumber;
        RentRate = rentRate;
    }

    public string GetInfo()
    {
        return $"BuildingData:\nAdress: {Adress}\nPhoneNumber: {PhoneNumber}\nRentRate: {RentRate}";
    }
}