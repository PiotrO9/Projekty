using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class SettingsViewModel
    {
        public SettingsViewModel()
        {
            OneRepCalculatorClick = new Command(OneRepCalculatorClickImpl);
        }

        public Command OneRepCalculatorClick { get; }

        public async void OneRepCalculatorClickImpl()
        {
           await Shell.Current.GoToAsync(nameof(OneRepPage));
        }
    }
}
