using Dziennik_treningowy.Services;
using Dziennik_treningowy.ViewModels;
using Dziennik_treningowy.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell(this);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
