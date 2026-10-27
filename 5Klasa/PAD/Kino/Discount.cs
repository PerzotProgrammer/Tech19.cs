namespace Kino;

public static class Discount
{
    public enum Type
    {
        None,
        Medium,
        Big
    }

    public static double GetMultiplier(this Type type) => type switch
    {
        Type.None => 1.0,
        Type.Medium => 0.9,
        Type.Big => 0.8,
        _ => throw new ArgumentOutOfRangeException(nameof(type))
    };
}