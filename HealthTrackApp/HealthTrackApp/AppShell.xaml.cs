namespace HealthTrackApp
{
    using HealthTrackApp.Pages;

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
            Routing.RegisterRoute(
                nameof(GoalsPage),
                typeof(GoalsPage));
            Routing.RegisterRoute(
                nameof(SettingsPage),
                typeof(SettingsPage));
            Routing.RegisterRoute(
                nameof(EditProfilePage),
                typeof(EditProfilePage));
            Routing.RegisterRoute(
                nameof(LogMeasurementPage),
                typeof(LogMeasurementPage));
            Routing.RegisterRoute(
                nameof(LogSleepPage),
                typeof(LogSleepPage));
            Routing.RegisterRoute(
                nameof(ActivitesPage),
                typeof(ActivitesPage));
            Routing.RegisterRoute(
                nameof(LoginPage),
                typeof(LoginPage));
            Routing.RegisterRoute(
                nameof(RegisterPage),
                typeof(RegisterPage));
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(ProfilePage));
        }

        private async void OnEditProfileClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(EditProfilePage));
        }

        private async void OnStatsClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(StatisticsPage));
        }

        private async void OnGoalsClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(GoalsPage));
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(SettingsPage));
        }

        private async void OnLogMeasurementClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(LogMeasurementPage));
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(LoginPage));
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await GoToAsync(nameof(RegisterPage));
        }
    }
}