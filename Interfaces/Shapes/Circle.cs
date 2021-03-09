using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Engines
{
    public class Circle : ICalculateField, ICalculateCircuit
    {
        float pi = Convert.ToSingle(Math.Round(Math.PI, 2));
        public float radius { get; set; }

        public float CalculatingField()
        {
            return pi * radius * radius;
        }
        public float CalculatingCircuit()
        {
            return 2 * pi * radius;
        }

        public Circle(float r)
        {
            radius = r;
        }
    }
}
