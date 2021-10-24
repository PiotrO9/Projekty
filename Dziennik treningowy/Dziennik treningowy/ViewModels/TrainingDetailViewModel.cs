using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using Dziennik_treningowy.Services.Setting_services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    [QueryProperty(nameof(Content), nameof(Content))]
    class TrainingDetailViewModel : INotifyPropertyChanged
    {
        string content = "";
        public string Content
        {
            get => content;
            set
            {
                content = Uri.UnescapeDataString(value ?? string.Empty);
                PerformOperation(content);
                TransformedExerciseList = TransformExerciseList.Method(MyList);
                OnPropertyChanged();
            }
        }

        public List<Exercise> _myList;
        public List<Exercise> MyList
        { 
            get
            {
                return _myList;
            }
            set
            {
                _myList = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TransformedExercise> _transformedExerciseList;

        public ObservableCollection<TransformedExercise> TransformedExerciseList
        {
            get 
            {
                return _transformedExerciseList; 
            }
            set 
            {
                _transformedExerciseList = value;
                OnPropertyChanged();
            }
        }

        public TrainingDetailViewModel()
        {
            
        }

        private void PerformOperation(string getcont)
        {
            var content = JsonConvert.DeserializeObject<List<Exercise>>(getcont);
            MyList = content;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
