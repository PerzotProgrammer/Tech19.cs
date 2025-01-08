using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KalkulatoroweTesty;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private CalcBrain CalcBrain;
    private Regex DigitsAndOperRegex;

    public MainWindow()
    {
        CalcBrain = CalcBrain.GetInstance();
        DigitsAndOperRegex = new Regex(@"[^0-9/:\.\+\-\*\/\\E\(\)]+");
        InitializeComponent();
    }

    private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        DisplayBlock.Text = TextBox.Text;
    }

    private void DigitOrOperatorCheck_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = DigitsAndOperRegex.IsMatch(e.Text);
    }

    private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == string.Empty) return;
        CalcBrain.AddToStack(DisplayBlock.Text);
        try
        {
            DisplayBlock.Text = CalcBrain.EvaluateExpression().ToString(CultureInfo.InvariantCulture);
        }
        catch (SyntaxErrorException)
        {
            MessageBox.Show("Błąd składniowy w wyrażeniu", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        CalcBrain.ClearStack();
        TextBox.Text = DisplayBlock.Text;
    }
}