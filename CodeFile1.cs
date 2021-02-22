using System; // we can use classes from the System namespace.
using System.Linq; // Min, Max, and Sum, can be found in the System.Linq namespace

namespace tutorial_part_1 // namespace is a container for classes and other namespaces
{
    internal class TutorialPart1 // class is a container for data and methods,  Every line of code that runs in C# must be inside a class.
    {
        private static void Example(string[] args)
        {
            //------C# ARRAYS ------------------------------------------
            // Arrays are used to store multiple values in a single variable, 
            // instead of declaring separate variables for each value.

            int[] myNumArr = { 10, 20, 30, 40 };
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("cars2[1] = " + cars2[1]); // You access an array element by referring to the index number.
                                                         // Change an Array Element
            cars2[0] = "Opel";
            Console.WriteLine("cars2[0] = " + cars2[0]);
            // Array Length
            Console.WriteLine("cars2 length: " + cars2.Length);
            Console.WriteLine();

            // Loop Through an Array with for
            for (int i = 0; i < cars2.Length; i++)
            {
                Console.Write(cars2[i] + " ");
            }
            Console.WriteLine();

            // Loop Through an Array with foreach
            foreach (string car in cars2)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine();

            // Sort Arrays
            // Sort() -> sorts an array alphabetically or in an ascending order
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars3);
            foreach (string car in cars3)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine();

            int[] numbersArr = { 1, 5, 2, 7, 3, 4, 8, 6, 10, 9, 13, 11, 12 };
            Console.Write("unsorted: ");
            foreach (int num in numbersArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("sorted: ");
            Array.Sort(numbersArr); // sort the array
            foreach (int num in numbersArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // System.Linq Namespace
            // Min, Max, and Sum, can be found in the System.Linq namespace
            int[] numbersArr2 = { 1, 5, 2, 7, 3, 4, 8, 6, 10, 9, 13, 11, 12 };
            Console.WriteLine("max value of array: " + numbersArr2.Max());
            Console.WriteLine("min value of array: " + numbersArr2.Min());
            Console.WriteLine("sum of array: " + numbersArr2.Sum());
            Console.WriteLine();

            // Other Ways to Create an Array
            // Declare an array
            string[] animals;
            // Add values, using new
            animals = new string[2] { "cat", "ape" };

            // Create an array of four elements, and add values later
            string[] cars4 = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars5 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars6 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            //------C# MATH------------------------------------------
            Console.WriteLine(Math.Max(5, 3)); // Math.Max(x,y) method can be used to find the highest value of x and y
            Console.WriteLine(Math.Min(64, 234)); // Math.Min(x,y) method can be used to find the lowest value of of x and y
            Console.WriteLine("sqrt of 81: " + Convert.ToString(Math.Sqrt(81))); // Math.Sqrt(x) method returns the square root of x
            Console.WriteLine(Math.Abs(-48.3)); // Math.Abs(x) method returns the absolute (positive) value of x
            Console.WriteLine(Math.Round(63.499497838945786745)); // Math.Round() rounds a number to the nearest whole number

            //------C# STRINGS ------------------------------------------
            // String Length
            string text = "jdfvohjdfgodhguifhgfighdfighdfuydfdufygdfyigjebacdisachujajfdihndfgidhfg";
            Console.WriteLine("Length of text: " + text.Length);

            // ToUpper() and ToLower()
            string text2 = "Hello World!";
            Console.WriteLine(text2.ToLower());
            Console.WriteLine(text2.ToUpper());
            Console.WriteLine();

            // String Concatenation
            string one = "1 ";
            string two = "2";
            string result = one + two; // you can combine strings with '+'
            Console.WriteLine(result);
            Console.WriteLine();

            string result2 = string.Concat(one, two); // you can combine strings with string.Concat() method
            Console.WriteLine(result2);
            Console.WriteLine();

            // String Interpolation
            string name1 = "Daniel";
            string name2 = "Magiczny";
            string fullName = $"Hello, I am {name1} {name2}";
            Console.WriteLine(fullName);

            // Access Strings
            string text3 = "Magical";
            Console.WriteLine(text3[3]); // Outputs "i"
            Console.WriteLine();

            // You can also find the index position of a specific character in a string,
            // by using the IndexOf() method:
            Console.WriteLine(text3.IndexOf("a")); // OUTPUT: 1
            Console.WriteLine();

            // Substring() -> extracts the characters from a string, starting from
            // the specified character position/index, and returns a new string.
            string myName = "John Doe";
            int charPos = myName.IndexOf('D'); // Location of the letter D
            string mylastName = myName.Substring(charPos); // Get Last name
            Console.WriteLine("my lastname is: " + mylastName); // print the results

            //------C# BOOLEANS ------------------------------------------
            Console.WriteLine(10 > 24); // output: False
            int x2 = 43;
            Console.WriteLine(x2 == 43); // output: True
            Console.WriteLine();

            //------C# If .... Else ------------------------------------------
            int x3 = 20;
            int y3 = 16;
            if (x3 > y3)
            {
                Console.WriteLine("x3 is greater than y3");
            }

            int time = 20;
            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

            // Short Hand If...Else (Ternary Operator)
            // SYNTAX: variable = (condition) ? expressionTrue :  expressionFalse;
            int time2 = 20;
            string result3 = (time2 < 18) ? "Good Day" : "Good evening";
            Console.WriteLine(result3);
            Console.WriteLine();

            //------C# Switch---------------------------------------------------
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            //------C# While Loop---------------------------------------------------
            // The while loop loops through a block of code as long as a specified condition is True:
            int meinInt = 0;
            while (meinInt < 5)
            {
                Console.WriteLine(meinInt + 1);
                meinInt++;
            }
            Console.WriteLine();

            // The Do/While Loop
            // The do/while loop is a variant of the while loop. This loop will
            // execute the code block once, before checking if the condition is true,
            // then it will repeat the loop as long as the condition is true.
            meinInt = 0;
            do
            {
                Console.WriteLine(meinInt + 1);
                meinInt++;
            } while (meinInt < 5);
            Console.WriteLine();

            //------C# FOR LOOP------------------------------------------
            // for (statement 1; statement 2; statement 3) 
            //  Statement 1 is executed(one time) before the execution of the code block.
            //  Statement 2 defines the condition for executing the code block.
            //  Statement 3 is executed(every time) after the code block has been executed.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine();

            // The foreach Loop
            // foreach loop - is used exclusively to loop through elements in an array:
            // foreach (type variableName in arrayName) 
            string[] cars = { "Volvo", "BMW", "Ford", "Toyota" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //------ C# Break and Continue -------------------------------------
            // BREAK -> The break statement can also be used to jump out of a loop.
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i + 1);
            }
            Console.WriteLine();

            // CONTINUE -> The continue statement breaks one iteration (in the loop), if a specified condition occurs, 
            // and continues with the next iteration in the loop.
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i + 1);
            }
            Console.WriteLine();


