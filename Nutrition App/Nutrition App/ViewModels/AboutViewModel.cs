using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<string> collection { get; set; } 

        public AboutViewModel()
        {
            Title = "Główna strona";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            collection = new ObservableCollection<string>()
            {
                "test",
                "Siemka"
            };
        }

        public ICommand OpenWebCommand { get; }
    }
}