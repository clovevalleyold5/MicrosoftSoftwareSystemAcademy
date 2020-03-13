using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection__Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers to add: ");
            int end = Int32.Parse(Console.ReadLine());
            int start = 1;
            int sum = 0;
            Console.WriteLine("The sum of 0 and 0 is 0");
            GetSum(start, end, sum);
            Console.ReadLine();
        }

        public static void GetSum(int start, int end, int sum)
        {
            if (start <= end)
            {
                Console.WriteLine($"The sum of {start} and {sum} is {start + sum}");
                sum = start + sum;
                start++;
                GetSum(start, end, sum);
            }

        }
    }
}
