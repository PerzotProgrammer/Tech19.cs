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

namespace Dlugomierz;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Proxy Proxy;

    public MainWindow()
    {
        Proxy = new Proxy();
        InitializeComponent();
    }

    private void DebtButton_OnClick(object sender, RoutedEventArgs e)
    {
        string output = Proxy.TryCalculate(DebtTextBox.Text);
        SetRemainingDebt();
        DebtOutputBlock.Text = output;
    }

    private void SetRemainingDebt()
    {
        DebtValueTextBlock.Text = $"{Proxy.GetDebtValue()} zł";
    }

    private void Window_OnLoaded(object sender, RoutedEventArgs e)
    {
        SetRemainingDebt();
    }
}