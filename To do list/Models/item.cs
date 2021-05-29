using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace To_do_list.Models
{
    class item : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        ///  <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>

        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public string Text { get; set; }

        public bool Statement { get; set; }

    }
}
