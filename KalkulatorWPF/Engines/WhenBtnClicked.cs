using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KalkulatorWPF.Engines
{
    public class WhenBtnClicked
    {
        public string MainText { get; set; }

        public WhenBtnClicked(string s, Button button)
        {
            this.MainText = s;

            string temp = button.Content.ToString();

            MainText += temp;
        }


    }

}
