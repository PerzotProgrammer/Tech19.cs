using Samochody.Classes;

namespace Samochody;

class Program
{
    static void Main()
    {
        Car[] cars =
        {
            new(),
            new("Lada", "Niva", 1994),
            new("Toyota", "Supra", 2000, 3.0),
            new("Fiat", "126p", 1985, 0.75, false),
            new("UAZ", "452", 1980, 2.4, false, new(2015, 3, 19), CarStatus.Antique)
        };

        foreach (Car car in cars) car.GetInfo();
    }
}