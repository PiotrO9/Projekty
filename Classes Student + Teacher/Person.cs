﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Student___Teacher
{
    class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int n)
        {
            age = n;
        }

    }

}