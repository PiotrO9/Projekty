using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class RecordsPageViewModel : INotifyPropertyChanged
    {
        private string _entryString;
        public string EntryString
        {
            get { return _entryString; }
            set { _entryString = value; OnPropertyChanged(); }
        }

        public RecordsPageViewModel()
        {
            QuitCommand = new Command(QuitCommandImpl);
        }

        #region Commands
        public Command QuitCommand { get; }
        #endregion

        #region Impl
        public async void QuitCommandImpl()
        {
            await Xamarin.Essentials.SecureStorage.SetAsync("NoteToDisplay", EntryString);

            await Shell.Current.GoToAsync("..");
        }

        public async void FillEntryText()
        {
            EntryString = await Xamarin.Essentials.SecureStorage.GetAsync("NoteToDisplay");
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
