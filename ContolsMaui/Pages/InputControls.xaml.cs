namespace ContolsMaui.Pages;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		SliderValueLabel.Text = ((int)e.NewValue).ToString();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        DisplayAlert("Stepper Vlaue",$"Value:{ e.NewValue}","Oki?");
    }
}