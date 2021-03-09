using Interfaces2.Interfaces;
using Interfaces2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Classes
{
    public class SameClass
    {
        MyDelegate MyDel;

        public int A { get; set; }

        public int B { get; set; }

        ISameInterface MyInterface;

        public void testing()
        {
            ;
        }

        public SameClass(ISameInterface SomeInterface)
        {
            SomeInterface.A = A;
            SomeInterface.B = B;
        }
    }
}
