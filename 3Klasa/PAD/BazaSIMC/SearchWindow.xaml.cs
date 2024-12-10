using System.Text;
using System.Windows;
using Microsoft.Data.Sqlite;

namespace BazaSIMC;

public partial class SearchWindow : Window
{
    private SimcDataWindow MainWindow;

    public SearchWindow(SimcDataWindow mainWindow)
    {
        MainWindow = mainWindow;
        InitializeComponent();
    }

    private void SearchButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (SearchBox.Text == "")
        {
            MessageBox.Show("Wpisz wartość do wyszukania", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        StringBuilder sqlQuery = new StringBuilder("SELECT * FROM SimcWithTerc");
        string searchBoxText = SearchBox.Text;

        if (RadioName.IsChecked == true)
        {
            sqlQuery.Append($" WHERE name LIKE '{searchBoxText}'");
        }
        else if (RadioSimc.IsChecked == true)
        {
            sqlQuery.Append($" WHERE simc_code LIKE '{searchBoxText}'");
        }
        else if (RadioProvince.IsChecked == true)
        {
            sqlQuery.Append($" WHERE province LIKE '{searchBoxText}'");
        }
        else if (RadioDistrict.IsChecked == true)
        {
            sqlQuery.Append($" WHERE district LIKE '{searchBoxText}'");
        }
        else if (RadioCommune.IsChecked == true)
        {
            sqlQuery.Append($" WHERE commune LIKE '{searchBoxText}'");
        }
        else
        {
            MessageBox.Show("Wybierz kryterium wyszukiwania", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        MainWindow.QueryToDataGrid(sqlQuery.ToString());
        Close();
    }
}