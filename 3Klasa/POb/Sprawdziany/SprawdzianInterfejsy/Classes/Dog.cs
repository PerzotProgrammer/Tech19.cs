namespace SprawdzianInterfejsy.Classes;

public class Dog : Animal
{
    public Dog(string name, string species, int age, string owner) : base(name, species, age, owner)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hau!");
    }
}