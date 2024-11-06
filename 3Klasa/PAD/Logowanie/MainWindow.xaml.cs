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

namespace Logowanie;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Dictionary<string, string> Users;

    public MainWindow()
    {
        InitializeComponent();
        Users = new Dictionary<string, string>();
    }

    private void Register_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Passwd.Password) ||
            string.IsNullOrEmpty(PasswdRepeat.Password))
        {
            MessageBox.Show("Wszystkie pola muszą być wypełnione", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!Regex.IsMatch(Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            MessageBox.Show("Niepoprawny adres email", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (Passwd.Password != PasswdRepeat.Password)
        {
            MessageBox.Show("Hasła nie są takie same", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (Users.ContainsKey(Email.Text))
        {
            MessageBox.Show("Użytkownik o podanym adresie email już istnieje", "Błąd", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        Users.Add(Email.Text, Passwd.Password);
        MessageBox.Show("Rejestracja zakończona pomyślnie", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Login_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Passwd.Password))
        {
            MessageBox.Show("Wszystkie pola muszą być wypełnione", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!Users.TryGetValue(Email.Text, out string? user))
        {
            MessageBox.Show("Użytkownik o podanym adresie email nie istnieje", "Błąd", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        if (user != Passwd.Password)
        {
            MessageBox.Show("Niepoprawne hasło", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        MessageBox.Show("Logowanie zakończone pomyślnie", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}