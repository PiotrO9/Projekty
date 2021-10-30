using Dziennik_treningowy.Views;
using Dziennik_treningowy.Views.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class SettingsViewModel
    {
        private SettingsPage _sp { get; set; }

        public SettingsViewModel(SettingsPage settingsPage)
        {
            _sp = settingsPage;
            OneRepCalculatorClick = new Command(OneRepCalculatorClickImpl);
            ClearHistoryClick = new Command(ClearHistoryClickImpl);
        }

        public Command OneRepCalculatorClick { get; }
        public Command ClearHistoryClick { get; }

        public async void OneRepCalculatorClickImpl()
        {
            await Shell.Current.GoToAsync(nameof(OneRepPage));
        }

        public async void ClearHistoryClickImpl()
        {
            _sp.Navigation.ShowPopup(new ClearHistoryPopup()
            {
                IsLightDismissEnabled = false
            });

        }
    }
}
