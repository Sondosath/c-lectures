using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks_20_1_2025
{
    internal class Program
    {

        //1-	Write a C# program that accepts an integer and determines if the
        //number is even or odd. Display the result.
        //•	Example Input: 7
        //•	Output: The number 7 is odd.
        static void oddOrEven(int number)
        {
            if (number %2 == 0)
            {
                Console.WriteLine(" The number "+number + "is even");
            }
            else
            {
                Console.WriteLine(" The number "+number + "is odd");

            }
        }


        //2-	Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
        static int smallest(int number1, int number2, int number3, int number4, int number5) {
            int smallest = number1;
            int [] arr  = new int [] {number1, number2, number3, number4, number5};
            for (int i = 0; i < 5; i++)
            {
                if (smallest > arr[i]) { 
                    smallest= arr[i];
                }
            }
            return smallest;
        
        }

        //3-Write a program that calculates the factorial of a given number using a for loop.
        static int facto(int number) {
            int facc = 1;
            for (int i = 1; i < number+1; i++) { 

                facc *= i;
            }
            return facc;
        
        }

        //4-Write a program that takes two integers as input and prints all the
        //prime numbers between them using nested loops.

        static void prime(int number11, int number22)
        {


            for (int i = number11; i < number22 + 1; i++)
            {
                bool isPrime = true; 
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false; 
                        break; 
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //5-Create a program that initializes an integer array and finds the largest
        //number in it using a foreach loop.
        static int Greater(int[] numbers)
        {
            int largest = numbers[0]; 

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number; 
                }
            }

            return largest; 
        }

        static void numbersPattren(int n )
        {
            int count = 1;
            for(int i = 1; i < n; i++)
            {
                for ( int j = 0; j < i; j++)
                {
                    Console.Write(count);
                    count++;
                }
                Console.WriteLine();
            }
        }
        // Create a class (Class && Object)
        class HotelReservationSystem
        {
            public string roomNum;
            public string roomType;
            public string pricePerNight;
            public const string hotelName = "Grand Stay Hotel";
            public string isBooked;
        }

            


        static void Main(string[] args)
        {
            //Class && Object Task 

            //data for room1
            HotelReservationSystem Room1 = new HotelReservationSystem();
            Console.WriteLine("please Enter the Room number for your first room : ");
            Room1.roomNum = Console.ReadLine();
            Console.WriteLine("please Enter the Room  Type ( Single, Double, Suite) : ");
            Room1.roomType = Console.ReadLine();
            Console.WriteLine("please Enter the Room price Per Night : ");
            Room1.pricePerNight = Console.ReadLine();
            Console.WriteLine("please Enter if the Room isBooked or not  (yes or no ) :  ");
            Room1.isBooked = Console.ReadLine();



            //data for room2
            HotelReservationSystem Room2 = new HotelReservationSystem();
            Console.WriteLine("please Enter the Room number for your 2ed room : ");
            Room2.roomNum = Console.ReadLine();
            Console.WriteLine("please Enter the Room  Type ( Single, Double, Suite) : ");
            Room2.roomType = Console.ReadLine();
            Console.WriteLine("please Enter the Room price Per Night : ");
            Room2.pricePerNight = Console.ReadLine();
            Console.WriteLine("please Enter if the Room isBooked or not (yes or no ):  ");
            Room2.isBooked = Console.ReadLine();



            //printing the data for the rooms :

            Console.WriteLine("Hello you have 2 Rooms ,first one has a number : "+ Room1.roomNum+
                "   also the 2ed one has a number : " + Room2.roomNum + "   first one Type : "+ Room1.roomType +
                "   also the 2ed one Type : " + Room2.roomType + "   first one price Per Night " + Room1.pricePerNight + 
                "  2ed one price Per Night " + Room2.pricePerNight
                +"   is the room1 booked?"+ Room1.isBooked + "  what about the 2ed Room?" +Room2.isBooked);






            //function call Task 1 
            Console.WriteLine("********** Task 1 ***************");
            Console.WriteLine("Enter the number to know if it even or odd");
            string sNum = Console.ReadLine();
            int num = int.Parse(sNum);
            oddOrEven(num);



            //function call Task 2
            Console.WriteLine("********** Task 2 ***************");
            Console.WriteLine("Enter 5 numbers to know The smallest");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string SNunberr = Console.ReadLine();
                arr[i] = int.Parse(SNunberr);
            }
            Console.WriteLine("Tge smallest number is: " + smallest(arr[0], arr[1], arr[2], arr[3], arr[4]));




            //function call Task 3
            Console.WriteLine("********** Task 3 ***************");
            Console.WriteLine("Enter the number to calculates the factorial of it: ");
            string Sfac = Console.ReadLine();
            int facc = int.Parse(Sfac);
           Console.WriteLine(facto(facc));




            //function call Task 4
            Console.WriteLine("************ Task 4 *************");
            Console.WriteLine("Enter 2 numbers to know the prime numbers between them: ");
                string Snumber11 = Console.ReadLine();
                string Snumber22 = Console.ReadLine();
                int number1 = int.Parse(Snumber11);
                int number2 = int.Parse(Snumber22);
            Console.WriteLine("the prime numbers between these 2 numbers are : ");
            prime(number1,number2);


             //function call Task 5
             Console.WriteLine("************ Task 5 *************");
            //int[] numbers = { 3, 1, 4, 1, 5, 9 };

            Console.WriteLine("Enter 5 numbers to know The greatest");

            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string SNunberr = Console.ReadLine();
                arr2[i] = int.Parse(SNunberr);
            }
            int largestNumber = Greater(arr2);
            Console.WriteLine("the greatest number is :  " + largestNumber);


            //function call Task 6
            Console.WriteLine("************ Task 6 *************");
            Console.WriteLine("Numbers pattren , Enter the # of Rows: ");
            string SPat = Console.ReadLine();
            int n = int.Parse(SPat);
            numbersPattren(n);



            



        }
    }
}
