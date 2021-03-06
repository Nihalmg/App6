using App6.ViewModels;

using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

namespace App6.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = Ioc.Default.GetService<MainViewModel>();
            InitializeComponent();
        }
    }
}
