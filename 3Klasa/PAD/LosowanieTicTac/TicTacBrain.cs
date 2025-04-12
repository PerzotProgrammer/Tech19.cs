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

        for (int i = 0; i < Board!.GetLength(0); i++)
        {
            for (int j = 0; j < Board.GetLength(1); j++)
            {
                if (Board[i, j]) boardStr[i, j] = "X";
                else boardStr[i, j] = "O";
            }
        }

        return boardStr;
    }

    public char GetWinner()
    {
        for (int i = 0; i < Board!.GetLength(0); i++)
        {
            if (Board[i, 0] && Board[i, 1] && Board[i, 2]) return 'X';
            if (!Board[i, 0] && !Board[i, 1] && !Board[i, 2]) return 'O';
        }

        for (int i = 0; i < Board.GetLength(1); i++)
        {
            if (Board[0, i] && Board[1, i] && Board[2, i]) return 'X';
            if (!Board[0, i] && !Board[1, i] && !Board[2, i]) return 'O';
        }

        if (Board[0, 0] && Board[1, 1] && Board[2, 2]) return 'X';
        if (Board[0, 2] && Board[1, 1] && Board[2, 0]) return 'X';
        if (!Board[0, 0] && !Board[1, 1] && !Board[2, 2]) return 'O';
        if (!Board[0, 2] && !Board[1, 1] && !Board[2, 0]) return 'O';

        return 'N';
    }
}