using Dziennik_treningowy.Models;
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
    public partial class NewTrainingPage : ContentPage
    {
        private NewTrainingViewModel _vm;

        public Exercise exersise;

        public NewTrainingPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new NewTrainingViewModel();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {

        }
    }
}