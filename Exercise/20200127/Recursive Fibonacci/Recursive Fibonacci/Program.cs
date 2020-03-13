using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
    class Program
    {
        public static void FibonacciRecursive(decimal firstnumber, decimal secondnumber, int counter, int length)
        {
            if (counter <= length)
            {
                Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
                decimal phi = secondnumber / firstnumber;
                Console.WriteLine($"phi = {phi}");
                FibonacciRecursive(secondnumber, firstnumber + secondnumber, counter + 1, length);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            FibonacciRecursive(1, 1, 1, length);
            Console.ReadKey();
        }
    }
}
