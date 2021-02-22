using System;
using System.Collections.Generic;
using System.Text;

namespace cs_tutorial_1
{
    class Animal // base class
    {
        // the base class method overrides the derived class method, 
        // when they share the same name, so we make base class method 'virtual'
        // and derived class method 'override' to avoid this problem
        public virtual void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal // derived class
    {
        public override void animalSound() // we override the base class method 
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal // derived class
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    
}
