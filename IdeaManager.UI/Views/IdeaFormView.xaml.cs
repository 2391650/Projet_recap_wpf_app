﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using IdeaManager.UI.ViewModels;

namespace IdeaManager.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour IdeaFormView.xaml
    /// </summary>
    public partial class IdeaFormView : Page
    {
        public IdeaFormView(IdeaFormViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            if (NavigationService?.CanGoBack == true)
            {
                NavigationService.GoBack();
            }
        }

    }
}
