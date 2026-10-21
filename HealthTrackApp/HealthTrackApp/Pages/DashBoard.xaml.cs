namespace HealthTrackApp.Pages
{
    public partial class DashBoard : ContentPage
    {

        public DashBoard()
        {
            InitializeComponent();
        }
        
        private async void OnMeasurementClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LogMeasurementPage");
        }
        
        private async void OnSleepClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LogSleepPage");
        }

        private async void OnActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ActivitesPage");
        }

        private void Label_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}
