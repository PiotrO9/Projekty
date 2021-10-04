using Dziennik_treningowy.Models;
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
    public partial class TimerPopup : Popup
    {
        private TimerPopupViewModel _vm;

        private NewTrainingViewModel _newTrainingViewModel;

        private int _timeToElapse;

        public TimerPopup(NewTrainingPage newTrainingPage, NewTrainingViewModel newTrainingViewModel,int timetoelapse)
        {
            InitializeComponent();

            _timeToElapse = timetoelapse;
            _newTrainingViewModel = newTrainingViewModel;
            BindingContext = _vm = new TimerPopupViewModel(this,_newTrainingViewModel,timetoelapse);
        }
    }
}