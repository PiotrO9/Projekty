using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Student___Teacher
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'am going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age);
        }
    }
}
