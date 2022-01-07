using Nutrition_App.Enums;
using Nutrition_App.Views;
using Nutrition_App.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    class WaterPageViewModel : BaseViewModel
    {
        private WaterPage _wp { get; set; }

        public WaterPageViewModel(WaterPage waterPage)
        {
            _wp = waterPage;

            GlassCapacityClick = new Command(GlassCapacityClickImpl);
            WaterAmountClick = new Command(WaterAmountClickImpl);
        }

        #region Commands

        public Command GlassCapacityClick { get; }
        public Command WaterAmountClick { get; }

        #endregion

        #region Commands implementations

        public void GlassCapacityClickImpl()
        {
            WaterOperationType waterOperationType = WaterOperationType.Capacity;
            _wp.Navigation.ShowPopup(new SetWaterPopup(waterOperationType,_wp));
        }
        public void WaterAmountClickImpl()
        {
            WaterOperationType waterOperationType = WaterOperationType.TotalAmount;
            _wp.Navigation.ShowPopup(new SetWaterPopup(waterOperationType,_wp));
        }

        #endregion

    }
}
