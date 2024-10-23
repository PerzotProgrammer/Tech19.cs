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

namespace Banknoter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(Input.Text, out int amountOfMoney))
        {
            Console.WriteLine(Input.Text);
            MessageBox.Show("Podaj liczbę całkowitą", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        Dictionary<int, int> dict = CalculateNominalsDict(amountOfMoney);
        Output.Text =
            $"500: {dict[500]}\n200: {dict[200]}\n" +
            $"100: {dict[100]}\n50: {dict[50]}\n20: {dict[20]}\n" +
            $"10: {dict[10]}\n5: {dict[5]}\n2: {dict[2]}\n1: {dict[1]}";
    }

    private Dictionary<int, int> CalculateNominalsDict(int amount)
    {
        Dictionary<int, int> nominalsDict = new Dictionary<int, int>
        {
            { 500, 0 },
            { 200, 0 },
            { 100, 0 },
            { 50, 0 },
            { 20, 0 },
            { 10, 0 },
            { 5, 0 },
            { 2, 0 },
            { 1, 0 }
        };


        foreach (KeyValuePair<int, int> pair in nominalsDict)
        {
            if (amount == 0) break;
            if (amount < pair.Key) continue;
            int div = amount / pair.Key;
            nominalsDict[pair.Key] = div;
            amount -= pair.Key * div;
        }

        return nominalsDict;
    }
}