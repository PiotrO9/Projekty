using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF
{
    public class MainTextClass
    {
        public string MainText { get; set; }

        public void Clear()
        {
            MainText = string.Empty;
        }

        public MainTextClass()
        {
            MainText = "Same Text";
        }

    }
}
