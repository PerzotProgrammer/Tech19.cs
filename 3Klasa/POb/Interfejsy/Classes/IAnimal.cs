namespace Interfejsy.Classes;

public interface IAnimal
{
    AnimalTypeEnum TypeEnum { get; set; }
    string Name { get; set; }
    ColorEnum Color { get; set; }
    int Age { get; set; }

    void Eat();
    void MakeSound();
    void Sleep();
    void Move();
}