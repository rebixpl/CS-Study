using System;
using System.Collections.Generic;
using System.Text;

namespace cs_tutorial_1
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car7 : Vehicle // derived class (child)
    {
        public string modelName = "Mustang";
    }

    // If you don't want other classes to inherit from a class, 
    // use the "sealed" keyword:
    sealed class TestSealBase { }
    // class TestSealChild : TestSealBase { } // ERROR: TestSealBase is 'sealed', so it can't be used in inheritance
}
