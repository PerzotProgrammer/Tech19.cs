using Dziedziczenie.Classes;

namespace Dziedziczenie;

class Program
{
    static void Main()
    {
        Car car = new("UAZ", "469", 7, 15f);
        car.Move();

        Plane plane = new("Boeing", "747", 460, 15f);
        plane.Move();
        plane.Refuel(100f);
        plane.Move();

        car.Move();
    }
}