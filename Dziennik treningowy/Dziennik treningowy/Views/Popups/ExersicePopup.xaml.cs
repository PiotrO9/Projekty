using Dziennik_treningowy.Models;
using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExersicePopup : Popup
    {
        private ExercisePopupViewModel _vm;

        private NewTrainingPage _newTrainingPage;

        private NewTrainingViewModel _newTrainingViewModel;

        public Exercise PickedExercise { get; set; }

        public ExersicePopup(NewTrainingPage newTrainingPage, NewTrainingViewModel newTrainingViewModel)
        {
            InitializeComponent();
            _newTrainingPage = newTrainingPage;
            _newTrainingViewModel = newTrainingViewModel;
            BindingContext = _vm = new ExercisePopupViewModel(this,_newTrainingViewModel);
        }

        public void UpdateExercise()
        {
            _newTrainingPage.PickedExercise = PickedExercise;
        }
    }
}