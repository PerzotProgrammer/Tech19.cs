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

namespace KartkowaJedenWPF;

/// <summary>
/// Interaction logic for FirstWindow.xaml
/// </summary>
public partial class FirstWindow : Window
{
    public FirstWindow()
    {
        InitializeComponent();
        new SecondWindow().Show();
    }
}