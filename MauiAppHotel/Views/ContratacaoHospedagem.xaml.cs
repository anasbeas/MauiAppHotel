namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    async void OnAvancarClicked(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new AppSobre());
    }

}