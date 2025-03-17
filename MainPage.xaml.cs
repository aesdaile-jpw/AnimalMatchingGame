namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
