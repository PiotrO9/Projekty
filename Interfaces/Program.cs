using Interfaces.Engines;
using Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle: ");
            float r = float.Parse(Console.ReadLine());

            Circle cf = new Circle(r);

            Console.WriteLine(cf.CalculatingField().ToString());
            Console.WriteLine(cf.CalculatingCircuit().ToString());

            Console.WriteLine("Square");

            float d = float.Parse(Console.ReadLine());

            Square s = new Square(d);
            Console.WriteLine(s.CalculatingField().ToString());

            Console.WriteLine();

            Console.WriteLine("Rectangle: ");
            Console.WriteLine("A: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("B: ");
            float b = float.Parse(Console.ReadLine());

            Rectangle rec = new Rectangle(a, b);

            Console.WriteLine(rec.CalculatingField().ToString());
            Console.WriteLine(rec.CalculatingField().ToString());

            Console.WriteLine("Triangle");

            Console.WriteLine("A");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("H");
            float h = float.Parse(Console.ReadLine());

            Triangle t = new Triangle(c, h);

            Console.WriteLine(t.CalculatingField().ToString());

            Console.ReadKey();
        }
    }
}
