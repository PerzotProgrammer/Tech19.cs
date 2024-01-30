namespace Parking;

class Program
{
    static void Main()
    {
        Car car1 = new("UAZ", "469", 1980, Color.Green);
        Car car2 = new("Fiat", "124p", 1976, Color.Red);
        Car car3 = new("FSO", "Polonez", 1984, Color.White);

        Parking parking = new("Center", 5);

        Console.WriteLine(parking.GetName());
        parking.AddCar(car1, 4);
        parking.AddCar(car2, 1);
        parking.AddCar(car3, 2);
        parking.ShowCars();
        parking.RemoveCar(1);
    }
}