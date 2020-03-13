﻿using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
