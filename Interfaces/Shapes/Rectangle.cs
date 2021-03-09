using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Engines
{
    public class Rectangle : ICalculateField, ICalculateCircuit
    {
        public float A { get; set; }
        public float B { get; set; }

        public float CalculatingCircuit()
        {
            return (2 * A) + (2 * B);
        }

        public float CalculatingField()
        {
            return A * B;
        }

        public Rectangle(float a, float b)
        {
            this.A = a;
            this.B = b;
        }
    }
}
