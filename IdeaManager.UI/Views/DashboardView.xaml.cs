using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace IdeaManager.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour DashboardView.xaml
    /// </summary>
    public partial class DashboardView : Page
    {
        private readonly IServiceProvider _serviceProvider;

        public DashboardView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void OnSubmitIdeaClick(object sender, RoutedEventArgs e)
        {
            var ideaFormView = _serviceProvider.GetRequiredService<IdeaFormView>();
            NavigationService?.Navigate(ideaFormView);
        }

        private void OnViewIdeasClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var ideaListView = _serviceProvider.GetRequiredService<IdeaListView>();
                NavigationService?.Navigate(ideaListView);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Navigation failed: " + ex.Message);
            }
        }


    }
}
