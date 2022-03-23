namespace MyFirstMAUIApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count % 10 == 0)
            {
                imgMain.WidthRequest *= 2;
                imgMain.HeightRequest *= 2;
            }
            
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}