using System;

namespace Variables
{
 
    // Exercise 2 - Arithmetic Operations with Variables
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers and choose one option for operations");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A - ADDITION, B - SUBTRACTION, C - DIVISION, D - MULTIPLICATION");
            char option = char.Parse(Console.ReadLine().ToUpper()); // Convertendo para maiúsculas para simplificar a comparação

            switch (option)
            {
                case 'A':
                    Console.WriteLine($"The addition is: {n1 + n2}");
                    break;

                case 'B':
                    Console.WriteLine($"The subtraction is: {n1 - n2}");
                    break;
                case 'C':
                    if (n2 != 0) // Verificando divisão por zero
                    {
                        Console.WriteLine($"The division is: {n1 / n2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                case 'D':
                    Console.WriteLine($"The multiplication is: {n1 * n2}");
                    break;
                default:
                    Console.WriteLine("This option does not exist.");
                    break;
            }
        }
    }
}
