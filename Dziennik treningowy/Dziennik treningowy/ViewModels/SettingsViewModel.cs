using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class SettingsViewModel
    {
        public SettingsViewModel()
        {
            OneRepCalculatorClick = new Command(OneRepCalculatorClickImpl);
            ClearHistoryClick = new Command(ClearHistoryClickImpl);
        }

        public Command OneRepCalculatorClick { get; }
        public Command ClearHistoryClick { get; }

        public async void OneRepCalculatorClickImpl()
        {
            await Shell.Current.GoToAsync(nameof(OneRepPage));
        }

        public void ClearHistoryClickImpl()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves";
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
