namespace HealthTrackApp.Pages;

public partial class GoalsPage : ContentPage
{
	public GoalsPage()
	{
		InitializeComponent();
	}

	private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ProfilePage");
    }
}