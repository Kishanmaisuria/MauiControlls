namespace ContolsMaui.Pages;

public partial class Indicators : ContentPage
{
	public Indicators()
	{
		InitializeComponent();
	}

    private void INDIAButton_Clicked(object sender, EventArgs e)
    {
        ActivityIndicator.IsRunning = !ActivityIndicator.IsRunning;
    }
}