            //------WRITING TO CONSOLE------------------------------------------
            // WriteLine() prints the output on a new line each time
            Console.WriteLine("Hello World!");
            /* Console is a class of the System namespace,
             which has a WriteLine() method that is used to output/print text. */

            // Write() prints on the same line
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line!");
            Console.WriteLine("");

            //------VARIABLES------------------------------------------
            // int - stores whole numbers (integers)
            // double - stores floating point numbers with decimals
            // char - stores single characters like 'a'
            // string - stores text
            // bool - stores true or false

            string name = "Jeff";
            int myNum = 18;
            int myNum2;
            Console.WriteLine(name);
            Console.WriteLine(myNum);
            myNum2 = 422;
            Console.WriteLine(myNum2);
            const int myNum3 = 23;
            //myNum3 = 21; // you cannot change const values
            Console.WriteLine("myNum3 = " + myNum3);

            int x = 7;
            int y = 93;
            int add_sum = x + y;
            Console.WriteLine(add_sum);

            // Declare Many Variables
            int v1 = 5, v2 = 6, v3 = 70;
            Console.WriteLine(v1 + v2 + v3);

            //------INTEGER TYPES------------------------------------------
            // int -> The int data type can store whole numbers from -2147483648 to 2147483647.
            // long -> The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807.
            long myLongNum = 15000000000L; // long should end the value with an "L"
            Console.WriteLine(myLongNum);

            //------FLOATING POINT TYPES------------------------------------------
            // float -> The float data type can store fractional numbers from 3.4e−038 to 3.4e+038.
            float myFloatNum = 5.75F; // float should end the value with an "F"
            Console.WriteLine(myFloatNum);

            // double -> The double data type can store fractional numbers from 1.7e−308 to 1.7e+308.
            double myDoubleNum = 19.99D;
            Console.WriteLine(myDoubleNum);

            // The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //------ BOOLEANS------------------------------------------
            bool amIGay = false;
            Console.WriteLine(amIGay);

            // Chars
            char myGrade = 'B';
            Console.WriteLine(myGrade);

            // Strings
            string welcome = "Welcome prince X";
            Console.WriteLine(welcome);

            //------TYPE CASTING------------------------------------------
            // Implicit casting is done automatically
            int mInt = 55;
            double mDouble = mInt; // Automatic casting: int to double
            Console.WriteLine(mInt);
            Console.WriteLine(mDouble);

            // Explicit casting is done manually
            double mDouble2 = 6.42;
            int mInt2 = (int)mDouble2; // Manual casting: double to int
            Console.WriteLine(mDouble2);
            Console.WriteLine(mInt2);
            Console.WriteLine();

            // Converting with Type Conversion Methods
            int mInt3 = 14;
            double mDouble3 = 4.2;
            bool mBool = true;
            Console.WriteLine(Convert.ToString(mInt3)); // int to string
            Console.WriteLine(Convert.ToDouble(mInt3)); // int to double
            Console.WriteLine(Convert.ToInt32(mDouble3)); // double to int
            Console.WriteLine(Convert.ToString(mBool)); // bool to string
            Console.WriteLine();

            //------USER INPUT------------------------------------------
            Console.Write("Enter your username: ");

            // Get user input and store it inside string
            string username = Console.ReadLine();

            Console.WriteLine("Welcome, " + username);

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + userAge);
        }
    }
}

