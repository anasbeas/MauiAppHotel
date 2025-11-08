using System.Runtime.Intrinsics.X86;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quarto;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6);
		dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
		dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);
	}
	private void OnAvancarClicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new HospedagemContratada());
        }
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");

		}
	}
}