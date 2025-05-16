using System.Windows;
using IdeaManager.UI.Views;

namespace IdeaManager.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(DashboardView dashboardView)
    {
        InitializeComponent();
        MainFrame.Navigate(dashboardView);
    }
}