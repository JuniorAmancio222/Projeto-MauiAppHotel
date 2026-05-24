using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Garante o suporte à navegação entre as telas do App Hotel
            MainPage = new NavigationPage(new MainPage());
        }
    }
}