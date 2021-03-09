using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Shapes
{
    public class Square : ICalculateField, ICalculateCircuit
    {
        public float A { get; set; }

        public float CalculatingCircuit()
        {
            return 4 * A;
        }

        public float CalculatingField()
        {
            return A * A;
        }

        public Square(float a)
        {
            this.A = a;
        }
    }
}
