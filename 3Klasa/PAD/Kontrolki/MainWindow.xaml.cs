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

namespace Kontrolki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Hello_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"Hello {FName.Text} {SName.Text}!");
    }

    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Wyjście", MessageBoxButton.YesNo,
            MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes) Close();
    }

    private void GoTo2_OnClick(object sender, RoutedEventArgs e)
    {
        UserData userData = new UserData();
        userData.Show();
    }

    private void GoTo3_OnClick(object sender, RoutedEventArgs e)
    {
    }
}