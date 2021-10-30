using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class HistoryViewModel : INotifyPropertyChanged
    {
        public List<string> SourceCollection { get; set; }

        public Object SelectedItem { get; set; }

        public HistoryViewModel()
        {
            SourceCollection = new List<string>();
            SetCollection();
        }


        #region Commands

        #endregion

        public void SetCollection()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves";
            string[] fileEntries = Directory.GetFiles(path);

            foreach (var file in fileEntries)
            {
               string temp = file.Remove(0, 82);
                string temp2 = temp.Remove((temp.Length - 4), 4);
                SourceCollection.Add(temp2);
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
