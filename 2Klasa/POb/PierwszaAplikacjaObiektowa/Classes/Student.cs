namespace PierwszaAplikacjaObiektowa.Classes;

class Student : Person
{
    public int StudentID { get; set; }
    public string? Class { get; set; }

    public Premissions Premissions = Premissions.student;
    
    public string GetClassInfo()
    {
        return $"StudentID: {StudentID}\nClass: {Class}";
    }

    public string GetPremsType()
    {
        return $"Premissions: {Premissions.ToString()}";
    }
}