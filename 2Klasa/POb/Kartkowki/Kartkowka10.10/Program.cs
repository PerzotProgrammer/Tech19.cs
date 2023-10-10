using System.Text;
namespace Program;

class Program 
{
    static void Main()
    {
        // wypisz uśmiech i serduszko
        // System.Console.OutputEncoding = System.Text.Encoding.Unicode; // nie potrzeba tego w linuksie
        System.Console.WriteLine("😎❤️");
        System.Console.ReadLine();

        // byte zakres 0-255 zajmuje 8 bitów czyli 1 bajt
        // sbyte zakres -128-127 zajmuje 8 bitów czyli 1 bajt

        // short (Int16)  -32768 - 32767 zajmuje 16 bitów czyli 2 bajty
        // ushort (UInt16) 0 - 65535 zajmuje 16 bitów czyli 2 bajty

        // int (Int32)  -2147483648 - 2147483647 zajmuje 32 bity czyli 4 bajty
        // uint (UInt32)  0 - 4294967295 zajmuje 32 bity czyli 4 bajty

        // long (Int64) -9223372036854775808 - 9223372036854775807 zajmuje 64 bity czyli 8 bajty
        // ulong (UInt64) 0 - 18446744073709551615 zajmuje 64 bity czyli 8 bajty

        double pi = Math.PI;
        double r = 1D;
        System.Console.WriteLine(2 * pi * r);

    }
}
