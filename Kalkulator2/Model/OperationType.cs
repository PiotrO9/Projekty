using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    public enum OperationType
    {
        [Description("+")]
        Plus,
        [Description("-")]
        Minus,
        [Description("*")]
        Multiplication,
        [Description("/")]
        Divide,
    }
}
