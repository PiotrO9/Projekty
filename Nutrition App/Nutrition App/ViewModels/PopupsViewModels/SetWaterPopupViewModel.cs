using Nutrition_App.Views.Popups;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using Nutrition_App.Enums;
using Nutrition_App.Views;

namespace Nutrition_App.ViewModels.PopupsViewModels
{
    public class SetWaterPopupViewModel : BaseViewModel
    {
        private SetWaterPopup _swp { get; set; }

        public bool IsNotSelected { get; set; }

        public ObservableCollection<string> CollectionSource { get; set; }

        private WaterOperationType _waterOperationChoice { get; set; }

        private WaterPageViewModel _wpVM { get; set; }

        public SetWaterPopupViewModel(SetWaterPopup setWaterPopup, ObservableCollection<string> vs, WaterOperationType waterOperationType, WaterPageViewModel waterPageViewModel)
        {
            IsNotSelected = false;

            _swp = setWaterPopup;
            CollectionSource = vs;
            _waterOperationChoice = waterOperationType;
            _wpVM = waterPageViewModel;

            ButtonBackgroundColor = System.Drawing.Color.FromArgb(255, 0, 0);

            QuitCommand = new Command(QuitCommandImpl);
        }

        private string _selectedItem;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                IsNotSelected = true;
                ButtonBackgroundColor = System.Drawing.Color.FromArgb(0, 255, 0);
            }
        }

        private System.Drawing.Color _buttonBackgroundColor;

        public System.Drawing.Color ButtonBackgroundColor
        {
            get { return _buttonBackgroundColor; }
            set { _buttonBackgroundColor = value; OnPropertyChanged(); }
        }



        public Command QuitCommand { get; }
        public void QuitCommandImpl()
        {
            if(IsNotSelected == true)
            {
                switch (_waterOperationChoice)
                {
                    case WaterOperationType.TotalAmount:
                        {
                            Preferences.Set("TotalWaterAmount", SelectedItem);
                            break; 
                        }
                    case WaterOperationType.Capacity:
                        {
                            Preferences.Set("CapacityOfWater", SelectedItem);
                            break; 
                        }
                }

                _wpVM.UpdateValuesToTexts();
                _swp.Dismiss(null);
            }
        }
    }
}
