using System;

namespace Variables
{
    // Exercise 1 - Variable Declaration and Assignment
    class ProgramOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name, age, and height in cm.");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + name + ", you are " + age + " years old, and your height is " + height + " cm.");
        }
    }
