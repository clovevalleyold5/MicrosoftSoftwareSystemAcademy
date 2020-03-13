using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while(!validInput)
            {
                Console.Write("To calculate the reciprocal of an integer, enter a positive integer: ");
                try
                {
                    decimal input = uint.Parse(Console.ReadLine());
                    if(input != 0)
                    {
                        validInput = true;
                    }
                    decimal reciprocal = 1 / input;
                    //double reciprocal = Math.Pow(input, -1);
                    Console.Write($"The reciprocal is {reciprocal}");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a positive number.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
        }
    }
}
