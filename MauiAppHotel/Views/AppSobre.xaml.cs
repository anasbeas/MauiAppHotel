namespace MauiAppHotel.Views;

public partial class AppSobre : ContentPage
{
	public AppSobre()
	{
		InitializeComponent();
	}

    async void OnVoltarClicked(object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}