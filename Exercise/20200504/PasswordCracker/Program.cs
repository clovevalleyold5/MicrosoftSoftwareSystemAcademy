using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracker
{
    class Program
    {

        static void Main(string[] args)
        {
            Encoding ascii = Encoding.ASCII;
            int[] asciiInt = Enumerable.Range(33, 90).ToArray();
            byte[] asciiByte = asciiInt.Select(x => (byte)x).ToArray();
            string asciiString = ascii.GetString(asciiByte);
            char[] asciiChar = asciiString.ToCharArray();
            Console.Write("how long: ");
            int lengthOfInput = int.Parse(Console.ReadLine());
            Console.Write("password: ");
            string password = Console.ReadLine();
            List<List<char>> allCombinations = Combine(asciiChar, lengthOfInput);
            Stopwatch watch = Stopwatch.StartNew();
            foreach (var combination in allCombinations)
            {
                string possiblePassword = new string(combination.ToArray());
                if (possiblePassword == password)
                {
                    Console.WriteLine("got it, the password is " + possiblePassword);
                }
                //Console.WriteLine(possiblePassword);
            }
            Console.WriteLine("duration (ms): " + watch.ElapsedMilliseconds);
        }
        public static List<List<char>> Combine(char[] asciiChar, int lengthOfInput)
        {
            List<List<char>> allCombinations = new List<List<char>>();
            List<char> combination = new List<char>();
            if (asciiChar.Length == 0 || lengthOfInput == 0)
            {
                return allCombinations;
            }
            DFShelper(asciiChar, lengthOfInput, combination, allCombinations);
            return allCombinations;
        }
        private static void DFShelper(char[] asciiChar, int lengthOfInput, List<char> combination, List<List<char>> allCombinations)
        {
            if (combination.Count == lengthOfInput)
            {
                allCombinations.Add(new List<char>(combination));
                return;
            }
            for (int i = 0; i < asciiChar.Length; i++)
            {
                combination.Add(asciiChar[i]);
                DFShelper(asciiChar, lengthOfInput, combination, allCombinations);
                combination.RemoveAt(combination.Count - 1);
            }
        }




    }
}
