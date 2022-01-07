using Nutrition_App.Views.Popups;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using Nutrition_App.Enums;
using Nutrition_App.Views;

namespace Nutrition_App.ViewModels.PopupsViewModels
{
    class SetWaterPopupViewModel : BaseViewModel
    {
        private SetWaterPopup _swp { get; set; }

        private bool isNotSelected { get; set; } = false;

        public ObservableCollection<string> CollectionSource { get; set; }

        private WaterOperationType _waterOperationChoice { get; set; }

        private WaterPage _wp { get; set; }

        public SetWaterPopupViewModel(SetWaterPopup setWaterPopup, ObservableCollection<string> vs, WaterOperationType waterOperationType,WaterPage waterPage)
        {
            _swp = setWaterPopup;
            CollectionSource = vs;
            _waterOperationChoice = waterOperationType;
            _wp = waterPage;

            QuitCommand = new Command(QuitCommandImpl);
        }

        private string _selectedItem;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set 
            {
                _selectedItem = value;
                isNotSelected = true;
            }
        }

        public Command QuitCommand { get; }
        public void QuitCommandImpl()
        {
            if(isNotSelected == true)
            {
                switch (_waterOperationChoice)
                {
                    case WaterOperationType.TotalAmount:
                        {
                            Preferences.Set("TotalWaterAmount", SelectedItem+"ml");
                            break; 
                        }
                    case WaterOperationType.Capacity:
                        {
                            Preferences.Set("CapacityOfWater", SelectedItem + "ml");
                            break; 
                        }
                }
  

            _swp.Dismiss(null);
            }
        }
    }
}
