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
public partial class MainWindow : Window
{
    private SqliteConnection Connection;
    private List<SimcDataStruct> SimcData;

    public MainWindow()
    {
        Connection = new SqliteConnection("Data Source=SimcBase.db");
        SimcData = new List<SimcDataStruct>();
        InitializeComponent();
        Connection.Open();
        LoadData();
    }

    private void LoadData()
    {
        SqliteCommand command = Connection.CreateCommand();
        command.CommandText = "SELECT * FROM Simc_Poland";
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            string name = reader.GetString(6);
            string simcCode = reader.GetString(7);
            SimcData.Add(new SimcDataStruct(name, simcCode));
        }

        Grid.ItemsSource = SimcData;
    }
}