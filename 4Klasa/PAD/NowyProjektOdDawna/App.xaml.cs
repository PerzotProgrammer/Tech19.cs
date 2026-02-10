using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace NowyProjektOdDawna;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public IServiceProvider ServiceProvider;

    public new static App Current => (App)Application.Current;


    public App()
    {
        ServiceProvider = ProvideServices();
        InitializeComponent();
    }

    private IServiceProvider ProvideServices()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<TodoViewModel, TodoViewModel>();

        return services.BuildServiceProvider();
    }
}