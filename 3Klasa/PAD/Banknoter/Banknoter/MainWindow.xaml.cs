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

        Images.Children.Clear();
        Dictionary<int, int> dict = CalculateNominalsDict(amountOfMoney);

        foreach (KeyValuePair<int, int> pair in dict)
        {
            for (int i = 0; i < pair.Value; i++)
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri($"/images/{pair.Key}.jpg", UriKind.Relative));
                img.Height = 64;
                img.Margin = new Thickness(5);
                Images.Children.Add(img);
            }
        }
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