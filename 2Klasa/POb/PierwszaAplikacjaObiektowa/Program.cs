using PierwszaAplikacjaObiektowa.Classes;

namespace PierwszaAplikacjaObiektowa;

class Program
{
    static void Main()
    {
        Student student1 = new() { StudentID = 15, Class = "1a" };
        Console.WriteLine(student1.StudentID);
        student1.SetFirstName("Adam");
        student1.SetLastName("Kowalski");
        student1.Adress.SetAdress("Kowalska", "Poznan");
        Console.WriteLine(student1.GetData());
        Console.WriteLine(student1.Adress.GetAdress());
        
        Teacher teacher1 = new();
        teacher1.SetFirstName("Bartosz");
        teacher1.SetLastName("Nowak");
        teacher1.Adress.SetAdress("Nowakowa", "Poznan");
        Console.WriteLine(teacher1.GetData());
        Console.WriteLine(teacher1.Adress.GetAdress());
        teacher1.AddSubjects("Mat");
        teacher1.AddSubjects("Inf");
        teacher1.AddSubjects("Geo");
        teacher1.PrintSubjects();
        DateTime dateTime = DateTime.Now;

        Console.WriteLine($"Raport wygenerowano o:");
        // Console.WriteLine(dateTime.ToLongDateString());
        Console.WriteLine(dateTime.ToShortDateString());
        Console.WriteLine(dateTime.ToLongTimeString());
        // Console.WriteLine(dateTime.ToShortTimeString());
    }
}