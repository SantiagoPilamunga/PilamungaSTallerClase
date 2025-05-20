namespace PilamungaSTallerClase.Views;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void BtnIrAFlexPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexPage());
    }
}