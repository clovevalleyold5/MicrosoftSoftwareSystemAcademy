using System;
using System.Collections.Generic;

namespace BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("bin<2>, oct<8>, or dec<10>: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("the positive number to convert: ");
            if (choice == 10)
            {
                int dec = int.Parse(Console.ReadLine());
                Console.WriteLine("bin conversion is: " + DecToBin(dec));
                Console.WriteLine("oct conversion is: " + DecToOct(dec));
            }
            else if (choice == 2)
            {
                string bin = Console.ReadLine();
                Console.WriteLine("oct conversion is: " + BinToOct(bin));
                Console.WriteLine("dec conversion is: " + BinToDec(bin));
            }
            else if (choice == 8)
            {
                string oct = Console.ReadLine();
                Console.WriteLine("dec conversion is: " + OctToDec(oct));
                Console.WriteLine("dec conversion is: " + OctToBin(oct));
            }
            else
            {
                throw new Exception("invalid input");
            }
        }
        public static string DecToBin(int dec)
        {
            List<int> remainder = new List<int>();
            int temp = dec;
            for (; ; )
            {
                int tempRemainder = temp % 2;
                remainder.Add(tempRemainder);
                temp = temp / 2;
                if (temp == 0)
                {
                    break;
                }
            }
            string bin = "";
            for (int i = remainder.Count - 1; i >= 0; i--)
            {
                bin = bin + remainder[i];
            }
            return bin;
        }
        public static string DecToOct(int dec)
        {
            List<int> remainder = new List<int>();
            int temp = dec;
            for (; ; )
            {
                int tempRemainder = temp % 8;
                remainder.Add(tempRemainder);
                temp = temp / 8;
                if (temp == 0)
                {
                    break;
                }
            }
            string oct = "";
            for (int i = remainder.Count - 1; i >= 0; i--)
            {
                oct = oct + remainder[i];
            }
            return oct;
        }
        public static int BinToDec(string bin)
        {
            int[] input = new int[bin.Length];
            for (int i = 0; i < bin.Length; i++)
            {
                string temp = bin[i].ToString();
                if (temp == "0")
                {
                    input[i] = 0;
                }
                else if (temp == "1")
                {
                    input[i] = 1;
                }
                else
                {
                    throw new Exception("invalid input");
                }
            }
            int dec = 0;
            for (int i = 1; i <= input.Length; i++)
            {
                dec = dec + (int)(Math.Pow(2, i - 1) * input[input.Length - i]);
            }
            return dec;
        }
        public static string BinToOct(string bin)
        {
            int dec = BinToDec(bin);
            string oct = DecToOct(dec);
            return oct;
        }
        public static string OctToBin(string oct)
        {
            int dec = OctToDec(oct);
            string bin = DecToBin(dec);
            return bin;
        }
        public static int OctToDec(string oct)
        {
            int[] input = new int[oct.Length];
            for (int i = 0; i < oct.Length; i++)
            {
                string temp = oct[i].ToString();
                if (temp == "0")
                {
                    input[i] = 0;
                }
                else if (temp == "1")
                {
                    input[i] = 1;
                }
                else if (temp == "2")
                {
                    input[i] = 2;
                }
                else if (temp == "3")
                {
                    input[i] = 3;
                }
                else if (temp == "4")
                {
                    input[i] = 4;
                }
                else if (temp == "5")
                {
                    input[i] = 5;
                }
                else if (temp == "6")
                {
                    input[i] = 6;
                }
                else if (temp == "7")
                {
                    input[i] = 7;
                }
                else
                {
                    throw new Exception("invalid input");
                }
            }
            int dec = 0;
            for (int i = 1; i <= input.Length; i++)
            {
                dec = dec + (int)(Math.Pow(8, i - 1) * input[input.Length - i]);
            }
            return dec;
        }
    }
}
