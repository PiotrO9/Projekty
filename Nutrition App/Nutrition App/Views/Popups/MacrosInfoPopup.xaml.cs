using Nutrition_App.ViewModels.PopupsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nutrition_App.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MacrosInfoPopup : Popup
    {
        public MacrosInfoPopup(string TextToDisplay)
        {
            InitializeComponent();
            BindingContext = new MacrosInfoPopupViewModel(TextToDisplay, this);
        }
    }
}