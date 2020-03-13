using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter Your Number: ");
            string[] rednumber = { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
            string[] blacknumber = { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
            string[] greennumber = { "0", "00" };
            string randomnumber = Console.ReadLine();
            int xminus4 = int.Parse(randomnumber) - 4;
            int xminus3 = int.Parse(randomnumber) - 3;
            int xminus2 = int.Parse(randomnumber) - 2;
            int xminus1 = int.Parse(randomnumber) - 1;
            int x = int.Parse(randomnumber);
            int xplus1 = int.Parse(randomnumber) + 1;
            int xplus2 = int.Parse(randomnumber) + 2;
            int xplus3 = int.Parse(randomnumber) + 3;
            int xplus4 = int.Parse(randomnumber) + 4;
            //part1
            Console.Write("Number: ");
            Console.WriteLine("Number " + randomnumber + ", Win");

            //part2
            Console.Write("Even or Odd: ");
            if (x % 2 == 0)
            {
                Console.WriteLine("Even, Win");
            }
            else if (x % 2 == 1)
            {
                Console.WriteLine("Odd, Win");
            }

            //part3
            Console.Write("Color: ");
            if (rednumber.Contains(randomnumber))
            {
                Console.WriteLine("Red, Win");
            }
            else if (blacknumber.Contains(randomnumber))
            {
                Console.WriteLine("Black, Win");
            }
            else if (greennumber.Contains(randomnumber))
            {
                Console.WriteLine("Green, Win");
            }

            //part4
            Console.Write("Low or High: ");
            if (x >= 1 && x <= 18)
            {
                Console.WriteLine("Low, Win");
            }
            else if (x >= 19 && x <= 36)
            {
                Console.WriteLine("High, Win");
            }

            //part5
            Console.Write("Dozens: ");
            if (x >= 1 && x <= 12)
            {
                Console.WriteLine("First 12, Win");
            }
            else if (x >= 13 && x <= 24)
            {
                Console.WriteLine("Second 12, Win");
            }
            else if (x >= 25 && x <= 36)
            {
                Console.WriteLine("Third 12, Win");
            }
            //for (int i = 0; i <= 2; i++)
            //{
            //    int j = i + 1;
            //    if (int.Parse(randomnumber) / 12 == i)
            //    {
            //        Console.WriteLine(j + " 12 Win");
            //    }
            //}

            //part6
            Console.Write("Columns: ");
            for (int i = 3; i >= 1; i--)
            {
                int j = 3 - i;
                if (x % 3 == j && x != 0)
                {
                    if (j == 0)
                    {
                        j += 3;
                    }
                    Console.WriteLine("Column " + j + ", Win");
                }
            }
            //if (int.Parse(randomnumber) % 3 == 1)
            //{
            //    Console.WriteLine("First Column Win");
            //}
            //else if (int.Parse(randomnumber) % 3 == 2)
            //{
            //    Console.WriteLine("Second Column Win");
            //}
            //else if (int.Parse(randomnumber) % 3 == 0)
            //{
            //    Console.WriteLine("Third Column Win");
            //}

            //part7
            Console.Write("Rows: ");
            for (int i = 1; i <= 12; i++)
            {
                if (((x + 2) / 3) == i)
                {
                    Console.WriteLine("Row " + i + ", Win");
                }
            }

            //part8
            Console.Write("Double Rows: ");
            for (int i = 1; i <= 12; i++)
            {
                int j = i + 1;
                int h = i - 1;
                if (((x + 2) / 3) == i)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Row " + i + "/Row " + j + ", Win");
                    }
                    else if (i == 12)
                    {
                        Console.WriteLine("Row " + h + "/Row " + i + ", Win");
                    }
                    else
                    {
                        Console.WriteLine("Row " + h + "/Row " + i + ", Row " + i + "/Row " + j + ", Win");
                    }
                }
            }

            //part9
            Console.Write("Splits: ");
            if (x % 3 == 1)
            {
                if (x == 1)
                {
                    Console.WriteLine(x + "/" + xplus1 + ", " +
                        x + "/" + xplus3 + ", Win");
                }
                else if (x == 34)
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        xminus1 + "/" + x + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        x + "/" + xplus1 + ", " +
                        x + "/" + xplus3 + ", Win");
                }
            }
            else if (x % 3 == 2)
            {
                if (x == 2)
                {
                    Console.WriteLine(xminus1 + "/" + x + ", " +
                        x + "/" + xplus1 + ", " +
                        x + "/" + xplus1 + ", Win");
                }
                else if (x == 35)
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        xminus1 + "/" + x + ", " +
                        x + "/" + xplus1 + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        xminus1 + "/" + x + ", " +
                        x + "/" + xplus1 + ", " +
                        x + "/" + xplus3 + ", Win");
                }
            }
            if (x % 3 == 0 && x != 0)
            {
                if (x == 3)
                {
                    Console.WriteLine(xminus1 + "/" + x + ", " +
                        x + "/" + xplus3 + ", Win");
                }
                else if (x == 36)
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        xminus1 + "/" + x + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus3 + "/" + x + ", " +
                        xminus1 + "/" + x + ", " +
                        x + "/" + xplus3 + ", Win");
                }
            }

            //part10
            Console.Write("Corners: " +
                "");
            if (x % 3 == 1)
            {
                if (x == 1)
                {
                    Console.WriteLine(x + "/" + xplus1 + "/" + xplus3 + "/" + xplus4 + ", Win");
                }
                else if (x == 34)
                {
                    Console.WriteLine(xminus3 + "/" + xminus2 + "/" + x + "/" + xplus1 + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus3 + "/" + xminus2 + "/" + x + "/" + xplus1 + ", " +
                        x + "/" + xplus1 + "/" + xplus3 + "/" + xplus4 + ", Win");
                }
            }
            else if (x % 3 == 2)
            {
                if (x == 2)
                {
                    Console.WriteLine(xminus1 + "/" + x + "/" + xplus2 + "/" + xplus3 + ", " +
                        x + "/" + xplus1 + "/" + xplus3 + "/" + xplus4 + ", Win");
                }
                else if (x == 35)
                {
                    Console.WriteLine(xminus4 + "/" + xminus3 + "/" + xminus1 + "/" + x + ", " +
                        xminus3 + "/" + xminus2 + "/" + x + "/" + xplus1 + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus4 + "/" + xminus3 + "/" + xminus1 + "/" + x + ", " +
                        xminus3 + "/" + xminus2 + "/" + x + "/" + xplus1 + ", " +
                        xminus1 + "/" + x + "/" + xplus2 + "/" + xplus3 + ", " +
                        x + "/" + xplus1 + "/" + xplus3 + "/" + xplus4 + ", Win");
                }
            }
            else if (x % 3 == 0 && x != 0)
            {
                if (x == 3)
                {
                    Console.WriteLine(xminus1 + "/" + x + "/" + xplus2 + "/" + xplus3 + ", Win");
                }
                else if (x == 36)
                {
                    Console.WriteLine(xminus4 + "/" + xminus3 + "/" + xminus1 + "/" + x + ", Win");
                }
                else
                {
                    Console.WriteLine(xminus4 + "/" + xminus3 + "/" + xminus1 + "/" + x + ", " +
                        xminus1 + "/" + x + "/" + xplus2 + "/" + xplus3 + ", Win");
                }
            }
        }
    }
}
