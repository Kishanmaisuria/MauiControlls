using ContolsMaui.Pages;

namespace ContolsMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.FromRgba("#181C3F");
            MainPage = navigationPage;
        }
    }
}