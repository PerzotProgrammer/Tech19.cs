using System.IO;
using System.Windows;

namespace Kontrolki;

public partial class UserData : Window
{
    public UserData()
    {
        InitializeComponent();
    }

    private void Save_OnClick(object sender, RoutedEventArgs e)
    {
        string buffer = String.Empty;

        buffer += $"FName: {FName.Text}\nSName: {SName.Text}\n";
        if ((bool)RbMan.IsChecked!)
        {
            buffer += "Sex: Man\n";
        }
        else if ((bool)RbWoman.IsChecked!)
        {
            buffer += "Sex: Woman\n";
        }
        else
        {
            buffer += "Sex: None\n";
        }

        buffer += $"Description:\n{Desc.Text}";

        StreamWriter sw = new StreamWriter($"./JobApplications/{FName.Text}_{SName.Text}_JobApplication.txt");
        sw.Write(buffer);
        sw.Close();
        MessageBox.Show("Twoja aplikacja będzie czekać na rozpatrzenie!", "Sukces!", MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Wyjście", MessageBoxButton.YesNo,
            MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes) Close();
    }
}