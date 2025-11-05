namespace MauiAppAg13_DS_II___Hotel.views;

public partial class Hospedagemcontratada : ContentPage
{
	public Hospedagemcontratada()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}catch (Exception ex )
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
		}
}