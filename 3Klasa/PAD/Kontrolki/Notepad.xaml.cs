using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Kontrolki;

public partial class Notepad : Window
{
    public Notepad()
    {
        InitializeComponent();
    }

    private void Save_OnClick(object sender, RoutedEventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "No zwykły txt lolu, co ty myślałeś?|*.txt";
        if (saveFileDialog.ShowDialog() == true) File.WriteAllText(saveFileDialog.FileName, Editor.Text);
    }

    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Wyjście", MessageBoxButton.YesNo,
            MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes) Close();
    }
}