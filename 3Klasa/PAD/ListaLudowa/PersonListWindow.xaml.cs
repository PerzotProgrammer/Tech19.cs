using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListaLudowa;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class PersonListWindow : Window
{
    private AddPerson? AddPersonWindow;

    public PersonListWindow()
    {
        FileExistsCheck();
        InitializeComponent();
    }


    private void FileExistsCheck()
    {
        if (!File.Exists(App.DataPath))
        {
            MessageBoxResult result = MessageBox.Show("Brak potrzebnego pliku danych.\nCzy chcesz stworzyć nowy plik?",
                "Błąd",
                MessageBoxButton.YesNo, MessageBoxImage.Error);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    File.Create(App.DataPath).Close();
                    break;
                case MessageBoxResult.No:
                    Close();
                    return;
            }
        }
    }


    private void OnContentLoad(object sender, RoutedEventArgs e)
    {
        LoadData();
    }


    private void AddPerson_OnClick(object sender, RoutedEventArgs e)
    {
        if (AddPersonWindow != null && AddPersonWindow.IsVisible)
        {
            MessageBox.Show("Okno dodawania osoby jest już otwarte.", "Błąd", MessageBoxButton.OK,
                MessageBoxImage.Information);
            return;
        }

        AddPersonWindow = new AddPerson(this);
        AddPersonWindow.Show();
    }

    public void LoadData()
    {
        PersonList.Children.Clear();
        StreamReader reader = new StreamReader(App.DataPath);
        while (!reader.EndOfStream)
        {
            Person person = JsonSerializer.Deserialize<Person>(reader.ReadLine()!)!;
            UserData userData = new UserData(person);
            PersonList.Children.Add(userData);
        }
    }
}