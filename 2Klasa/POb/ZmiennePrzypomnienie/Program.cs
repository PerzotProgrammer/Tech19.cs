namespace Program
{
    class MainProcess
    {
        static void Main()
        {

            ZmienneMaxMin();

            // Console.WriteLine(Int128.MaxValue); // Int128 nie istnieje w .NET 8

            Console.WriteLine("\u2665 \u2666"); // unikody

            char znak = (char)97; // Rzutowanie zmiennej
            Console.WriteLine(znak);

            PiR2Unicode();

        }

        static void PiR2Unicode()
        {
            Console.WriteLine("\u03C0r\u00b2");
        }

        static void ZmienneMaxMin()
        {
            short minshort = short.MinValue;
            short maxshort = short.MaxValue;

            ushort minushort = ushort.MinValue;
            ushort maxushort = ushort.MaxValue;

            int minint = int.MinValue;
            int maxint = int.MaxValue;

            uint minuint = uint.MinValue;
            uint maxuint = uint.MaxValue;

            long minlong = long.MinValue;
            long maxlong = long.MaxValue;

            ulong minulong = ulong.MinValue;
            ulong maxulong = ulong.MaxValue;

            Console.WriteLine($"ulong: {minulong} - {maxulong}");
            Console.WriteLine($"long: {minlong} - {maxlong}");
            Console.WriteLine($"uint: {minuint} - {maxuint}");
            Console.WriteLine($"int: {minint} - {maxint}");
            Console.WriteLine($"ushort: {minushort} - {maxushort}");
            Console.WriteLine($"short: {minshort} - {maxshort}");
        }
    }
}