namespace MauiAppEventos.View;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            Navigation.PopAsync();

        } catch (Exception ex)
		{
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}