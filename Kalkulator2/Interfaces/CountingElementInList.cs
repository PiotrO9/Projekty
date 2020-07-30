using Kalkulator2.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2.Services
{
    interface ICountingElementInList
    {
        bool IsCalculatedOk { get; }

        string TextToDisplay { get; }

        int ResultCalculation { get; }



    }
}
