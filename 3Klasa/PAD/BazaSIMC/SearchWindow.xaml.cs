using System.Windows;
using Microsoft.Data.Sqlite;

namespace BazaSIMC;

public partial class SearchWindow : Window
{
    private SimcDataWindow MainWindow;
    private SqliteConnection Connection;

    public SearchWindow(SimcDataWindow mainWindow, SqliteConnection connection)
    {
        MainWindow = mainWindow;
        Connection = connection;
        InitializeComponent();
    }

    private void SearchButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (SearchBox.Text == "")
        {
            MessageBox.Show("Wpisz wartość do wyszukania", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (RadioName.IsChecked == true)
        {
            SearchByName();
        }
        else if (RadioSimc.IsChecked == true)
        {
            SearchBySimc();
        }
        else if (RadioProvince.IsChecked == true)
        {
            SearchByProvince();
        }
        else if (RadioDistrict.IsChecked == true)
        {
            SearchByDistrict();
        }
        else if (RadioCommune.IsChecked == true)
        {
            SearchByCommune();
        }
        else
        {
            MessageBox.Show("Wybierz kryterium wyszukiwania", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void SearchByName()
    {
        string name = SearchBox.Text;
        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE nazwa LIKE '{name}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }

    private void SearchBySimc()
    {
        string simc = SearchBox.Text;
        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE sym LIKE '{simc}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }

    private void SearchByProvince()
    {
        string province = SearchBox.Text;

        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = $"SELECT woj FROM Terc WHERE nazwa LIKE '{province}' AND pow is null AND gmi is null";
        string provinceRaw = command.ExecuteScalar()?.ToString()?.ToUpper() ?? "";

        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE woj LIKE '{provinceRaw}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }

    private void SearchByDistrict()
    {
        string district = SearchBox.Text;

        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = $"SELECT pow FROM Terc WHERE nazwa LIKE '{district}'  AND gmi is null";
        string districtRaw = command.ExecuteScalar()?.ToString()?.ToUpper() ?? "";

        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE pow LIKE '{districtRaw}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }

    private void SearchByCommune()
    {
        string commune = SearchBox.Text;

        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = $"SELECT gmi FROM Terc WHERE nazwa LIKE '{commune}'";
        string communeRaw = command.ExecuteScalar()?.ToString()?.ToUpper() ?? "";

        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE gmi LIKE '{communeRaw}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }
}