using Dziennik_treningowy.Models;
using Dziennik_treningowy.ViewModels;
using Dziennik_treningowy.Views.Popups;
using Newtonsoft.Json;
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
    [QueryProperty(nameof(ContentInformation), nameof(ContentInformation))]
    public partial class NewTrainingPage : ContentPage
    {
        public List<List<Exercise>> ExercisesList { get; set; }

        string contentInformation = "";
        public string ContentInformation
        {
            get => contentInformation;
            set
            {
                contentInformation = Uri.UnescapeDataString(value ?? string.Empty);
                PerformOperation(contentInformation);
                //TransformedExerciseList = TransformExerciseList.Method(MyList);
                OnPropertyChanged();
                BindingContext = _vm = new NewTrainingViewModel(this, ExercisesList);
            }
        }
        private void PerformOperation(string getcont)
        {
            var content = JsonConvert.DeserializeObject<List<List<Exercise>>>(getcont);
            ExercisesList = content;
        }


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