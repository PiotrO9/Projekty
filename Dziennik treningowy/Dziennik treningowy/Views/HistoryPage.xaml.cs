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
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            path += "/test";

            Exercise exercise = new Exercise();
            exercise.weightExercise = new WeightExercise();
            exercise.weightExercise.Name = "Wyciskanie";
            exercise.weightExercise.Weight = 56.25f;
            exercise.weightExercise.Reps = 7;
            exercise.weightExercise.Duration = 3;
            exercise.weightExercise.Time = 13;

            ExerciseToTxt.Method(exercise);

            string[] fileEntries = Directory.GetFiles(path);
            Console.Write(fileEntries[0].ToString());
        }
    }
}