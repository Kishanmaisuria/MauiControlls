namespace ContolsMaui.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ComConButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CommonControls());
    }

    private void ACTButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }

    private void InputButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControls());
    }
}