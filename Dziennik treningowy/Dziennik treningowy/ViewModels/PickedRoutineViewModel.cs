using Dziennik_treningowy.Views.Popups;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dziennik_treningowy.ViewModels
{
    class PickedRoutineViewModel
    {
        private PickRoutinePopup _pickRoutinePopup { get; set; }

        private string _selectedRoutine;

        public string SelectedRoutine
        {
            get { return _selectedRoutine; }
            set { _selectedRoutine = value; }
        }

        public ObservableCollection<string> SourceCollection { get; set; }


        public PickedRoutineViewModel(PickRoutinePopup pickRoutinePopup)
        {
            _pickRoutinePopup = pickRoutinePopup;
            FillSource();
        }


        #region Methods

        public void FillSource()
        {

        }

        #endregion

    }
}
