using Dziennik_treningowy.Models;
using Dziennik_treningowy.Services.Files_services;
using Dziennik_treningowy.Views;
using Dziennik_treningowy.Views.Popups;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class PickedRoutineViewModel
    {
        private PickRoutinePopup _pickRoutinePopup { get; set; }

        private string _selectedRoutine;

        public string SelectedRoutine
        {
            get { return _selectedRoutine; }
            set 
            {
                _selectedRoutine = value;

                if (IfSelectedRoutineInitiated == false)
                {
                    IfSelectedRoutineInitiated = true;
                }
                else
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves" + "/" + SelectedRoutine + ".txt";
                    List<List<Exercise>> exercises = TxtToTrainingUnit.Method(path);

                    var jsonStr = JsonConvert.SerializeObject(exercises);

                    Shell.Current.GoToAsync($"{nameof(NewTrainingPage)}?ContentInformation={jsonStr}");
                    _pickRoutinePopup.Dismiss(null);
                }
            }
        }

        public bool IfSelectedRoutineInitiated { get; set; } = false;

        public ObservableCollection<string> SourceCollection { get; set; }


        public PickedRoutineViewModel(PickRoutinePopup pickRoutinePopup)
        {
            _pickRoutinePopup = pickRoutinePopup;
            FillSource();
        }


        #region Methods

        public void FillSource()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves";
            string[] fileEntries = Directory.GetFiles(path);

            List<string> TemporaryList = new List<string>();

            foreach (var file in fileEntries)
            {
                string RawName = file.Remove(0, 82);
                string CutName = RawName.Remove(RawName.Length - 4, 4);
                TemporaryList.Add(CutName);
            }

            SourceCollection = new ObservableCollection<string>(TemporaryList);
        }

        #endregion

    }
}
