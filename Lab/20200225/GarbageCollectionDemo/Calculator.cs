﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }
        public void Dispose()
        {
            Console.WriteLine("Calculator being disposed");
        }
    }
}
