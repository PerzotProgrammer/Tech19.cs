using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace ListaLudowa;

public partial class AddPerson : Window
{
    public AddPerson()
    {
        InitializeComponent();
    }

    private string PersonGender = String.Empty;

    private void TestWrite()
    {
        Person person1 = new Person("Jan Kowalski", "Male",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
        Person person2 = new Person("Anna Nowak", "Female",
            "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Person person3 = new Person("Janina Kowalska", "Female",
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
        StreamWriter writer = new StreamWriter(App.DataPath, true);

        writer.Write(JsonSerializer.Serialize(person1));
        writer.Write("\n");
        writer.Write(JsonSerializer.Serialize(person2));
        writer.Write("\n");
        writer.Write(JsonSerializer.Serialize(person3));
        writer.Dispose();
    }

    private void Confirm_OnClick(object sender, RoutedEventArgs e)
    {
        string name = PersonName.Text;
        string gender = PersonGender;
        string about = About.Text;

        Person person = new Person(name, gender, about);
        StreamWriter writer = new StreamWriter(App.DataPath, true);
        writer.Write(JsonSerializer.Serialize(person));
        writer.Write("\n");
        writer.Dispose();
        MessageBox.Show("Dodano nową osobę do listy.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
        Close();
    }

    private void ToggleRadio_OnChecked(object sender, RoutedEventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;
        PersonGender = radioButton.Content.ToString()!;
    }
}