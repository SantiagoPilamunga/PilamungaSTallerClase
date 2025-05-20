namespace PilamungaSTallerClase.Views;

public partial class AbsolutePage : ContentPage
{
	public AbsolutePage()
	{
		InitializeComponent();
	}

    private void BtnIrAGridPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}