﻿using System; // we can use classes from the System namespace.

namespace cs_tutorial_1 // namespace is a container for classes and other namespaces
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            //---------- C# Classes and Objects ---------------------------------------
            // Create an Object
            Car myObj = new Car();
            Console.WriteLine(myObj.Color);

            // Multiple Objects
            Car myObj2 = new Car();
            Car myObj3 = new Car();
            Console.WriteLine(myObj2.Color);
            Console.WriteLine(myObj3.Color);
            Console.WriteLine();

            //------------- C# Class Members --------------------------
            Car2 car2obj = new Car2();
            Console.WriteLine(car2obj.color);
            Console.WriteLine(car2obj.maxSpeed);
            car2obj.color = "black";
            Console.WriteLine(car2obj.color);
            car2obj.fullThrottle();
            Console.WriteLine();

            // Car example
            Car3 Ford = new Car3();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car3 Opel = new Car3();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine();

            //---------------- C# Constructors -------------------------
            // Constructor is called when an object of a class is created.
            Car4 Ford2 = new Car4(); // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford2.model);

            // Constructor Parameters
            Car5 Ford3 = new Car5("Bigger Mustang", "Red", 1969);
            Console.WriteLine(Ford3.color + " " + Ford3.year + " " + Ford3.model);

            //---------------- C# Properties ------------------------------
            Person myPerson = new Person();
            myPerson.Name = "Mariusz";
            Console.WriteLine(myPerson.Name); // OUTPUT: Mariuszov

        }
    }
}