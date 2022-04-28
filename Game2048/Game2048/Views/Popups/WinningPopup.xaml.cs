using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game2048.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinningPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public WinningPopup()
        {
            InitializeComponent();
        }
    }
}