using Dziennik_treningowy.Models;
using Dziennik_treningowy.ViewModels;
using Newtonsoft.Json;
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
    [QueryProperty(nameof(ContentInformation), nameof(ContentInformation))]
    public partial class TrainingRoutinePage : ContentPage
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
                BindingContext = new TrainingRoutineViewModel();
            }
        }

        private void PerformOperation(string getcont)
        {
            var content = JsonConvert.DeserializeObject<List<List<Exercise>>>(getcont);
            ExercisesList = content;
        }

        public TrainingRoutinePage()
        {
            InitializeComponent();
            
        }
    }
}