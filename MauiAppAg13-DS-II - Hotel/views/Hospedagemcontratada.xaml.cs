using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace MauiAppAg13_DS_II___Hotel.views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync(); // volta para a página anterior
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewReservar());
        }
    }
}
