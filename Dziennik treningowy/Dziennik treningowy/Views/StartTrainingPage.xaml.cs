using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartTrainingPage : ContentPage
    {
        private StartTrainingViewModel _vm;

        public StartTrainingPage()
        {
            InitializeComponent();
            BindingContext = _vm = new StartTrainingViewModel(this);
        }
    }
}