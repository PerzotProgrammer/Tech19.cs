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
using Microsoft.Data.Sqlite;

namespace BazaDanych;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ReadData();
    }

    private void ReadData()
    {
        using SqliteConnection connection = new SqliteConnection("Data Source=database.db");

        connection.Open();
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Osoby";
        SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            TextBlock tb = new TextBlock();
            tb.Text += $"ID: {reader.GetInt32(0)}\t Imie: {reader.GetString(1)}\t Nazwisko: {reader.GetString(2)}\n";
            tb.Padding = new Thickness(10);
            tb.Margin = new Thickness(10);
            tb.Background = Brushes.Gray;
            Panel.Children.Add(tb);
        }


        connection.Close();
    }
}