using System.IO;
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

namespace ListaLudowa;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnContentLoad(object sender, RoutedEventArgs e)
    {
        StreamReader reader = new StreamReader("./../../../ListaLudowa.txt");
        while (!reader.EndOfStream)
        {
            PersonList.Text += $"{reader.ReadLine()}\n";
        }
    }
}