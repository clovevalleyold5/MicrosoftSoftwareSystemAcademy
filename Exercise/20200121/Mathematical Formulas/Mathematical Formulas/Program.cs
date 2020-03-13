using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strRadiusOfC = Console.ReadLine();
            int intRadiusOfC = int.Parse(strRadiusOfC);
            double circumference = 2 * Math.PI * intRadiusOfC;
            Console.WriteLine($"The circumference is {circumference}");
            Console.WriteLine();
            Console.Write("Enter an integer for the radius: ");
            string strRadiusOfA = Console.ReadLine();
            int intRadiusOfA = int.Parse(strRadiusOfA);
            double area = Math.PI * intRadiusOfA * intRadiusOfA;
            Console.WriteLine($"The area is {area}");
            //Console.WriteLine();

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            string strRadiusOfV = Console.ReadLine();
            int intRadiusOfV = int.Parse(strRadiusOfV);
            double volume = 2 * Math.PI * intRadiusOfV * intRadiusOfV * intRadiusOfV / 3;
            Console.WriteLine($"The volume is {volume}");
            //Console.WriteLine();

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for side A: ");
            string strA = Console.ReadLine();
            int intA = int.Parse(strA);
            Console.Write("Enter an integer for side B: ");
            string strB = Console.ReadLine();
            int intB = int.Parse(strB);
            Console.Write("Enter an integer for side C: ");
            string strC = Console.ReadLine();
            int intC = int.Parse(strC);
            double p = (intA + intB + intC) / 2;
            double areaOfTriangle = Math.Sqrt(p * (p - intA) * (p - intB) * (p - intC));
            Console.WriteLine($"The area is {areaOfTriangle}");
            //Console.WriteLine();

            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("aX^2 + bX + c = 0");
            Console.Write("Enter an integer for a: ");
            string stra = Console.ReadLine();
            int inta = int.Parse(stra);
            Console.Write("Enter an integer for b: ");
            string strb = Console.ReadLine();
            int intb = int.Parse(strb);
            Console.Write("Enter an integer for c: ");
            string strc = Console.ReadLine();
            int intc = int.Parse(strc);
            double X1 = (0 - intb + Math.Sqrt(intb * intb - 4 * inta * intc)) / (2 * inta);
            double X2 = (0 - intb - Math.Sqrt(intb * intb - 4 * inta * intc)) / (2 * inta);
            Console.WriteLine($"X1 is {X1}");
            Console.WriteLine($"X2 is {X2}");
        }
    }
}
