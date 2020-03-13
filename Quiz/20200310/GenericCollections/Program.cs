using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("here is the stack");
            Stack<string> numbers = new Stack<string>();
            foreach (string number in new string[3] { "one", "two", "three" })
            {
                numbers.Push(number);
            }
            while (numbers.Count > 0)
            {
                string number = numbers.Pop();
                Console.WriteLine(number);
            }

            Console.WriteLine("here is the queue");
            Queue<string> numberq = new Queue<string>();
            foreach (string number in new string[3] { "one", "two", "three" })
            {
                numberq.Enqueue(number);
            }
            while (numberq.Count > 0)
            {
                string number = numberq.Dequeue();
                Console.WriteLine(number);
            }

            Console.WriteLine("here is the dictionary");
            Dictionary<string, int> numberd = new Dictionary<string, int>();
            numberd.Add("one", 1);
            numberd.Add("two", 2);
            numberd.Add("three", 3);
            foreach (KeyValuePair<string, int> element in numberd)
            {
                string s = element.Key;
                int i = element.Value;
                Console.WriteLine(s + " " + i);
            }
        }
    }
}
