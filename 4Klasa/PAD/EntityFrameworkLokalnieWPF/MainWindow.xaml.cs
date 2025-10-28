using System.Collections.ObjectModel;
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
using Microsoft.Extensions.Configuration;

namespace EntityFrameworkLokalnieWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainViewModel _viewModel;

    public MainWindow()
    {
        InitializeComponent();
        _viewModel = (MainViewModel)DataContext;
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        _viewModel.AddUser(
            new User
            {
                FirstName = FirstName.Text,
                SecondName = SecondName.Text
            });
    }
}