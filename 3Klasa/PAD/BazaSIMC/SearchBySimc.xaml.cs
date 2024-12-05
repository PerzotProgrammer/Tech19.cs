using System.Windows;

namespace BazaSIMC;

public partial class SearchBySimc : Window
{
    private SimcSearchWindow MainWindow;

    public SearchBySimc(SimcSearchWindow mainWindow)
    {
        MainWindow = mainWindow;
        InitializeComponent();
    }

    private void SearchButton_OnClick(object sender, RoutedEventArgs e)
    {
        string simc = SearchBox.Text;
        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE sym LIKE '{simc}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }
}