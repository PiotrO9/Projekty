using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF.Models
{
    public class AnyActionModel
    {
        public int IndexOfAction { get; set; }

        public char TypeOfAction { get; set; }

        public bool IsActionFound { get; set; }
    }
}
