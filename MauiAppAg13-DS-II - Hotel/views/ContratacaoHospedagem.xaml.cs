namespace MauiAppAg13_DS_II___Hotel.views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
	private async void OnSobreClicked(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}