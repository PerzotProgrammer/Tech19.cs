using PierwszaAplikacjaObiektowa.Classes;

namespace PierwszaAplikacjaObiektowa;

class Program
{
    static void Main()
    {
        Person person1 = new();
        person1.SetFirstName("Bartosz");
        person1.SetLastName("Nowak");
        person1.Adress.SetAdress("Nowakowa", "Poznan");
        Console.WriteLine(person1.GetData());
        Console.WriteLine(person1.Adress.GetAdress());

        Student student1 = new() { StudentID = 15 };
        Console.WriteLine(student1.StudentID);

        Teacher teacher1 = new();
        teacher1.AddSubjects("Mat");
        teacher1.AddSubjects("Inf");
        teacher1.AddSubjects("Geo");
        teacher1.PrintSubjects();
    }
}