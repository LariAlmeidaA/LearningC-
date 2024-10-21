using System;

namespace Variables
{

    //Exercise 4 - Type Conversion
    //Declare a double variable to store a decimal number and another int variable to convert that number to an integer.
    //Show the original value and the converted value.
    class ProgramThree
    {
        static void Main(string[] args)
        {
            double number = 3.19848947; // Não precisa do (double), pois 3.19848947 já é um double
            int numberCovert = (int)number; // Converte o número para int
            Console.WriteLine(numberCovert); // Imprime o valor convertido
        }
    }
}
