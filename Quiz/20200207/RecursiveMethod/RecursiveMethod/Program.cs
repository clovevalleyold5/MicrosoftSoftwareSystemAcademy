using System;

namespace RecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum the root from 1 to 10.");
            double i = 1;
            double sumOfRoot = 0;
            sumOfRoot = AddRoot(sumOfRoot, i);
            Console.WriteLine("Sum of the root is " + sumOfRoot);
        }

        private static double AddRoot(double sumOfRoot, double i)
        {
            if (i > 10)
                return sumOfRoot;
            else
                return AddRoot(sumOfRoot + Math.Sqrt(i), ++i);
        }
    }
}
