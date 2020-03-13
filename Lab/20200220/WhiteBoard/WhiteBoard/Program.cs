using System;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "mississippi";
            int[] ages = {3,0,2,2,2,8,2,6,2,3};
            char[] myletter = mystring.ToCharArray();
            myfunction(myletter);
            countpair(ages);
        }

        private static void countpair(int[] ages)
        {
            int count = 0;
            for (int i = 0; i < ages.Length - 1; i++)
            {
                if (ages[i] == ages[i + 1])
                    count++;
            }
            Console.WriteLine("there are " + count + " pairs.");
        }

        private static void myfunction(char[] myletter)
        {
            char letterm = 'm';
            char letteri = 'i';
            char letters = 's';
            char letterp = 'p';
            int countm = 0;
            int counti = 0;
            int counts = 0;
            int countp = 0;
            for (int i = 0; i < myletter.Length; i++)
            {
                if (myletter[i] == letterm)
                    countm++;
            }
            Console.WriteLine("letter m shows " + countm);
            for (int i = 0; i < myletter.Length; i++)
            {
                if (myletter[i] == letteri)
                    counti++;
            }
            Console.WriteLine("letter i shows " + counti);
            for (int i = 0; i < myletter.Length; i++)
            {
                if (myletter[i] == letters)
                    counts++;
            }
            Console.WriteLine("letter s shows " + counts);
            for (int i = 0; i < myletter.Length; i++)
            {
                if (myletter[i] == letterp)
                    countp++;
            }
            Console.WriteLine("letter p shows " + countp);
        }
    }
}
