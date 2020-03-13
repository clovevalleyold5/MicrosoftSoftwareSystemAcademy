using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " "};
            string value = "I think, therefore I am.";
            Console.WriteLine("The test string is [" + value + "]");
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("The length of string array is " + words.Length + ".");
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + " " + words[i]);
            }
        }
    }
}
