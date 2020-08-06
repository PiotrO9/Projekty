using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koło: ");
            var circle = new Circle(5);
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimeter());

            circle.SetRadious(4.78);
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimeter());


            Console.WriteLine("Prostokąt: ");
            var rectangle = new Rectangle(3.6, 6);
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimeter());

            rectangle.SetSides(3, 5.89);
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimeter());


            Console.WriteLine("Kwadrat: ");
            var square = new Square(3);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Perimeter());

            square.setSide(7.5);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Perimeter());

            Console.Read();
        }
    }
}
