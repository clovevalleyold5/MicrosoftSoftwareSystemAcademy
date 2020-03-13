using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Methods
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            sum = get_sum(start, end, sum);
            Console.WriteLine($"The sum is {sum}");
        }

        private static int get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"get_sum({start}, {end}, {sum})");
            start = start + 1;
            sum = sum + start;
            if (start < end)
                return (get_sum(start, end, sum));
            else
                return (sum);
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Assign letter grades.");
            Console.Write("What is your score: ");
            string strScore = Console.ReadLine();
            int intScore = int.Parse(strScore);
            if (intScore < 60)
                Console.Write("Your grade is F");
            else if (60 <= intScore && intScore < 70)
                Console.Write("Your grade is D");
            else if (70 <= intScore && intScore < 80)
                Console.Write("Your grade is C");
            else if (80 <= intScore && intScore < 90)
                Console.Write("Your grade is B");
            else if (90 <= intScore && intScore <= 100)
                Console.Write("Your grade is A");
            Console.ReadLine();

            Console.WriteLine("Average a specific number of scores.");
            int i, j, sum = 0, avg = 0;
            Console.Write("How many scores you want to compute: ");
            j = int.Parse(Console.ReadLine());
            int[] array = new int[j];
            Console.WriteLine("Enter the scores: ");
            for (i = 0; i < j; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < j; i++)
            {
                sum += array[i];
            }
            avg = sum / j;
            Console.WriteLine("Average is {0}", avg);
            if (avg < 60)
                Console.WriteLine("The average grade is F");
            else if (60 <= avg && avg < 70)
                Console.WriteLine("The average grade is D");
            else if (70 <= avg && avg < 80)
                Console.WriteLine("The average grade is C");
            else if (80 <= avg && avg < 90)
                Console.WriteLine("The average grade is B");
            else if (90 <= avg && avg <= 100)
                Console.WriteLine("The average grade is A");
            Console.ReadLine();
        }
    }
}
