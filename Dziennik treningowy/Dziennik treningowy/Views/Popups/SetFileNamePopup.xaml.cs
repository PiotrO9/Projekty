using Dziennik_treningowy.Models;
using Dziennik_treningowy.Services;
using Dziennik_treningowy.Services.Files_services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetFileNamePopup : Popup
    {
        private string _workstring;

        private List<List<Exercise>> _exerciseList;

        public SetFileNamePopup(List<List<Exercise>> ExerciseList)
        {
            InitializeComponent();
            _exerciseList = ExerciseList;
        }

        private void TextInputEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            _workstring = ((Entry)sender).Text;
        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves";
            string fileName = FileNameGenerator.GetFileName(path,_workstring);

            if(fileName != "")
            {
                TrainingUnitToTxt.Method(_exerciseList, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/trainingSaves"));
                this.Dismiss(null);
            }
        }
    }
}