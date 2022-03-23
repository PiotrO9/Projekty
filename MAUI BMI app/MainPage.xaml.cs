using MAUI_BMI_app.ViewModels;

namespace MAUI_BMI_app
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

    }
}