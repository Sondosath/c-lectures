using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_2025
{
    internal class Program
    {
        class Calculator
        {
            public void add(int num1 , int num2) { 
               Console.WriteLine( num1 + num2);
            }
            public void add(int num1, int num2 ,int num3)
            {
                Console.WriteLine(num1 + num2);
            }
            public void add(double num1, double num2)
            {
                Console.WriteLine(num1 + num2 );
            }
        }


        class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("lets Draw !! ");
            }
        }
        class Circle:Shape
        {
            public override void draw()
            {
                Console.WriteLine("lets Draw a Circle !! ");
            }
        }
        class Rectangle :Shape
        {
            public override void draw()
            {
                Console.WriteLine("lets Draw a Rectangle  !! ");
            }
        }

        abstract class Animal
        {
            public abstract void makeSound();

            public  void sleep()
            {
                Console.WriteLine("Animal is sleeping");
            }
        }
        class dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks.");
            }

        }
        class  Cat  : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows.");
            }

        }
        public interface IPlayable
        {
            void play();
            
        }
        public class Guitar : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        public class Piano  : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.add(2, 4);
            calculator.add(2, 4 ,5);
            calculator.add(2.1, 4.4);

            Shape C = new Circle();
            C.draw();
            Shape R = new Rectangle();
            R.draw();

            dog dog = new dog();
            dog.makeSound();
            Cat Cat = new Cat();    
            Cat.makeSound();

            Guitar guitar = new Guitar();
            guitar.play();
            Piano Piano = new Piano();
            Piano.play();
        }
    }
}
