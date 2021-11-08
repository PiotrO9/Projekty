using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        private readonly App _app;

        public AppShell(App app)
        {
            InitializeComponent();
            _app = app;
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(NewTrainingPage), typeof(NewTrainingPage));
            Routing.RegisterRoute(nameof(PickExersisePage), typeof(PickExersisePage));
            Routing.RegisterRoute(nameof(OneRepPage), typeof(OneRepPage));
            Routing.RegisterRoute(nameof(RecordsPage), typeof(RecordsPage));
            Routing.RegisterRoute(nameof(TrainingDetail), typeof(TrainingDetail));
            Routing.RegisterRoute(nameof(TrainingRoutinePage), typeof(TrainingRoutinePage));
        }
    }
}