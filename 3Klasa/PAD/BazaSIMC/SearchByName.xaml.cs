using System.Windows;

namespace BazaSIMC;

public partial class SearchByName : Window
{
    private SimcSearchWindow MainWindow;

    public SearchByName(SimcSearchWindow mainWindow)
    {
        MainWindow = mainWindow;
        InitializeComponent();
    }

    private void SearchButton_OnClick(object sender, RoutedEventArgs e)
    {
        string name = SearchBox.Text;
        string sqlQuery = $"SELECT nazwa, sym, woj, pow, gmi FROM Simc WHERE nazwa LIKE '{name}'";
        MainWindow.QueryToDataGrid(sqlQuery);
        Close();
    }
}