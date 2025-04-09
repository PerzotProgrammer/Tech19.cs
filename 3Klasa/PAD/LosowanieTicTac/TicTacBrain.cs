namespace LosowanieTicTac;

public class TicTacBrain
{
    private bool[,]? Board;
    private static TicTacBrain? Instance;
    private Random Rand;

    private TicTacBrain()
    {
        Rand = new Random();
    }

    public static TicTacBrain GetInstance()
    {
        return Instance ??= new TicTacBrain();
    }

    private void RollBoard()
    {
        Board = new bool[3, 3];
        int remaining = 5;

        while (remaining > 0)
        {
            int randX = Rand.Next(0, 3);
            int randY = Rand.Next(0, 3);
            if (Board[randX, randY]) continue;
            remaining -= 1;
            Board[randX, randY] = true;
        }
    }

    public string[,] GetNewBoard()
    {
        string[,] boardStr = new string[3, 3];

        RollBoard();

        for (int i = 0; i < Board.GetLength(0); i++)
        {
            for (int j = 0; j < Board.GetLength(1); j++)
            {
                if (Board[i, j]) boardStr[i, j] = "X";
                else boardStr[i, j] = "O";
            }
        }

        return boardStr;
    }
}