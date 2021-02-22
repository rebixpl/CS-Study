using System;

namespace cs_tutorial_1
{
    // Create a class
    internal class Car
    {
        public string Color = "red"; // variable declared inside a class is called attribute
        // 'public' specifies that the color variable/field of Car is accessible for other classes as well, such as Program
    }

    class Car2
    {
        // Class members
        public string color = "red";
        public int maxSpeed = 200;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Car3
    {
        public string model;
        public string color;
        public int year;
    }

    class Car4
    {
        public string model;

        // Create a class constructor for the Car class
        // Note that the constructor name must match the class name,
        // and it cannot have a return type (like void or int).
        public Car4()
        {
            model = "Mustang";  // Set the initial value for model
        }
    }

    class Car5
    {
        public string model;
        public string color;
        public int year;

        public Car5(string modelName, string modelColor, int modelYear) // Create a class constructor with a parameters
        {
            model = modelName;  // Set the initial value for model
            color = modelColor;
            year = modelYear;
        }
    }
}