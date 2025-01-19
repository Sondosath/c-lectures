using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c__lectures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*************Task1******************
            string name;
            name = Console.ReadLine();
            Console.WriteLine(name);



            //**********Task2*********************

            double num = 222.252;
            string name2 = "Sondos";
            char n = 's';
            bool F = false;
            int num3 = 22;
            const double pi = 3.14;



            //***********Task3******************
            //3 - Define array with name car that hold more than 3
            //    kinds on cars, then print all the cars with the array length.

            string[] cars = new string[] { "BMW", "Tesla", "BYD" };



            //********Task4***********************
            //    4 - Write a program in C that reads a first name,
            //    Lastname and year of birth and display the names and the year one
            //    after another sequentially.Go to the editor
            //•	Input your firstname: Sami
            //•	Input your lastname: Ali
            //•	Input your year of birth: 1999
            //•	Sami Ali 1999

            string fName, lNAme , bYear;
            

            Console.WriteLine("Enter your firstname: ");
            fName = Console.ReadLine();

            Console.WriteLine("Enter your lastname: ");
            lNAme = Console.ReadLine(); 

            Console.WriteLine("Enter your year of birth: ");
            bYear = Console.ReadLine();

            Console.WriteLine(fName + lNAme + bYear);

            //**************Task5****************

            // 1 - Write a program in C # to store elements in an array and print it. 
            //•	Test Data :	
            //•	Input 10 elements in the array :
            //•	element - 0 : 1
            //•	element - 1 : 1
            //•	element - 2 : 2
            //•	.......
            //•	Expected Output :
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9

            Console.WriteLine("Input 10 elements in the array :");
            string[] num = new string[10];

            // Input 10 numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                num[i] = Console.ReadLine(); // Convert string to int
            }

            // Output the array
            Console.WriteLine("The elements in the array are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("element"+ i + num[i]);
            }



        }
    }
}
