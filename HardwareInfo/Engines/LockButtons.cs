using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HardwareInfo.Engines
{
    public class LockButtons
    {
        private MainWindow _mw;

        public LockButtons(MainWindow mw)
        {
            _mw = mw;
        }

        public void LockButtonsMehod()
        {
            GetButtons gb = new GetButtons(_mw);

            List<Button> ButtonsList = gb.GetButtonsMethod();

            foreach (var button in ButtonsList)
            {
                button.IsEnabled = false;
            }
        }
    }
}
