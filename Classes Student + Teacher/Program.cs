using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Student___Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person testPerson = new Person();

            testPerson.Greet();

            Console.WriteLine("----------------------");

            Student testStudent = new Student();
            testStudent.Greet();
            testStudent.SetAge(21);
            testStudent.ShowAge();

            Console.WriteLine("----------------------");

            Teacher testTeacher = new Teacher();
            testTeacher.SetAge(30);
            testTeacher.Greet();
            testTeacher.Explain();

            Console.ReadLine();
        }
    }
}
