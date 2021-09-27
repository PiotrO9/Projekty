using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using Dziennik_treningowy.Views;
using Dziennik_treningowy.Views.Popups;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    public class NewTrainingViewModel
    {
        private NewTrainingPage _newTrainingPage { get; set; }

        private List<List<Exercise>> ExerciseList;

        #region Location in Exercise List

        private int CurrentListNumber { get; set; }

        private int CurrentExerciseNumber { get; set; }

        #endregion

        public NewTrainingViewModel(NewTrainingPage newTrainingPage)
        {
            _newTrainingPage = newTrainingPage;
            AddClickCommand = new Command(AddClickCommandImpl);
        }

        public Command AddClickCommand { get; }

        public void AddClickCommandImpl()
        {
            _newTrainingPage.Navigation.ShowPopup(new ExersicePopup(_newTrainingPage,this)
            {
                IsLightDismissEnabled = false
            });
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
                                CurrentExerciseName = ExerciseList[CurrentListNumber][CurrentListNumber].timeExercise.Name;
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
    }
}
