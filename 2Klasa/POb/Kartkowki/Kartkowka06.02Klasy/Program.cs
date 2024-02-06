// Hasło pdf: t19!@3

using PerzBartosz.Classes;

namespace PerzBartosz;

class Program
{
    static void Main()
    {
        Person person = new Person();
        Car car = new Car();
        person.SetInfo("Adam", "Nowak", new DateTime(1979, 4, 12), ["Bartek", "Ania", "Krzysztof"]);

        car.SetInfo("UAZ", "469b", Color.Green, 1981, 4999, person);

        Console.WriteLine(car.GetInfo());
        Console.WriteLine();
        Console.WriteLine(person.GetChilds());
    }
}