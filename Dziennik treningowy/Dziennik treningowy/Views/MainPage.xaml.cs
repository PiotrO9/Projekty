using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();
            _vm = new MainPageViewModel();
            Content.BindingContext = _vm;
        }

        private void imgBtnSettings_Clicked(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();

        }

        private void imbBtnHistory_Clicked(object sender, EventArgs e)
        {

        }

        private void imbBtnTraining_Clicked(object sender, EventArgs e)
        {

        }
    }
}