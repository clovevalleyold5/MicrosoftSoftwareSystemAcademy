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
            bool validInput1 = false;
            while (!validInput1)
            {
                Console.WriteLine("\nPart 1, circumference and area of a circle.");
                Console.Write("Enter an integer for the radius: ");
                try
                {
                    uint input = uint.Parse(Console.ReadLine());
                    if (input != 0)
                    {
                        validInput1 = true;
                    }
                    double circumference = 2 * Math.PI * input;
                    double area = Math.PI * input * input;
                    Console.WriteLine($"The circumference is {circumference}");
                    Console.WriteLine($"The area is {area}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is out of range.");
                }
                finally
                {
                    Console.WriteLine("Your number is OK.");
                }
            }
            bool validInput2 = false;
            while (!validInput2)
            {
                Console.WriteLine("\nPart 2, volume of a hemisphere.");
                Console.Write("Enter an integer for the radius: ");
                try
                {
                    uint input = uint.Parse(Console.ReadLine());
                    if (input != 0)
                    {
                        validInput2 = true;
                    }
                    double volume = 2 * Math.PI * input * input * input / 3;
                    Console.WriteLine($"The circumference is {volume}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is out of range.");
                }
                finally
                {
                    Console.WriteLine("Your number is OK.");
                }
            }
            bool validInput3 = false;
            while (!validInput3)
            {
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                Console.WriteLine("Enter an integer for side A: ");
                Console.WriteLine("Enter an integer for side B: ");
                Console.WriteLine("Enter an integer for side C: ");
                try
                {
                    uint intA = uint.Parse(Console.ReadLine());
                    uint intB = uint.Parse(Console.ReadLine());
                    uint intC = uint.Parse(Console.ReadLine());
                    if (intA != 0 || intB != 0 || intC != 0)
                    {
                        validInput3 = true;
                    }
                    double p = (intA + intB + intC) / 2;
                    double areaOfTriangle = Math.Sqrt(p * (p - intA) * (p - intB) * (p - intC));
                    Console.WriteLine($"The area is {areaOfTriangle}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is out of range.");
                }
                finally
                {
                    Console.WriteLine("Your number is OK.");
                }
            }
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
            Console.ReadLine();
        }
    }
}