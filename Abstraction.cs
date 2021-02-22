using System;
using System.Collections.Generic;
using System.Text;

namespace cs_tutorial_1
{
    // Abstract class 
    abstract class Animal2
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig2 : Animal2
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
