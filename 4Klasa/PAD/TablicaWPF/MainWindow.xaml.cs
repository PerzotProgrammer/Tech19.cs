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

namespace TablicaWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int _baseFontSize;
    private int _fontSizeChange;

    public MainWindow()
    {
        _baseFontSize = 20;
        _fontSizeChange = 4;
        InitializeComponent();
        TextBox.FontSize = _baseFontSize;
    }

    private void FontUp_OnClick(object sender, RoutedEventArgs e)
    {
        if (_baseFontSize + _fontSizeChange > 70) return;
        _baseFontSize += _fontSizeChange;
        TextBox.FontSize = _baseFontSize;
    }

    private void FontDown_OnClick(object sender, RoutedEventArgs e)
    {
        if (_baseFontSize - _fontSizeChange <= 0) return;
        _baseFontSize -= _fontSizeChange;
        TextBox.FontSize = _baseFontSize;
    }

    private void OpenCalculator_OnClick(object sender, RoutedEventArgs e)
    {
        new Calculator().Show();
    }
}