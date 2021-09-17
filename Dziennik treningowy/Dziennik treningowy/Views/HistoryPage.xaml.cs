using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using Dziennik_treningowy.Services.Files_services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();

            
        }

        private void btnTest_Clicked(object sender, EventArgs e)
        {
            List<List<Exercise>> TrainingUnit = new List<List<Exercise>>();

            for (int i = 0; i < 3; i++)
            {
                List<Exercise> TempExercise = new List<Exercise>();

                Exercise exercise = new Exercise();
                exercise.weightExercise = new WeightExercise();
                exercise.weightExercise.Name = "Wyciskanie";
                exercise.weightExercise.Reps = 7;
                exercise.weightExercise.Weight = 45.45f;

                TempExercise.Add(exercise);
                TempExercise.Add(exercise);

                TrainingUnit.Add(TempExercise);
            }

            for (int i = 0; i < 2; i++)
            {
                List<Exercise> TempExercise = new List<Exercise>();

                Exercise exercise = new Exercise();
                exercise.noWeightExercise = new NoWeightExercise();
                exercise.noWeightExercise.Name = "Pompki";
                exercise.noWeightExercise.Time = 12;
                exercise.noWeightExercise.Duration = 3;
                exercise.noWeightExercise.Reps = 7;

                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);

                TrainingUnit.Add(TempExercise);
            }

            for (int i = 0; i < 6; i++)
            {
                List<Exercise> TempExercise = new List<Exercise>();

                Exercise exercise = new Exercise();
                exercise.timeExercise = new TimeExercise();
                exercise.timeExercise.Name = "Plank";
                exercise.timeExercise.Duration = 31;
                exercise.timeExercise.Time = 13;

                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);
                TempExercise.Add(exercise);

                TrainingUnit.Add(TempExercise);
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves/save2.txt";

            TrainingUnitToTxt.Method(TrainingUnit,Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/trainingSaves"));

            TrainingUnit = TxtToTrainingUnit.Method(path);

        }
    }
}