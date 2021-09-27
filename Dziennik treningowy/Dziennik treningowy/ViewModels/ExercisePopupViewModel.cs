using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using Dziennik_treningowy.Services.Setting_services;
using Dziennik_treningowy.Views.Popups;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class ExercisePopupViewModel : INotifyPropertyChanged
    {
        private readonly ExersicePopup _ep;

        private NewTrainingViewModel _newTrainingViewModel;

        public ObservableCollection<string> ExercisesNamesCollection { get; set; }

        public string _selectedExercise { get; set; }
        public string SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                if(_selectedExercise != value)
                {
                    _selectedExercise = value;
                    _ep.PickedExercise = GetExerciseFromSelectedString(SelectedExercise);
                    _ep.UpdateExercise();
                }
            }
        }

        public ExercisePopupViewModel(ExersicePopup exersicePopup, NewTrainingViewModel newTrainingViewModel)
        {
            _ep = exersicePopup;
            _newTrainingViewModel = newTrainingViewModel;
            FillCollection();

            CloseButtonClick = new Command(CloseButtonClickImpl);
        }

        public Command CloseButtonClick { get; }

        public void CloseButtonClickImpl()
        {
            if(_ep.PickedExercise != null)
            {
                _ep.Dismiss(null);
                _newTrainingViewModel.RefreshExerciseList();
            }
        }


        public Exercise GetExerciseFromSelectedString(string pick)
        {
            Exercise exercise =  new Exercise();

            var ListOfExercises = SetListOfExercises.Method();

            foreach (var item in ListOfExercises)
            {
                if(item.Key == pick)
                {
                    switch (item.Value)
                    {
                        case Enums.TypeOfExercise.Weight:
                            {
                                exercise.weightExercise = new WeightExercise();
                                exercise.weightExercise.Name = pick;
                                break;
                            }
                        case Enums.TypeOfExercise.NoWeight:
                            {
                                exercise.noWeightExercise = new NoWeightExercise();
                                exercise.noWeightExercise.Name = pick;
                                break;
                            }
                        case Enums.TypeOfExercise.Time:
                            {
                                exercise.timeExercise = new TimeExercise();
                                exercise.timeExercise.Name = pick;
                                break;
                            }
                    }
                }
            }

            return exercise;
        }

        public void FillCollection()
        {
            ObservableCollection<string> ListOfStrings = new ObservableCollection<string>();

            var ListOfExercises = SetListOfExercises.Method();

            foreach (var exercise in ListOfExercises)
            {
                ListOfStrings.Add(exercise.Key);
            }
            ExercisesNamesCollection = ListOfStrings;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    //Dismiss(null);
}
