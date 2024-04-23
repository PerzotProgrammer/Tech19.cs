using SprintUML.Composite;
using SprintUML.Facade;

namespace SprintUML;

class Program
{
    static void Main()
    {
        Composite();
        Facade();
    }

    static void Composite()
    {
        CompoundGraphic compoundGraphic = new();
        Circle circle1 = new(100, 100, 50);
        Circle circle2 = new(350, 50, 70);

        Dot dot1 = new(75, 60);
        Dot dot2 = new(60, 80);

        compoundGraphic.Add(dot1);
        compoundGraphic.Add(circle1);
        compoundGraphic.Add(dot2);
        compoundGraphic.Add(circle2);

        compoundGraphic.Draw();
        Console.WriteLine();

        compoundGraphic.Move(100, 50);
        compoundGraphic.Draw();
        Console.WriteLine();
    }

    static void Facade()
    {
        MediaPlayer mediaPlayer = new();
        HomeTheater homeTheater = new(mediaPlayer);

        homeTheater.WatchMovie();
        Console.WriteLine();
        homeTheater.EndMovie();
    }
}