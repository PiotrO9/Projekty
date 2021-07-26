using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HardwareInfo.Engines
{
    public class GetButtons
    {
        public MainWindow _mw;

        public GetButtons(MainWindow mw)
        {
            _mw = mw;
        }   

        public List<Button> GetButtonsMethod()
        {
            List<Button> ButtonsList = new List<Button>();

            ButtonsList.Add(_mw.BiosButton);
            ButtonsList.Add(_mw.CpuButton);
            ButtonsList.Add(_mw.GpuButton);
            ButtonsList.Add(_mw.MemoryButton);
            ButtonsList.Add(_mw.OsButton);
            ButtonsList.Add(_mw.RAMButton);

            return ButtonsList;
        }
    }
}
