using Nutrition_App.Enums;
using Nutrition_App.Services;
using Nutrition_App.ViewModels.PopupsViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nutrition_App.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetWaterPopup : Popup
    {
        private WaterPage _wp { get; set; }

        public SetWaterPopup(WaterOperationType waterOperationType, WaterPage waterPage)
        {
            _wp = waterPage;

            ObservableCollection<string> collection = new ObservableCollection<string>();

            switch (waterOperationType)
            {
                case WaterOperationType.TotalAmount:
                    {
                        collection = GetListOfWaterAmount.GetListOfWaterAmountMethod(WaterOperationType.TotalAmount, 81);
                        BindingContext = new SetWaterPopupViewModel(this, collection, waterOperationType, _wp);
                        break;
                    }
                case WaterOperationType.Capacity:
                    {
                        collection = GetListOfWaterAmount.GetListOfWaterAmountMethod(WaterOperationType.Capacity, 10);
                        BindingContext = new SetWaterPopupViewModel(this, collection, waterOperationType,_wp);
                        break; 
                    }
            
            }
            InitializeComponent();
        }

    }
}