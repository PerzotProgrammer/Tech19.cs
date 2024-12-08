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

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
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
            SqliteCommand subCommand = Connection.CreateCommand();
            string name = reader.GetString(0);
            string simcCode = reader.GetString(1);
            string provinceRaw = reader.GetString(2);
            string districtRaw = reader.GetString(3);
            string communeRaw = reader.GetString(4);

            subCommand.CommandText = $"SELECT nazwa FROM Terc WHERE woj = '{provinceRaw}'";
            string province = subCommand.ExecuteScalar()?.ToString() ?? " - ";
            province = province[0].ToString().ToUpper() + province.Substring(1).ToLower();

            subCommand.CommandText = $"SELECT nazwa FROM Terc WHERE woj = '{provinceRaw}' AND pow = '{districtRaw}'";
            string district = subCommand.ExecuteScalar()?.ToString() ?? " - ";

            subCommand.CommandText =
                $"SELECT nazwa FROM Terc WHERE woj = '{provinceRaw}' AND pow = '{districtRaw}' AND gmi = '{communeRaw}'";
            string commune = subCommand.ExecuteScalar()?.ToString() ?? " - ";

            subCommand.CommandText =
                $"SELECT nazwa_dod FROM Terc WHERE woj = '{provinceRaw}' AND pow = '{districtRaw}' AND gmi = '{communeRaw}'";
            string type = subCommand.ExecuteScalar()?.ToString() ?? " - ";

            SimcData.Add(new SimcDataStruct(name, simcCode, province, district, commune, type));
        }

        DataGrid.ItemsSource = SimcData;
        NumOfResults.Text = $"Ilość wierszy: {SimcData.Count}";
    }

    private void Search_OnClick(object sender, RoutedEventArgs e)
    {
        if (!IsSearchWindowOpen())
        {
            SearchWindow = new SearchWindow(this, Connection);
            SearchWindow.Show();
        }
    }

    private void SearchAll_OnClick(object sender, RoutedEventArgs e)
    {
        QueryToDataGrid("SELECT nazwa, sym, woj, pow, gmi FROM Simc");
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
}