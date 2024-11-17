using MauiAppEventos.Models;

namespace MauiAppEventos.View;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();

		dtpk_inicio.MinimumDate = DateTime.Now;
		dtpk_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddMonths(1);

		dtpk_termino.MinimumDate = dtpk_inicio.Date;
		dtpk_termino.MaximumDate = dtpk_inicio.Date.AddMonths(1).AddDays(1);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento ev = new Evento
			{
				NomeEvento = txt_evento.Text,
				DataInicio = dtpk_inicio.Date,
				DataTermino = dtpk_termino.Date,
				QntParticipante = Convert.ToInt32(txt_nump.Text),
				CustoParticipante = Convert.ToDouble(txt_custop.Text),
				LocalEvento = txt_local.Text,
			};

			await Navigation.PushAsync(new View.EventoCadastrado()
			{
				BindingContext = ev
			});
		} catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

    private async void dtpk_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpk_termino.MinimumDate = data_selecionada_inicio;
		dtpk_termino.MaximumDate = data_selecionada_inicio.AddMonths(1).AddDays(1);
    }
}