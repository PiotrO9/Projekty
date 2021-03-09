using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Shapes
{
    public class Triangle : ICalculateField, ICalculateCircuit
    {

        public float A { get; set; }

        public float H { get; set; }

        public float CalculatingCircuit()
        {
            return 0;
        }

        public float CalculatingField()
        {
            return (A * H) / 2;
        }

        public Triangle(float a, float h)
        {
            this.A = a;
            this.H = h;
        }
    }
}
