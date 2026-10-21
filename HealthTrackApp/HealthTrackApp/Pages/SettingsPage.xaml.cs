namespace HealthTrackApp.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    public async void OnProfileClicked()
    {
        await Shell.Current.GoToAsync("ProfilePage");
    }
}