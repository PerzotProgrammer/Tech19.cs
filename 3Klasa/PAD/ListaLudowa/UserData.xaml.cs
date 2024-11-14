using System.Windows.Controls;

namespace ListaLudowa;

public partial class UserData : UserControl
{
    public UserData(Person person)
    {
        InitializeComponent();
        PersonName.Text += $"\t{person.Name}";
        PersonGender.Text += $"\t{person.Gender}";
        PersonAbout.Text += $"\t{person.About}";
    }
}