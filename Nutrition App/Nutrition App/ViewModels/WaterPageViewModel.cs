using Nutrition_App.Enums;
using Nutrition_App.Views;
using Nutrition_App.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class WaterPageViewModel : BaseViewModel
    {
        private WaterPage _wp { get; set; }

        public WaterPageViewModel(WaterPage waterPage)
        {
            _wp = waterPage;

            UpdateValuesToTexts();

            GlassCapacityClick = new Command(GlassCapacityClickImpl);
            WaterAmountClick = new Command(WaterAmountClickImpl);
        }

        #region Fields

        private string _waterTarget;

        public string WaterTarget
        {
            get { return _waterTarget; }
            set { _waterTarget = value; OnPropertyChanged(); }
        }

        private string _capacity;

        public string Capacity
        {
            get { return _capacity; }
            set { _capacity = value; OnPropertyChanged(); }
        }

        #endregion

        #region Commands

        public Command GlassCapacityClick { get; }
        public Command WaterAmountClick { get; }

        #endregion

        #region Commands implementations

        public void GlassCapacityClickImpl()
        {
            WaterOperationType waterOperationType = WaterOperationType.Capacity;
            _wp.Navigation.ShowPopup(new SetWaterPopup(waterOperationType, this));
        }
        public void WaterAmountClickImpl()
        {
            WaterOperationType waterOperationType = WaterOperationType.TotalAmount;
            _wp.Navigation.ShowPopup(new SetWaterPopup(waterOperationType, this));
        }

        #endregion

        #region Methods

        public void UpdateValuesToTexts()
        {
            WaterTarget = Preferences.Get("TotalWaterAmount", "0");
            Capacity = Preferences.Get("CapacityOfWater", "0");
        }

        #endregion

    }
}
