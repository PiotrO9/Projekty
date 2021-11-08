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
    public partial class PickRoutinePopup : Popup
    {
        private PickedRoutineViewModel _vm;

        private PickRoutinePopup _pickRoutinePopup;

        public PickRoutinePopup()
        {
            InitializeComponent();
            _pickRoutinePopup = this;
            BindingContext = _vm = new PickedRoutineViewModel(_pickRoutinePopup);
        }
    }
}