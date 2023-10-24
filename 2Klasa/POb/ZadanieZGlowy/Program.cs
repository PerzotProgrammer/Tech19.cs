using System.Text;

namespace ZadanieZGlowy;

class Program
{
    static void Main()
    {
        PoleProstokata();
    }

    // Napisz program, który obliczy pole prostokąta
    static void PoleProstokata()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("OBLICZANIE POLA PROSTOKĄTA");
            Console.Write("Podaj x: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Podaj y: ");
            float y = Convert.ToSingle(Console.ReadLine());
            float pole = x * y;
            Console.WriteLine($"Twoje pole wynosi: {pole:F4} j\u00b2");
            // Console.WriteLine($"{float.MinValue} - {float.MaxValue}");
        }
        catch (FormatException)
        {
            ErrorMessage("nie można przekonwertować litery i/lub znaku na liczbę!");
        }
        catch (OverflowException)
        {
            ErrorMessage($"liczba poza zakresem!\nDozwolony zakres (float): {float.MinValue} - {float.MaxValue}");
        }
        catch (Exception e)
        {
            ErrorMessage($"wystąpił inny, nieoczekiwany błąd:\n{e.Message}");
        }
    }

    static void ErrorMessage(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Błąd: {errorMessage}");
        Console.ResetColor();
    }
}