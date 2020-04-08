using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace MathGames
{
    internal class Calculate
    {
        public static (int choice, int numberofproblems) Initialize()
        {
            Console.Write("to add<1>, to substract<2>, to multiply<3>, to divide<4>, to exit<0>: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("how many question (1 to 12): ");
            int numberofproblems = int.Parse(Console.ReadLine());
            return (choice, numberofproblems);
        }

        internal static int Add(int numberofproblem)
        {
            Console.WriteLine("add; " + numberofproblem + "question(s)");
            int score = 0;
            for (int i = 1; i <= numberofproblem; i++)
            {
                Random r = new Random();
                int n1 = r.Next(0, 10);
                int n2 = r.Next(0, 10);
                int result = n1 + n2;
                Console.Write(i + ", " + n1 + " + " + n2 + " = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    score++;
                    Console.WriteLine("right, answer is " + result);
                }
                else
                {
                    Console.WriteLine("wrong, should be " + result);
                }
            }
            return score;
        }
        internal static int Substract(int numberofproblem)
        {
            Console.WriteLine("substract; " + numberofproblem + " question(s)");
            int score = 0;
            for (int i = 1; i <= numberofproblem; i++)
            {
                Random r = new Random();
                int n1 = r.Next(0, 10);
                int n2 = r.Next(0, 10);
                int result = n1 - n2;
                Console.Write(i + ", " + n1 + " - " + n2 + " = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    score++;
                    Console.WriteLine("right, answer is " + result);
                }
                else
                {
                    Console.WriteLine("wrong, answer is " + result);
                }
            }
            return score;
        }
        internal static int Multiply(int numberofproblem)
        {
            Console.WriteLine("multiply; " + numberofproblem + " question(s)");
            int score = 0;
            for (int i = 1; i <= numberofproblem; i++)
            {
                Random r = new Random();
                int n1 = r.Next(0, 10);
                int n2 = r.Next(0, 10);
                int result = n1 * n2;
                Console.Write(i + ", " + n1 + " * " + n2 + " = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    score++;
                    Console.WriteLine("right, answer is " + result);
                }
                else
                {
                    Console.WriteLine("wrong, answer is " + result);
                }
            }
            return score;
        }
        internal static int Divide(int numberofproblem)
        {
            Console.WriteLine("divide; " + numberofproblem + " question(s)");
            int score = 0;
            for (int i = 1; i <= numberofproblem; i++)
            {
                Random r = new Random();
                int n1 = r.Next(0, 10);
                int n2 = r.Next(1, 10);
                double result = (double)n1 / (double)n2;
                Console.Write(i + ", " + n1 + " / " + n2 + " = ");
                double answer = double.Parse(Console.ReadLine());
                if (Math.Abs(answer - result) <= 0.01)
                {
                    score++;
                    Console.WriteLine("right, answer is " + result);
                }
                else
                {
                    Console.WriteLine("wrong, answer is " + result);
                }
            }
            return score;
        }
        internal static string Report(int score, int numberofproblems)
        {
            double result = (double)score / (double)numberofproblems * 100;
            int grade = (int)result;
            string report = "your score is " + grade;
            return report;
        }
    }
}