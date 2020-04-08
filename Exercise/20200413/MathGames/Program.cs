using System;

namespace MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int choice = 0;
            int numberofproblems = 0;
            int score = 0;
            (choice, numberofproblems) = Calculate.Initialize();
            if (choice == 1)
            {
                score = Calculate.Add(numberofproblems);
            }
            else if (choice == 2)
            {
                score = Calculate.Substract(numberofproblems);
            }
            else if (choice == 3)
            {
                score = Calculate.Multiply(numberofproblems);
            }
            else if (choice == 4)
            {
                score = Calculate.Divide(numberofproblems);
            }
            else
            {
                Console.WriteLine("wrong input");
                Environment.Exit(0);
            }
            string report = Calculate.Report(score, numberofproblems);
            Console.WriteLine(report);
        }
    }
}
