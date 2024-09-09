namespace DziedziczeniePowtorka.Classes;

public abstract class Shape
{
    protected int NumberOfAngles;

    protected int GetNumberOfAngles()
    {
        return NumberOfAngles;
    }
    public abstract float CalculateArea();
    public abstract float CalculatePerimeter();
    public abstract void Describe();
}