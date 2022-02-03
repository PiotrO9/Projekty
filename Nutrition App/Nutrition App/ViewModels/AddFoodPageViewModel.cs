using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    class AddFoodPageViewModel : BaseViewModel
    {
        public AddFoodPageViewModel()
        {
            SearchButtonClick = new Command(SearchButtonClickImpl);
        }

        # region Commands

        public Command SearchButtonClick { get; set; }

        #endregion

        #region Commands impl

        public void SearchButtonClickImpl()
        {

        }

        #endregion

        #region



        #endregion

    }
}
