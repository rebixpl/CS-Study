using System;
using System.Collections.Generic;
using System.Text;

namespace cs_tutorial_1
{
    interface IAnimal
    {
        // By default, members of an interface are abstract and public.

        void animalSound(); // interface method (does not have a body)
        void run(); // interface method (does not have a body)
    }

    // To access the interface methods, the interface must be "implemented" 
    // (kinda like inherited) by another class. 

    // Pig "implements" the IAnimal interface
    class Pig3 : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

        public void run()
        {
            Console.WriteLine("Pig run as fast as it can");
        }
    }

    //------------- Multiple Interfaces-----------------------------------
    // C# does not support "multiple inheritance" (a class can only inherit from one base class). 
    // However, it can be achieved with interfaces, because the class can implement multiple 
    // interfaces. 
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}
