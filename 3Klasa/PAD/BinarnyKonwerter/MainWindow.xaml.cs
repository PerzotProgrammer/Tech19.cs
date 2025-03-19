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
using StringBuilder = System.Text.StringBuilder;

namespace BinarnyKonwerter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DecToBin_OnClick(object sender, RoutedEventArgs e)
    {
        DecToBinOut.Text = DecToBin(DecToBinIn.Text);
    }

    private void BinToDec_OnClick(object sender, RoutedEventArgs e)
    {
        BinToDecOut.Text = BinToDec(BinToDecIn.Text);
    }

    private string DecToBin(string dec)
    {
        int[] valuesMask = new int[32];

        for (int i = 0; i < 32; i++)
        {
            valuesMask[i] = (int)Math.Pow(2, i);
        }

        valuesMask = valuesMask.Reverse().ToArray();

        StringBuilder values = new StringBuilder();

        int decInt = int.Parse(dec);
        foreach (int value in valuesMask)
        {
            if (decInt >= value)
            {
                values.Append(1);
                decInt -= value;
            }
            else
            {
                values.Append(0);
            }
        }

        return values.ToString().TrimStart('0');
    }

    private string BinToDec(string bin)
    {
        int dec = 0;
        List<int> binPos = BinPos(bin);

        for (int i = binPos.Count - 1; i >= 0; i--)
        {
            dec += (int)Math.Pow(2, binPos[i]);
        }

        return dec.ToString();
    }

    private List<int> BinPos(string bin)
    {
        List<int> result = new List<int>();
        char[] bins = bin.ToCharArray();

        for (int i = 0; i < bins.Length; i++)
        {
            if (bin[i] == '1')
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}