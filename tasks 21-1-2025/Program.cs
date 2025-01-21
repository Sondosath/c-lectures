using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace tasks_21_1_2025
{
    internal class Program
    {
        class student
        {
            public string name { get; set; }
            public int age { get; set; }
            public int StudentID { get; set; }
            public string Email { get; set; }
            private const int MinAge = 18;
            private const int MaxAge = 40;

            public void GetDetails()
            {
                Console.WriteLine("name : " + name + "age: " + age + "Id: " + StudentID);
            }
            public student(string name, int age, int studentID)
            {
                this.name = name;
                this.age = age;
                StudentID = studentID;
               
            }
            public student() {
                name = " ";
                age = 18;
                StudentID = 1;

            }
            ~student() {
                Console.WriteLine("bye bye ");
            }
        }

        //Questions :
        //1-	What is class :
        //templete or blueprint 
        //
        //2-	What is object :
        //instance of class
        //
        //3-	Difference between class && object :
        //the class is the templete while we make the object from
        //
        //4-	Mention the OOP Principles  :
        //Abstraction , Encapsulation , Polymorphism ,Inheritance
        //
        //5-	What is property :
        //  re members of a class that provide a flexible way to read, write, or compute the value of a private field. Auto properties are a shorthand way to define properties without explicitly defining a backing field. 
        //
        //6-	What is field :
        //Fields are variables declared directly inside a class(data ) also Fields are typically private to encapsulate the data and prevent direct access from outside the class.
        //
        //7-	What is constructor :
        //buildin method that created by defult once the object created to initailize the data
        //
        //8-	What is encapsulation :
        //make the data in objects private so we reach to them by other methods in the class to give the code more security , its like we have a capsole so no one see whats inside it , they only know the result of it






        static void Main(string[] args)
        {
            student Ahmad = new student();
            Ahmad.name = "Ahmad";
            Ahmad.age = 22;
            Ahmad.StudentID = 1001;
            Ahmad.GetDetails();

            student Sondos = new student("Sondos",24,132955);
            Sondos.GetDetails();
            student Sarah = new student("Sarah",23,101010);
            Sondos.GetDetails();


        }
    }
}
