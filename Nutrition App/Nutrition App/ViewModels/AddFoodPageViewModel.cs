using Nutrition_App.Services.Scraping;
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
            Scraper scraper = new Scraper();
            List<List<string>> temp = new List<List<string>>();
            for (int i = 0; i < 50; i++)
            {
                List<string> vs = scraper.GetProducts(i + 1, "Ryż", 1);

                temp.Add(vs);
            }
        }

        #endregion

        #region



        #endregion

    }
}
