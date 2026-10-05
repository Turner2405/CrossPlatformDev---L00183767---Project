using Microsoft.Extensions.DependencyInjection;

namespace HealthTrackApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           //Create a new navigation page
           MainPage = new NavigationPage(new MainPage());
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new MainPage());
        //}
    }
}