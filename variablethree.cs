using System;

namespace Variables
{

    // Exercise 3 -Using Constants
    //Declare a constant called PI with the value 3.14159 and a variable to store the radius of a circle.
    //Calculate the area of the circle (area = PI * radius * radius) and display the result.
    class ProgramThree
    {
        static void Main(string[] args)
        {
            const double pi= 3.14159;
            Console.WriteLine("Write radius from circle");
            double radius = double.Parse(Console.ReadLine());


            Console.WriteLine("Area the circle is:" + pi*radius*radius);

        
        }
        }
    }

