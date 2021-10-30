using Dziennik_treningowy.Views.Popups;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class ClearHistoryViewModel
    {
        private ClearHistoryPopup _chp { get; set; }

        public ClearHistoryViewModel(ClearHistoryPopup clearHistoryPopup)
        {
            _chp = clearHistoryPopup;
            ClearCommand = new Command(ClearCommandImpl);
            QuitCommand = new Command(QuitCommandImpl);
        }

        #region Commands
        public Command ClearCommand { get; }
        public Command QuitCommand { get; }
        #endregion

        #region Methods

        public void ClearCommandImpl()
        {
            ClearingMethod();
            _chp.Dismiss(null);
        }

        public void QuitCommandImpl()
        {
            _chp.Dismiss(null);
        }

        public void ClearingMethod()
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

    #endregion

}
}
