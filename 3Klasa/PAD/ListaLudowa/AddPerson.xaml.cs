using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace ListaLudowa;

public partial class AddPerson : Window
{
    private string PersonGender;
    private new PersonListWindow Parent;

    public AddPerson(PersonListWindow parent)
    {
        PersonGender = String.Empty;
        Parent = parent;
        InitializeComponent();
    }


    private void Confirm_OnClick(object sender, RoutedEventArgs e)
    {
        string name = PersonName.Text;
        string gender = PersonGender;
        string about = About.Text;

        if (name == String.Empty || gender == String.Empty || about == String.Empty)
        {
            MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        Person person = new Person(name, gender, about);
        StreamWriter writer = new StreamWriter(App.DataPath, true);
        writer.Write(JsonSerializer.Serialize(person));
        writer.Write("\n");
        writer.Dispose();
        MessageBox.Show("Dodano nową osobę do listy.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
        Parent.LoadData();
        Close();
    }

    private void ToggleRadio_OnChecked(object sender, RoutedEventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;
        PersonGender = radioButton.Content.ToString()!;
    }
}