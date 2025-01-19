

using System;
using System.Linq.Expressions;

namespace example_19_1_2025
{
    internal class Program
    {
       


        static void Main(string[] args)
        {


            ///*******************************
            ///1. String Interpolation
            //String interpolation allows you to include variables or
            //expressions directly in a string using $.


            string name = "Alice";
            int age = 25;

             //Using string interpolation
            string message = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(message);





            //***************************
            //2. Accessing Strings
            //You can access individual characters in a string using their index.

            //string text = "Hello";

            //// Accessing characters
            //char firstChar = text[0]; // 'H'
            //char thirdChar = text[2]; // 'l'

            //Console.WriteLine($"First character: {firstChar}");
            //Console.WriteLine($"Third character: {thirdChar}");






            //********************************
            //3. Special Characters
            // Special characters are used to represent things like new lines,
            // tabs, or quotes in strings.

            // Using special characters
            //string specialString = "Hello,\n\tThis is a \"special\" string with a backslash: \\";
            //Console.WriteLine(specialString);

            //Explanation:
            //\n: Inserts a new line.

            //\t: Inserts a tab.

            //\": Inserts a double quote.

            //\\: Inserts a backslash.







            //Combining Everything

            //string name = "Bob";
            //int age = 30;

            // String interpolation
            //string message = $"Hello, my name is {name} and I am {age} years old.\nHere are some details:";

            // Accessing characters
            //char firstLetter = name[0]; // 'B'

            // Special characters
            //string details = $"\t- First letter of name: {firstLetter}\n\t- Age: {age}";

            // Combine everything
            //Console.WriteLine(message);
            //Console.WriteLine(details);

        }

    }
}
