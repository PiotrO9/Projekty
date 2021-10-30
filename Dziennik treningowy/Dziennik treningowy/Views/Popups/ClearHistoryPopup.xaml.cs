using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClearHistoryPopup : Popup
    {
        public ClearHistoryPopup()
        {
            InitializeComponent();
            BindingContext = new ClearHistoryViewModel(this);
        }
    }
}