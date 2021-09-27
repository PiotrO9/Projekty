using Dziennik_treningowy.Models;
using Dziennik_treningowy.ViewModels;
using Dziennik_treningowy.Views.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTrainingPage : ContentPage
    {
        private NewTrainingViewModel _vm;

        public Exercise PickedExercise { get; set; }

        public NewTrainingPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new NewTrainingViewModel(this);
        }
    }
}