namespace NwdNwwHuffman;

class Program
{
    static void Main(string[] args)
    {
        string mes = "aaacccdddeeeaa";
        
        System.Console.WriteLine(NWD(12,8));
        System.Console.WriteLine(NWW(3,4));
        System.Console.WriteLine(Huffman(mes));
    }

    static int NWD(int a, int b)
    {
        while (a != b)
        {
            if (a > b) a -= b;
            else b -= a;
        }
        return a;
    }

    static int NWW(int a, int b)
    {
        return (a / NWD(a, b)) * b;
    }

    static string Huffman(string input)
    {
        string stack = "";
        int num = 1;
        char akt = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (akt != input[i])
            {
                stack += num.ToString();
                stack += akt;
                akt = input[i];
                num = 1;
            }
            else num ++;
        }
        if (akt != input[^1])
        {
            akt = input[^1];
            num = 1;
        }
        stack += num.ToString();
        stack += akt;

        return stack;
    }
}
