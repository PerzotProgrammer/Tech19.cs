using Dziedziczenie.Classes;

namespace Dziedziczenie;

class Program
{
    static void Main()
    {
        Car car = new("UAZ", "469", 7);
        car.Move();
        car.Refuel(FuelType.Electrical, 10f);
        car.Refuel(FuelType.Petrol, 20f);
        car.Move();
        Console.WriteLine();

        Plane plane = new("Boeing", "747", 460);
        plane.Move();
        plane.Refuel(FuelType.JetFuel, 100f);
        plane.Move();
        Console.WriteLine();

        Boat boat = new("British Navy", "HMS Prince Of Wales", 3000);
        boat.Refuel(FuelType.Diesel, 200f);
        boat.Move();
        Console.WriteLine();

        Tank tank = new("USSR", "T34", 4, 10);
        tank.Refuel(FuelType.Diesel, 100f);
        tank.Move();
        tank.Shoot();
        Console.WriteLine();
    }
}