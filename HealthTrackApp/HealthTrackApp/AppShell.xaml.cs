using HealthTrackApp.Pages;

namespace HealthTrackApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(ProfilePage),
                typeof(ProfilePage));
            Routing.RegisterRoute(
                nameof(StatisticsPage),
                typeof(StatisticsPage));
        }


        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(ProfilePage));
        }

        private async void OnStatsClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(StatisticsPage));
        }
    }
}
