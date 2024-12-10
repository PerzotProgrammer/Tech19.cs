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

namespace BazaSIMC;

public partial class SimcDataWindow : Window
{
    private SqliteConnection Connection;
    private List<SimcDataStruct> SimcData;
    private Window? SearchWindow;

    public SimcDataWindow()
    {
        Connection = new SqliteConnection("Data Source=SimcBase.db");
        SimcData = new List<SimcDataStruct>();
        InitializeComponent();
        DataGrid.ItemsSource = SimcData;
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        Connection.Open();
        QueryToDataGrid("SELECT * FROM SimcWithTerc");
    }

    public void QueryToDataGrid(string sqlQuery)
    {
        DataGrid.ItemsSource = null;
        SimcData.Clear();
        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = sqlQuery;
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            string name = reader.GetString(0);
            string simcCode = reader.GetString(1);
            string province = reader.GetString(2);
            string district = reader.GetString(3);
            string commune = reader.GetString(4);
            string communeType = reader.GetString(5);

            SimcData.Add(new SimcDataStruct(name, simcCode, province, district, commune, communeType));
        }

        DataGrid.ItemsSource = SimcData;
        NumOfResults.Text = $"Ilość wierszy: {SimcData.Count}";
    }

    private void Search_OnClick(object sender, RoutedEventArgs e)
    {
        if (!IsSearchWindowOpen())
        {
            SearchWindow = new SearchWindow(this);
            SearchWindow.Show();
        }
    }

    private void SearchAll_OnClick(object sender, RoutedEventArgs e)
    {
        QueryToDataGrid("SELECT * FROM SimcWithTerc");
    }

    private bool IsSearchWindowOpen()
    {
        if (SearchWindow != null && SearchWindow.IsVisible)
        {
            MessageBox.Show("Okno wyszukiwania jest już otwarte!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            SearchWindow.Focus();
            return true;
        }

        return false;
    }

    private void SimcDataWindow_OnClosed(object? sender, EventArgs e)
    {
        Connection.Close();
        SearchWindow?.Close();
    }
}