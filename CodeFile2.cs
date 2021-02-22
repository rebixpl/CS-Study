using System;
using System.Collections.Generic;
using System.Text;

namespace cs_tutorial_1
{
    class TutorialMethods
    {
        private static void Example2(string[] args)
        {
            //---------- C# METHODS---------------------------------------
            MyMethod(); // Call a Method
            MyMethod();
            Console.WriteLine();
            MyMethod2(fname: "Daniel"); // Named Arguments key:value
            MyMethod2("Mike"); // "Mike" is a argument. When a parameter is passed to the method, it is called an argument.
            Console.WriteLine();
            MyMethod3("USA");
            MyMethod3(); // uses default parameter "Nigeria"
            Console.WriteLine();
            MyMethod4("Obama", 666);
            Console.WriteLine(MyMethod5(4)); // 4 + 5 = 9
            int resultFunc6 = MyMethod6(5, 3); // store the result in a variable
            Console.WriteLine(resultFunc6); // OUTPUT: 8
            Console.WriteLine();
            MyMethod7(child3: "John", child1: "Liam", child2: "Liam"); // the order of the arguments does not matter
            Console.WriteLine();

            //---------- C# METHOD OVERLOADING ----------------------------
            // With method overloading, multiple methods can have the same name with different parameters:
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

        private static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        private static double PlusMethod(double x, double y) // method overloading
        {
            return x + y;
        }

        private static void MyMethod()
        // void means that this method does not have a return value.
        // static means that the method belongs to the Program class and not an object of the Program class.
        {
            Console.WriteLine("I just got executed!");
        }

        private static void MyMethod2(string fname) // Parameters and Arguments
        { // fname is a parameter
            Console.WriteLine(fname + " Magiczny");
        }

        private static void MyMethod3(string country = "Nigeria") // "=" to use a default Parameter Value
        {
            Console.WriteLine(country);
        }

        private static void MyMethod4(string fname, int age) // Multiple Parameters
        {
            Console.WriteLine(fname + " is " + age);
        }

        private static int MyMethod5(int x) // Return Values
        {
            return x + 5;
        }

        private static int MyMethod6(int x, int y)
        {
            return x + y;
        }

        private static void MyMethod7(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
    }
}
