using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenation of three strings.
            string newString = "First string" + " " + "attaches to the second string" + " " + "which in-turn, attaches to the third string.";
            Console.WriteLine(newString);
            Console.WriteLine();

            string str = "this lower-case string has become upper-case.";

            // converts str to upper case 
            string upperResult = str.ToUpper();
            Console.WriteLine(upperResult);

            //In C#, the string type is immutable. It means a string cannot be changed once created.

            /*changing the initial string will create a new string object on the memory heap instead of 
             modifying an original string at the same memory address.*/

            /*This behavior would hinder the performance if the original string changed multiple times 
             by replacing, appending, removing, or inserting new strings in the original string.*/

            /*To solve this problem, C# introduced the StringBuilder in the System.Text namespace. 
            The StringBuilder doesn't create a new object in the memory but dynamically expands memory 
            to accommodate the modified string.*/

            //string builder that builds a paragraph of text one line at a time.

            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
                        
            // Append three lines of text to the paragraph.
            sb.AppendLine("This is the introductory line of the paragraph.");
            sb.AppendLine("This is the second line of the paragraph.");
            sb.AppendLine("This is the third line of the paragraph.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
