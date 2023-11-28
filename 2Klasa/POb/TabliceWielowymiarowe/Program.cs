namespace TabliceWielowymiarowe;

class Program
{
    static void Main()
    {
        DwaWymiary(5);
        TrzyWymiary(2);
    }

    static void DwaWymiary(int lengthOfArray)
    {
        int[,] Matrix = new int[lengthOfArray, lengthOfArray];
        Console.WriteLine($"Ilość wymiarów: {Matrix.Rank}");

        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                Console.Write($"{Matrix[i, j]}, ");
            }

            Console.WriteLine();
        }
    }

    static void TrzyWymiary(int lengthOfArray)
    {
        int[,,] Matrix3dim = new int[lengthOfArray, lengthOfArray, lengthOfArray];
        Console.WriteLine($"Ilość wymiarów: {Matrix3dim.Rank}");

        for (int i = 0; i < Matrix3dim.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix3dim.GetLength(1); j++)
            {
                for (int k = 0; k < Matrix3dim.GetLength(2); k++)
                {
                    Console.Write($"{Matrix3dim[i, j, k]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}