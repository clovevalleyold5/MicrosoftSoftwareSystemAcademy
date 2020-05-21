using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] n1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evennumber = n1.Where(n1 => n1 % 2 == 0);
            foreach (int e in evennumber)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            int[] n2 = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            IEnumerable<int> onetoeleven = n2.Where(n2 => n2 >= 1 && n2 <= 11);
            foreach (int o in onetoeleven)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            IEnumerable<int> squares = arr1.Where(arr1 => arr1 * arr1 >= 20).Select(arr1 => arr1 * arr1);
            foreach (int s in squares)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            var arr2 = new[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            IEnumerable<int> numberofdistinctnumber = arr2.Distinct();
            foreach (int n in numberofdistinctnumber)
            {
                Console.WriteLine(n);
            }
        }
    }
}
