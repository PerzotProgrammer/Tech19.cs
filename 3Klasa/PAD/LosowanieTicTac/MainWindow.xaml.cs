using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LosowanieTicTac;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private TicTacBrain Brain;

    public MainWindow()
    {
        Brain = TicTacBrain.GetInstance();
        InitializeComponent();
    }


    private void RollButton_OnClick(object sender, RoutedEventArgs e)
    {
        PlaceOnBoard();
        GetWinner();
    }

    private void PlaceOnBoard()
    {
        string[,] board = Brain.GetNewBoard();

        Cell00.Text = board[0, 0];
        Cell01.Text = board[0, 1];
        Cell02.Text = board[0, 2];
        Cell10.Text = board[1, 0];
        Cell11.Text = board[1, 1];
        Cell12.Text = board[1, 2];
        Cell20.Text = board[2, 0];
        Cell21.Text = board[2, 1];
        Cell22.Text = board[2, 2];
    }

    private void GetWinner()
    {
        char winner = Brain.GetWinner();
        if (winner == 'N')
        {
            WinnerTextBlock.Text = "Remis!";
            return;
        }

        WinnerTextBlock.Text = $"Wygrał {winner}!";
    }
}