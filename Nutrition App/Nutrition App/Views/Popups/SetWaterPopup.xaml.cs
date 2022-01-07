using Nutrition_App.Enums;
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

        public SetWaterPopup(WaterOperationType waterOperationType,WaterPage waterPage)
        {
            _wp = waterPage;

            ObservableCollection<string> collection;

            switch (waterOperationType)
            {
                case WaterOperationType.TotalAmount:
                    {
                        collection = new ObservableCollection<string>() { "1000", "1050", "1100", "1150", "1200", "1250", "1300", "1350", "1400", "1450", "1500", "1550", "1600", "1650",
                        "1700","1750","1800","1850","1900","1950","2000","2050","2100","2150","2200","2250","2300","2350","2400","2450","2500","2550","2600","2650","2700","2750","2800",
                            "2850","2900","2950","3000",};
                        BindingContext = new SetWaterPopupViewModel(this, collection, waterOperationType,_wp);
                        break; 
                    }
                case WaterOperationType.Capacity:
                    {
                        collection = new ObservableCollection<string>() { "50", "100", "150", "200", "250", "300", "350", "400", "450", "500" };
                        BindingContext = new SetWaterPopupViewModel(this, collection, waterOperationType,_wp);
                        break; 
                    }
            
            }
            InitializeComponent();
        }

    }
}