namespace HealthTrackApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            btnNavigateToNext.Clicked += OnbtnNavigateToNext_Clicked;
        }

        private async void OnbtnNavigateToNext_Clicked(object sender, EventArgs e)
        {
            // Push a newpage onto the stack
            await Navigation.PushAsync(new NewPage1());
        }

       
    }
}
