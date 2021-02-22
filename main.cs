using System; // we can use classes from the System namespace.

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

            //---------------- C# Inheritance ---------------------------
            Car7 car7 = new Car7();

            // Call the honk() method (From the Vehicle class) on the car7 object
            car7.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car7 class
            Console.WriteLine(car7.brand + " " + car7.modelName);
            Console.WriteLine();

            //--------------- C# Polymorphism ------------------------------
            Animal myAnimal = new Animal(); // Create animal object
            Animal myPig = new Pig(); // create pig  object
            Animal myDog = new Dog(); // create dog object

            myAnimal.animalSound(); 
            myPig.animalSound(); 
            myDog.animalSound();

            //----------------- C# Abstraction ----------------------------- 
            // Abstract class -> is a restricted class that cannot be used to create 
            // objects (to access it, it must be inherited from another class).
            // 
            // Abstract method -> can only be used in an abstract class, and it does not 
            // have a body. The body is provided by the derived class (inherited from).
        }
    }
}