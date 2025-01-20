using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_19_1_2025
{
    internal class Program
    {



        static double Converter(double n)
        {
            double Miles = n * 0.621371;
            return Miles;
        }

        static void minCalc(string h , string m)
        {
            Console.WriteLine("hours: ");
            h = Console.ReadLine();
            Console.WriteLine("minutes: ");
            m = Console.ReadLine();
            int intH = Convert.ToInt32(h);
            int intM = Convert.ToInt32(m);
            int total = intH * 60 + intM;
            Console.WriteLine("Total: " + total);
        }

        //**********************Task 8 ***************************
        //8-	Write a method that accepts minutes as input and calculates
        //the total number of hours and minutes.
        //•	Input: 546 minutes
        //•	Output: "9 Hours, 6 Minutes"


        static void hoursCalc( string m) {
           
            //Console.WriteLine("minutes: ");
            //m = Console.ReadLine();
            int h = 0;
            int intM = Convert.ToInt32(m);
            if (intM > 61) { 
                h = intM / 60;
                intM = intM- h *60; 

            }
            
            Console.WriteLine( h + " Hours: " + intM + " Minutes");

        }

        //Task9
        //9-	Compare Two Numbers
        //        Write a program that prints:
        //"Equal" if two numbers are the same.
        //"Greater" if the first is greater.
        //"Smaller" if the second is greater.
        //Use only comparison and ternary operators.
        //•	Input: 10, 20
        //•	Output: "Smaller"Sum of Digits
        //Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
        //Input: 123
        //Output: "Sum of digits: 6"

        static void Compare(string a, string b)
        {
            int number1 = Convert.ToInt32(a);
            int number2 = Convert.ToInt32(b);

            if (number1 == number2)
            {
                Console.WriteLine("Equal");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Greater");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Smaller");
            }


        }


        static void Main(string[] args)
        {
            Console.WriteLine("number1 : ");
            string number1 = Console.ReadLine();

            Console.WriteLine("number2 : ");
            string number2 = Console.ReadLine();
            Compare(number1,number2);



            Console.WriteLine("the total number of minutes");
            string min = Console.ReadLine();
            hoursCalc(min);

            //************************ Task1 *************************
            //1-Write a C# program that accepts a double input and converts it into an int.
            //Display both values.
            //•Example:
            //Input: 9.8
            //Output:
            //Double: 9.8
            //Converted Int: 9

            string num1 = Console.ReadLine();
            double dnum = Convert.ToDouble(num1);
            Console.WriteLine(Convert.ToInt32(dnum));



        //************************** Task2 *************************
            //2-Write a program that uses a Convert.ToString() method to convert a number
            //into a string and concatenate it with a sentence.
            //Example:
            //Input: 25
            //Output: "Your number is: 25"
            
            string age = Console.ReadLine();
            int age2 = Convert.ToInt32(age);
            string StrAge = Convert.ToString(age2);
            Console.WriteLine("Your number is: " + age2);



            //*************** Task 3 *********************

            //3-Create a string with a sentence. Use ToUpper() and ToLower()
            //to display the uppercase and lowercase versions of the string.
            //Input: "C# is fun!"
            //Output:
            //Uppercase: C# IS FUN!
            //Lowercase: c# is fun!
            Console.WriteLine("Enter a sentence ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Uppercase: "+ sentence.ToUpper());
            Console.WriteLine("Lowercase: "+ sentence.ToLower());


            //******************** Task 4 **********************
            //4-	Write a program that takes a user's full name as input and prints:
            //The first name.
            //The last name.
            //The length of the full name.
            //•	Example:
            //Input: "John Doe"
            //Output:
            //First Name: John
            //Last Name: Doe
            //Total Characters: 8

            Console.WriteLine("The first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine(" The last name: ");
            string lName = Console.ReadLine();
            string fullName = fName + lName;
            Console.WriteLine(" The first name:"+fName + "The last name: " + lName + "The length of the full name." + fullName.Length);


            //**********************Task 5 ********************
            //5-Write a program that accepts two integers and prints the smaller of the two.
            //Input: 5, 9
            //Output: "Smaller Number: 5"

            int numm1, numm2;
            Console.WriteLine("Enter your 1st number : ");
            string StrNumm1 = Console.ReadLine();
            Console.WriteLine("Enter your 2ed number : ");
            string StrNumm2 = Console.ReadLine();
            numm1 = Convert.ToInt32(StrNumm1);
            numm2 = Convert.ToInt32(StrNumm2);

            if (numm1 > numm2)
            {
                Console.WriteLine("Smaller Number: " + numm2);
            }
            else if (numm1 < numm2)
            {
                Console.WriteLine("Smaller Number: " + numm1);
            }



            //********************* Task 6 ***********************
            //Write a method that converts kilometers per hour to miles per hour.
            //Use this method in a program to convert and display the result.
            //Input: 15 km / h
            //Output: "9.320568 mph"

            //Converter(15);
            Console.WriteLine(Converter(15)+ "mph");


            //************************ Task 7 ********************
            //7-	Write a method that takes hours and minutes as input and returns
            //the total number of minutes.
            //Input: 5 hours, 37 minutes
            //Output: "Total: 337 minutes"

            minCalc("5", "37");



            //**************** Task 10 *************
            Console.WriteLine("enter the number to be reversed : ");
            string revNum = Console.ReadLine();
            int convRevnum = Convert.ToInt32(revNum);
            int ones = convRevnum / 100;
            int tens = convRevnum % 100;
            tens = tens / 10;
            int hands = convRevnum % 10;
            Console.WriteLine("The number reversed to be : " + hands + tens + ones);





            // ************* Task 11 *****************

            string numberr1 = Console.ReadLine();
            int numberr11 = int.Parse(numberr1);
            string numberr2 = Console.ReadLine();
            int numberr22 = int.Parse(numberr2);
            if (numberr11 % numberr22 != 0)
            {
                Console.WriteLine("not divisble");
            }
            else
            {
                Console.WriteLine("divisble");

            }

            // ************ Task 12 ******************
            //12-	Find the Middle Value
            Console.WriteLine("*********Find the Middle Value**********");
           string mid1 = Console.ReadLine();
            int mid11 = int.Parse(mid1);
            string mid2 = Console.ReadLine();
            int mid22 = int.Parse(mid2);
            string mid3 = Console.ReadLine();
            int mid33 = int.Parse(mid3);

            if (mid11 > mid22 && mid11 < mid33) {
                Console.WriteLine("The middle value is: " + mid11);
            }
            if (mid22 > mid11 && mid22 < mid33)
            {
                Console.WriteLine("The middle value is: " + mid22);
            }
            if (mid33 > mid11 && mid33 < mid22)
            {
                Console.WriteLine("The middle value is: " + mid33);
            }

























        }
    }
}
