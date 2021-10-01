using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using Dziennik_treningowy.Views;
using Dziennik_treningowy.Views.Popups;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    public class NewTrainingViewModel : INotifyPropertyChanged
    {
        private NewTrainingPage _newTrainingPage { get; set; }

        private List<List<Exercise>> ExerciseList;

        #region Exercise properties change

        private string _name;
        private int _time;
        private float _weight;
        private int _reps;
        private int _duration;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public int Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }
        public int Reps
        {
            get { return _reps; }
            set
            {
                _reps = value;
                OnPropertyChanged();
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Location in Exercise List

        private bool IsFinished { get; set; }

        private int CurrentListNumber { get; set; }

        private int CurrentExerciseNumber { get; set; }

        #endregion

        #region Location exercise in current page to print

        private int CurrentListNumberToPrint { get; set; }

        private int CurrentExerciseNumberToPrint { get; set; }

        #endregion


        public NewTrainingViewModel(NewTrainingPage newTrainingPage)
        {
            _newTrainingPage = newTrainingPage;
            AddClickCommand = new Command(AddClickCommandImpl);
            AcceptClickCommand = new Command(AcceptClickCommandImpl);
        }

        #region Commands

        public Command AddClickCommand { get; }

        public Command AcceptClickCommand { get; }

        #endregion

        #region Commands implementations

        public void AddClickCommandImpl()
        {
            _newTrainingPage.Navigation.ShowPopup(new ExersicePopup(_newTrainingPage,this)
            {
                IsLightDismissEnabled = false
            });
        }

        public void AcceptClickCommandImpl()
        {
            RefreashPropertiesInViewModel();
        }

        #endregion

        #region ViewModel Inside methods

        public void RefreashPropertiesInViewModel() // Odświeżanie danych w tym viewmodelu
        {
            if(IsFinished == true)
            {
                //Koniec ale taki ostateczny
            }

            if(ExerciseList.Count - 1 == CurrentListNumberToPrint)
            {
                if(ExerciseList[CurrentListNumberToPrint - 1].Count - 1 == CurrentExerciseNumberToPrint)
                {
                    IsFinished = true; // Tutaj wysyłanie potwierdzenia zakończenia treningu
                }
            }

            Exercise tempExercise = new Exercise();

            Name = "";
            Time = 0;
            Weight = 0;
            Reps = 0;
            Duration = 0;

            if (CurrentExerciseNumberToPrint == 0) // Jeżeli ćwiczenie jest 1, wyświetl je
            {

                tempExercise.weightExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].weightExercise;
                tempExercise.noWeightExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].noWeightExercise;
                tempExercise.timeExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].timeExercise;

                CurrentExerciseNumberToPrint++;

                if(ExerciseList[CurrentListNumberToPrint].Count == 1)
                {
                    if(ExerciseList.Count == 1)
                    {
                        //Koniec
                    }
                    else
                    {
                        if(CurrentListNumberToPrint == ExerciseList.Count - 1)
                        {
                            //Koniec
                        }
                        CurrentListNumberToPrint++;
                        CurrentExerciseNumberToPrint = 0;
                    }

                }
            }
            else // Kiedy ćwiczenie nie jest 1
            {
                if(ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint] != null)
                {
                    tempExercise.weightExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].weightExercise;
                    tempExercise.noWeightExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].noWeightExercise;
                    tempExercise.timeExercise = ExerciseList[CurrentListNumberToPrint][CurrentExerciseNumberToPrint].timeExercise;

                    CurrentExerciseNumberToPrint++;

                    if (ExerciseList[CurrentListNumberToPrint].Count == CurrentExerciseNumberToPrint)
                    {
                        if (ExerciseList.Count == CurrentListNumberToPrint + 1)
                        {
                            //Koniec
                        }
                        else
                        {
                            if (CurrentListNumberToPrint == ExerciseList.Count - 1)
                            {
                                //Koniec
                            }

                            CurrentListNumberToPrint++;
                            CurrentExerciseNumberToPrint = 0;
                        }

                    }
                }
                else
                {
                    if(ExerciseList[CurrentListNumberToPrint + 1][0] == null)
                    {
                        //Koniec
                    }
                    else // Przejście do następnej listy
                    {
                        if (CurrentListNumberToPrint == ExerciseList.Count - 1)
                        {
                            //Koniec
                        }

                        CurrentListNumberToPrint++;
                        CurrentExerciseNumberToPrint = 0;
                    }
                }
                
            }
            

            if(tempExercise.weightExercise != null)
            {
                Name = tempExercise.weightExercise.Name;
                Time = tempExercise.weightExercise.Time;
                Weight = tempExercise.weightExercise.Weight;
                Reps = tempExercise.weightExercise.Reps;
                Duration = tempExercise.weightExercise.Duration;
            }
            else if(tempExercise.noWeightExercise != null)
            {
                Name = tempExercise.noWeightExercise.Name;
                Time = tempExercise.noWeightExercise.Time;
                Reps = tempExercise.noWeightExercise.Reps;
                Duration = tempExercise.noWeightExercise.Duration;
            }
            else if(tempExercise.timeExercise != null)
            {
                Name = tempExercise.timeExercise.Name;
                Time = tempExercise.timeExercise.Time;
                Duration = tempExercise.timeExercise.Duration;
            }

        }

        public void RefreshExerciseList()
        {
            if(ExerciseList == null)
            {
                ExerciseList = new List<List<Exercise>>();
                ExerciseList.Add(new List<Exercise>());
                ExerciseList[0].Add(_newTrainingPage.PickedExercise);

                CurrentListNumber = 0;
                CurrentExerciseNumber = 0;
            }
            else
            {
                TypeOfExercise typeOfExercise = new TypeOfExercise();
                TypeOfExercise TypeOfPickedExercise = new TypeOfExercise();

                //Tworzenie enumów pod sprawdzenie Typów ćwiczeń

                #region Set type of current exercise

                if (ExerciseList[CurrentListNumber][CurrentExerciseNumber].weightExercise != null )
                {
                    typeOfExercise = TypeOfExercise.Weight;
                }
                 else if(ExerciseList[CurrentListNumber][CurrentExerciseNumber].noWeightExercise != null)
                {
                    typeOfExercise = TypeOfExercise.NoWeight;
                }
                 else if(ExerciseList[CurrentListNumber][CurrentExerciseNumber].timeExercise != null)
                {
                    typeOfExercise = TypeOfExercise.Time;
                }

                #endregion

                #region Set type of picked exercise

                if (_newTrainingPage.PickedExercise.weightExercise != null)
                {
                    TypeOfPickedExercise = TypeOfExercise.Weight;
                }
                else if (_newTrainingPage.PickedExercise.noWeightExercise != null)
                {
                    TypeOfPickedExercise = TypeOfExercise.NoWeight;
                }
                else if (_newTrainingPage.PickedExercise.timeExercise != null)
                {
                    TypeOfPickedExercise = TypeOfExercise.Time;
                }

                #endregion

                if(typeOfExercise == TypeOfPickedExercise) //Jeżeli ćwiczenia są tego samego typu, sprawdz czy ćwiczenia nie są te same, jeżeli tak to stwórz kolejną serie, jeżeli nie, dodaj nowe ćwiczenie
                {
                    string PickedExerciseName;
                    string CurrentExerciseName;

                    switch (typeOfExercise)
                    {
                        case TypeOfExercise.Weight:
                            {
                                PickedExerciseName = _newTrainingPage.PickedExercise.weightExercise.Name;
                                CurrentExerciseName = ExerciseList[CurrentListNumber][CurrentExerciseNumber].weightExercise.Name;
                            break;
                            }
                        case TypeOfExercise.NoWeight:
                            {
                                PickedExerciseName = _newTrainingPage.PickedExercise.noWeightExercise.Name;
                                CurrentExerciseName = ExerciseList[CurrentListNumber][CurrentExerciseNumber].noWeightExercise.Name;
                            break;
                            }
                        case TypeOfExercise.Time:
                            {
                                PickedExerciseName = _newTrainingPage.PickedExercise.timeExercise.Name;
                                CurrentExerciseName = ExerciseList[CurrentListNumber][CurrentExerciseNumber].timeExercise.Name;
                            break;
                            }
                        default:
                            {
                                PickedExerciseName = string.Empty;
                                CurrentExerciseName = string.Empty;
                                break;
                            }
                    }

                    if(PickedExerciseName == CurrentExerciseName) // Ćwiczenia takie same, stwórz nową serie
                    {
                        ExerciseList[CurrentListNumber].Add(_newTrainingPage.PickedExercise);
                        CurrentExerciseNumber++;
                    }
                    else // Cwiczenia sa różne, stwórz nową serie
                    {
                        List<Exercise> TempList = new List<Exercise>();
                        TempList.Add(_newTrainingPage.PickedExercise);

                        ExerciseList.Add(TempList);

                        CurrentListNumber++;
                        CurrentExerciseNumber = 0;
                    }

                    _newTrainingPage.PickedExercise = null;

                }
                else // Ćwiczenia różnych typów, poprostu dodaj nową liste, a w niej ćwiczenie
                {
                    List<Exercise> TempList = new List<Exercise>();
                    TempList.Add(_newTrainingPage.PickedExercise);

                    ExerciseList.Add(TempList);

                    CurrentListNumber++;
                    CurrentExerciseNumber = 0;

                    _newTrainingPage.PickedExercise = null;
                }

            }
        }

        #endregion

        #region Property changed

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
