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

        }
    }
}