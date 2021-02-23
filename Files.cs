using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // include the System.IO namespace to use "File" class

namespace cs_tutorial_1
{
    public class FilesClass
    {
        string writeText = "Pan kiedyś stanął nad brzegiem, Szukał ludzi gotowych pójść za Nim; By łowić serca Słów Bożych prawdą.";

        public void Files()
        {
            // AppendText()	-> Appends text at the end of an existing file
            // Copy() -> Copies a file
            // Create()  ->  Creates or overwrites a file
            // Delete()  ->  Deletes a file
            // Exists()  ->  Tests whether the file exists
            // ReadAllText() ->  Reads the contents of a file
            // Replace()   Replaces the contents of a file with the contents of another file
            // WriteAllText()  Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
            
            File.WriteAllText("filename.txt", writeText); // Create a file and write the content of writeText to it

            for (int i = 0; i > 6; i++)
            {
                File.WriteAllText("filename" + Convert.ToString(i) + ".txt", writeText);
            }

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText);
        }

        
    }

}
