namespace MauiAppAg13_DS_II___Hotel.views;

public partial class NewReservar : ContentPage
{
	public NewReservar()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text) ||
            string.IsNullOrWhiteSpace(txtDocumento.Text) ||
            pckPagamento.SelectedIndex == -1)
        {
            await DisplayAlert("Aviso", "Por favor, preencha todos os campos.", "OK");
            return;
        }

        await DisplayAlert("Sucesso", "Reserva finalizada com sucesso!", "OK");
        await Navigation.PopToRootAsync(); // Volta à tela inicial
    }
}