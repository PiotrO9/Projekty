using KalkulatorWPF.ViewModels.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KalkulatorWPF.ViewModels
{
    public class ButtonClickViewModel
    {



        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new ButtonClickComand(() => MyAction(), () => CanExecute));
            }
        }

        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public void MyAction()
        {

        }

    }
}
