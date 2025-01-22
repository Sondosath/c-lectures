using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_2025
{
    internal class Program
    {
        public class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void Start()
            {
                Console.WriteLine("Vehicle is starting.");
                Console.WriteLine("Brand: " + Brand);
                Console.WriteLine("Model : " + Model);

            }
        }
        public class Car:Vehicle
        {
            public int NumberOfDoors  { get; set; }

        }


            static void Main(string[] args)
            {
            Vehicle v = new Vehicle();
            Car c = new Car();
            }
    }
}


//What is constructor
// method that created by defult once the object is created 
//What are the basic concepts of OOPs
// encapslation     inhertance     abstraction     
//What is the Encapsulation
//What is the sealed class
//What is the Inheritance concept

