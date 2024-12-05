using System.Windows;
using Microsoft.Data.Sqlite;

namespace BazaSIMC;

public partial class SearchByDistrict : Window
{
    private SimcSearchWindow MainWindow;
    private SqliteConnection Connection;

    public SearchByDistrict(SimcSearchWindow mainWindow, SqliteConnection connection)
    {
        MainWindow = mainWindow;
        Connection = connection;
        InitializeComponent();
    }

    private void SearchButton_OnClick(object sender, RoutedEventArgs e)
    {
        string district = SearchBox.Text;
        
        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = $"SELECT woj FROM Terc WHERE nazwa LIKE '{district}' AND pow is null AND gmi is null";
        string districtRaw = command.ExecuteScalar()?.ToString()?.ToUpper() ?? "";
        
        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE woj LIKE '{districtRaw}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }
}