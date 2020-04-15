using System;
using System.Collections.Generic;
using System.IO;

namespace HistoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testset = Test.Initialize();
            Console.WriteLine("test initialized, " + testset.Count + " question(s) loaded");
            Console.Write("how many question(s) (1- " + testset.Count + ") do you want to take: ");
            int numberofquestions = int.Parse(Console.ReadLine());
            List<string> test = Test.MakeTest(testset, numberofquestions);
            Console.WriteLine("test created, " + test.Count + " questions");
            int score = Test.GiveTest(test);
            Console.WriteLine("you answered " + score + " out of " + numberofquestions + " right");
        }
    }
    internal class Test
    {
        internal static List<string> Initialize()
        {
            List<string> testset = new List<string>();
            var reader = new StreamReader(@"C:\Users\Five\MSSA\Exercise\20200420\pres-test.csv");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                testset.Add(line);
            }
            return testset;
        }
        internal static List<string> MakeTest(List<string> testset, int numberofquestions)
        {
            List<string> test = new List<string>();
            for (int i = 0; i < numberofquestions; i++)
            {
                string question = testset[i];
                test.Add(question);
            }
            return test;
        }
        internal static int GiveTest(List<string> test)
        {
            int score = 0;
            int questionnumber = 1;
            Random random = new Random();
            foreach (string line in test)
            {
                string[] values = line.Split(',');
                Dictionary<int, string> numberoptionpair = new Dictionary<int, string>();
                HashSet<int> exsitedoption = new HashSet<int>();
                for (int i = 0; i < values.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(questionnumber + "." + values[i] + " ");
                    }
                    else
                    {
                        int randomoption = random.Next(1, 5);
                        while (exsitedoption.Contains(randomoption))
                        {
                            randomoption = random.Next(1, 5);
                        }
                        exsitedoption.Add(randomoption);
                        char[] charstotrim = { '"', ' ' };
                        string optiontext = values[randomoption].Trim(charstotrim);
                        Console.WriteLine(i + "). " + optiontext);
                        numberoptionpair.Add(i, values[randomoption]);
                    }
                }
                Console.Write("your answer: ");
                int attempt = int.Parse(Console.ReadLine());
                string answer = values[1];
                string attempttext = "";
                numberoptionpair.TryGetValue(attempt, out attempttext);
                if (attempttext != null && attempttext.Equals(answer))
                {
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    char[] charstotrim = { '"', ' ' };
                    Console.WriteLine("wrong, the correct one is " + answer.Trim(charstotrim));
                }
                questionnumber++;
            }
            return score;
        }
    }
}
