using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WrongLoginPopUp : Rg.Plugins.Popup.Pages.PopupPage
    {
        public WrongLoginPopUp()
        {
            InitializeComponent();
        }
    }
}