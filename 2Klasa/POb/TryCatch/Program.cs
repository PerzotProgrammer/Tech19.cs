namespace TryCatch;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Podaj dwie liczby:");
            Console.Write("Liczba a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Liczba b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int wynik = a / b;
            Console.WriteLine($"Wynik: {a} / {b} = {wynik:F4}");
        }
        catch (DivideByZeroException)
        {
            ErrorMessage("Nie można dzielić przez 0!");
        }
        catch (FormatException)
        {
            ErrorMessage("Nie można przekonwertować na liczbę!");
        }
        catch (OverflowException)
        {
            ErrorMessage($"Liczba jest za duża!\nDostępny zakres: {int.MinValue} - {int.MaxValue}");
        }
        catch (Exception e)
        {
            ErrorMessage($"Wystąpił inny niezdefiniowany błąd.\n{e.Message}");
        }
    }
    
    static void ErrorMessage(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Błąd: {errorMessage}");
        Console.ResetColor();
    }
}