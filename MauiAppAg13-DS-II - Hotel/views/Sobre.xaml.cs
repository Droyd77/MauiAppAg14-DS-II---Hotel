using Microsoft.Maui.Controls;

namespace MauiAppAg13_DS_II___Hotel.views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private async void OnLinkTapped(object sender, TappedEventArgs e)
        {
            // Abre link informado
            await Launcher.OpenAsync("https://github.com/Droyd77/MauiAppAg13-DS-II---Hotel.git");
        }

    }
}
