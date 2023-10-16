namespace ContolsMaui.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void ADB_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked a button","ok");
    }

    private void DEMOIMGButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked download button", "ok");
    }

    private void DSBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", $"you Searched for {DSBar.Text}", "ok");
    }

    private void FBSItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked Facebook", "ok");
    }

    private void INSSItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked Instagram", "ok");
    }

    private void TwitterSItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked Twitter", "ok");
    }

    private void LinkedinSItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding moments", "you clicked Linkedin", "ok");
    }
}