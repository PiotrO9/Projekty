using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class OneRepMaxViewModel
    {
        private OneRepPage _oneRepPage;

        #region Controls

        Button btnPickedExercise;


        Entry BodyWeightEntry;
        Entry WeightEntry;
        Entry RepsEntry;

        #endregion

        public OneRepMaxViewModel(OneRepPage oneRepPage)
        {
            SetControls();
            _oneRepPage = oneRepPage;

            CalculateCommand = new Command(CalculateCommandImpl);
            QuitCommand = new Command(QuitCommandImpl);
        }

        #region Commands

        public Command CalculateCommand { get; }

        public Command QuitCommand { get; }

        #endregion

        #region Commands implementations

        public void CalculateCommandImpl()
        {
            if(CheckIfControlsAreEmpty() == true)
            {
                //Tu koniec
            }
        }

        public void QuitCommandImpl()
        {

        }

        #endregion

        public void SetControls()
        {
            btnPickedExercise = (Button)_oneRepPage.FindByName("btnPickedExercise");

            BodyWeightEntry = (Entry)_oneRepPage.FindByName("BodyWeightEntry");
            WeightEntry = (Entry)_oneRepPage.FindByName("WeightEntry");
            RepsEntry = (Entry)_oneRepPage.FindByName("RepsEntry");
        }

        public void ClearControls()
        {
            BodyWeightEntry.Text = "";
            WeightEntry.Text = "";
            RepsEntry.Text = "";
        }

        public bool CheckIfControlsAreEmpty()
        {
            bool result = true; //Zwraca true, jeżeli wszystko jest ok, zwraca false gdy napotka puste pole

            if(BodyWeightEntry.Text == "")
            {
                result = false;
            }
            else if(WeightEntry.Text == "")
            {
                result = false;
            }
            else if (RepsEntry.Text == "")
            {
                result = false;
            }

            return result;
        }

    }

}
