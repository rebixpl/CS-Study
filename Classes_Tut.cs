namespace cs_tutorial_1
{
    internal class Person
    {
        private string name;  // field

        // The Name property is associated with the name field.
        // It is a good practice to use the same name for both
        // the property and the private field, but with an
        // uppercase first letter.
        public string Name // property
        {
            get { return name + "ov"; } // get method returns the value of the variable name.
            set { name = value; } // set method assigns a value to the name variable
        }
    }
}