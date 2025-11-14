using MauiAppAg13_DS_II___Hotel.Models;

namespace MauiAppAg13_DS_II___Hotel.views
{
    public partial class HospedagemContratada : ContentPage
    {
        // Apenas um construtor é permitido!
        public HospedagemContratada(Hospedagem h)
        {
            InitializeComponent();
            BindingContext = h;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
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
