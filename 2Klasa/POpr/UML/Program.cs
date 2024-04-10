using UML.Classes;
using Directory = UML.Classes.Directory;
using File = UML.Classes.File;

namespace UML;

class Program
{
    static void Main()
    {
        Zad1();
        Zad2();
        Zad3();
        Zad4();
    }

    static void Zad1()
    {
        // Kompozyt
        Directory dir1 = new("Zdjęcia",
        [
            new File("Pamiątka z wakacji", "png"), new File("Ślub", "jpeg"), new File("Basen", "gif"),
            new File("Koncert", "mp4")
        ]);
        Directory dir2 = new("Homework",
        [
            new File("Wypracowanie", "docx"), new File("Wiersz o SiPlasPlasie", "txt"),
            new File("Litwo ojczyzno moja", "odt")
        ]);
        Directory dir3 = new("Dokumenty", [dir1, dir2, new File("Wyciągi z konta", "xlsx")]);
        dir3.Show();
    }

    static void Zad2()
    {
        // Fasada
        WashingMachine washingMachine = new(new(), new(), new());
        washingMachine.StartWashing();
    }

    static void Zad3()
    {
        // Fasada + Kompozyt
        CarFactory carFactory = new(new(), new(), new());
        carFactory.BuildAll();
    }

    static void Zad4()
    {
        // Szablon
        Car car = new("Polonez");
        Plane plane = new("747");
        car.StartMoving();
        plane.StartMoving();
    }
}