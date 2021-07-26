using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HardwareInfo.Engines
{
    public class UnlockButtons
    {
        private MainWindow _mw;

        public UnlockButtons(MainWindow mw)
        {
            _mw = mw;
        }

        public void UnlockButtonsMehod()
        {
            GetButtons gb = new GetButtons(_mw);

            List<Button> ButtonsList = gb.GetButtonsMethod();

            foreach (var button in ButtonsList)
            {
                button.IsEnabled = true;
            }
        }

    }
}
