using IdeaManager.Data;
using IdeaManager.Services;
using IdeaManager.UI.ViewModels;
using IdeaManager.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace IdeaManager.UI;

public partial class App : Application
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();

        var dbPath = @"C:\Users\alexr\Desktop\session4\entreprise\Projet_recap_wpf_app\IdeaManager.Data\ideas.db";

        services.AddDataServices($"Data Source={dbPath}");
        services.AddDomainServices();
        services.AddUIServices();

        ServiceProvider = services.BuildServiceProvider();

        var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }

}
