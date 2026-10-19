namespace HealthTrackApp.Pages;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnEditProfileButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("EditProfile");
    }
}
