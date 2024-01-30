namespace Parking;

public class Parking(string Name, int Space)
{
    private Car[] Cars = new Car[Space];

    public void AddCar(Car car, int index)
    {
        if (index >= Space || index < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid place!");
            Console.ResetColor();
            return;
        }
        
        if (Cars[index] == null)
        {
            Cars[index] = car;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done!");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Place is already taken!");
        Console.ResetColor();
    }

    public string GetName()
    {
        return Name;
    }
    public void RemoveCar(int index)
    {
        if (index >= Space || index < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid place!");
            Console.ResetColor();
            return;
        }
        
        if (Cars[index] != null)
        {
            Cars[index] = null!;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done!");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Place is already empty!");
        Console.ResetColor();
    }

    public void ShowCars()
    {
        for (int i = 0; i < Space; i++)
        {
            if (Cars[i] != null)
            {
                Console.Write($"Place {i}: ");
                Cars[i].ShowInformation();
            }
            else
            {
                Console.WriteLine($"Place {i}: Empty");
            }
                
        }
    }
}