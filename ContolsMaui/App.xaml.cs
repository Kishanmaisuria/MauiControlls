using ContolsMaui.Pages;

namespace ContolsMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CommonControls();
        }
    }
}