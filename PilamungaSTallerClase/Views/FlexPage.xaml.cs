namespace PilamungaSTallerClase.Views;

public partial class FlexPage : ContentPage
{
	public FlexPage()
	{
		InitializeComponent();
	}

    private void BtnIrAAbsolutePage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsolutePage());
    }
}